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