using Ideas_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Diagnostics;

namespace Ideas_Bank.Business_logic
{
    public class Main
    {
        private static List<Idea> Ideas_data = new List<Idea>();
        Idea Current_Idea = new Idea();

        public static List<Idea> Run_Logic()
        {
            Load_Data(Ideas_Bank.Properties.Settings.Default.Default_Connection_String, Ideas_data);
            return Ideas_data; ;
        }
        private static void Load_Data(string Address, List<Idea> Ideas_List)
        {
            OleDbConnection Basic_Connection = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + Address);
            string Basic_connectionstring = "";
            OleDbCommand Basic_Readcommand = new OleDbCommand();
            Debug.WriteLine("Hi");
        }
    }

}