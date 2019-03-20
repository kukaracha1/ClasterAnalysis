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
        public static void LoadExcelFactors(string listName, string pathName)
        {
            DataTable dtexcel = new DataTable();

            //string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\_LSTU\4 КУРС\1 семестр\Модельки\ЛР1\Лаб1_Тербуны\Абсолютные\Тербуны_влажность.xlsm;Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            string constr = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;'",pathName);
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                conn.Open();

                OleDbDataAdapter daexcel = new OleDbDataAdapter(String.Format("Select * from [{0}$]",listName), conn);
                dtexcel.Locale = CultureInfo.CurrentCulture;
                daexcel.Fill(dtexcel);
                conn.Close();
            }
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDBAccidents;Data Source=DESKTOP-PPEQF8T";
            string sql = "insert into Factors values (@A, @B, @C, @D,@E,@F,@G, @H,20)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (DataRow row in dtexcel.Rows)
                {
                    if (row["Дата"].ToString() == "")
                        break;
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@A", row["Дата"]);
                    cmd.Parameters.AddWithValue("@B", row[11]);
                    cmd.Parameters.AddWithValue("@C", row[12]);
                    cmd.Parameters.AddWithValue("@D", row[13]);
                    cmd.Parameters.AddWithValue("@E", row[14]);
                    cmd.Parameters.AddWithValue("@F", row[15]);
                    cmd.Parameters.AddWithValue("@G", row[16]);
                    cmd.Parameters.AddWithValue("@H", row[17]);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

       //ЖКХ
        public static void LoadExcelHaCS(string listName, string pathName);

        //ДТП
        public static void LoadExcelAccident(string listName, string pathName);

       //Пожары
        public static void LoadExcelFires(string listName, string pathName);

    }
}