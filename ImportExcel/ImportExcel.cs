using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AccidentForecast
{  
    public enum Area
    {
        [Description("0")]
        Obl = 0,
        [Description("Волов")]
        Vol=1,
        [Description("Гряз")]
        Grz=2,
        [Description("Данков")]
        Dan = 3,
        [Description("Добрин")]
        Dobrin = 4,
        [Description("Добро")]
        Dobrov = 5,
        [Description("Долгорук")]
        Dolg = 6,
        [Description("Елецкий")]
        Elck = 7,
        [Description("Задон")]
        Zadon = 8,
        [Description("Измал")]
        Izmal = 9,
        [Description("Красн")]
        Krsn = 10,
        [Description("Лебед")]
        Leb = 11,
        [Description("Лев")]
        Lev = 12,
        [Description("Липецкий")]
        Lipeck = 13,
        [Description("Стано")]
        Stan = 14,
        [Description("Тербу")]
        Terb = 15,
        [Description("Усман")]
        Usm = 16,
        [Description("Хлев")]
        Hlev = 17,
        [Description("Чаплыг")]
        Chapl = 18,
        [Description("г. Елец")]
        El = 19,
        [Description("г. Липецк")]
        Lip = 20,
    }
    static class EnumExtensions
    {
        static public string Description(this Area value)
        {
            var attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(false)
                .FirstOrDefault(a=> a is DescriptionAttribute) as DescriptionAttribute;

            return attribute !=null ? attribute.Description : value.ToString();
        }
    }

    public class ImportExcel
    {
        //Факторы
        public static void LoadExcelFactors(string listName, string pathName);

       //ЖКХ
        public static void LoadExcelHaCS(string listName, string pathName);

        //ДТП
        public static void LoadExcelAccident(string listName, string pathName);

       //Пожары
        public static void LoadExcelFires(string listName, string pathName);

    }
}