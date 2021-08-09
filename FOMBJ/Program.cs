using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FOMBJ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Conexao Geral = new Conexao();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FORMPRINCIPAL());
        }
    }

    public class Conexao
    {
        public Conexao()
        {

        }
        public MySqlConnection mConn;

        public Boolean CriaConexao()
        {
            mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=fombj;uid=root;pwd=teste");

            try
            {
                mConn.Open();
            }
            catch (System.Exception oErro)
            {
                return false;
            }
            return true;

        }

        public Boolean FecharConexao()
        {
            mConn.Close();
            return true;
        }
    }

    public class Insert
    {
        public Insert(MySqlConnection mySqlConnection, MySqlCommand Insert)
        {
            mSqlExecConnExec = mySqlConnection;
            cmdInsert        = Insert;
        }

        public MySqlConnection  mSqlExecConnExec;
        public MySqlCommand     cmdInsert;

        public Boolean Executar()
        {
            if (mSqlExecConnExec.State == ConnectionState.Open)
            {
                cmdInsert.Connection = mSqlExecConnExec;
                cmdInsert.ExecuteNonQuery();
                return true; 
            }
            return false;
        }
    }
}