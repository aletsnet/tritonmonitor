using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace TritonMonitor
{
    class Conect
    {
        private SQLiteConnection DB;
        private string passdb = "tr1tr0nb4s1c";

        public Conect()
        {
            string conectstring = @"Data Source=.\monitor.xml; Version=3; Password=" + passdb;
            DB = new SQLiteConnection(conectstring);
            DB.Open();
        }
        public DataTable Consulta(String SQL)
        {
            var listAll = new DataTable();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(SQL, DB))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        listAll.Load(dr);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + SQL + " \n \n \nError:" + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listAll;
        }

        public DataTable Consulta(String SQL, Dictionary<String, String> param)
        {
            var Lista = new DataTable();
            try
            {
                List<string> list = new List<string>(param.Keys);
                using (SQLiteCommand cmd = new SQLiteCommand(SQL, DB))
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        Lista.Load(dr);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + SQL + " \n \n \nError:" + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Lista;
        }

        public void Comando(String SQL)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(SQL, DB);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + SQL + " \n \n \nError:" + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Comando(String SQL, Dictionary<String, String> param)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(SQL, DB))
                {
                    foreach (var item in param)
                    {
                        command.Parameters.AddWithValue(item.Key, item.Value);
                    }
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + SQL + " \n \n \nError:" + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int keyID(string tabla)
        {
            int key = 0;
            try
            {
                string sql = "select * from sqlite_sequence where name='" + tabla + "';";
                SQLiteCommand command = new SQLiteCommand(sql, DB);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    key = Int32.Parse(reader["seq"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return key;
        }

        public DataRow Row(String SQL)
        {
            var listAll = new DataTable();
            DataRow row = null;
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(SQL, DB))
                {
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        listAll.Load(dr);
                        if (listAll.Rows.Count > 0)
                        {
                            row = listAll.Rows[0];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + SQL + " \n \n \nError:" + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return row;
        }

        public DataRow Row(String SQL, Dictionary<String, String> param)
        {
            var Lista = new DataTable();
            DataRow row = null;
            try
            {
                List<string> list = new List<string>(param.Keys);
                using (SQLiteCommand cmd = new SQLiteCommand(SQL, DB))
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        Lista.Load(dr);
                        if (Lista.Rows.Count > 0)
                        {
                            row = Lista.Rows[0];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un problema: " + SQL + " \n \n \nError:" + e, "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return row;
        }
    }
}
