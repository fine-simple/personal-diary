using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
namespace Personal_Diary
{
    static class Globals
    {
        public const string ordb = "Data Source = orcl; User Id = scott; Password=tiger;";
        public static OracleConnection conn = new OracleConnection(ordb);
        public static string username = "";
    }
}