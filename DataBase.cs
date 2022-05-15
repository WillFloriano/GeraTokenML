using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace GeraToken
{
    class DataBase
    {
        private static SQLiteConnection conection;

        private static SQLiteConnection ConectionDataBase()
        {
            conection = new SQLiteConnection("Data Source =" + Global.pathdatabase);
            conection.Open();
            return conection;
        }

        public static DataTable GetUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectionDataBase().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_USER";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectionDataBase());
                    da.Fill(dt);
                    ConectionDataBase().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConectionDataBase().Close();
                throw ex;
            }

        }

        public static DataTable request(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectionDataBase().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectionDataBase());
                    da.Fill(dt);
                    ConectionDataBase().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConectionDataBase().Close();
                throw ex;
            }
        }
        public static DataTable insert(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectionDataBase().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectionDataBase());
                    da.Fill(dt);
                    ConectionDataBase().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConectionDataBase().Close();
                throw ex;
            }
        }

        public static DataTable update(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectionDataBase().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectionDataBase());
                    da.Fill(dt);
                    ConectionDataBase().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConectionDataBase().Close();
                throw ex;
            }
        }

        public static DataTable exclui(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectionDataBase().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectionDataBase());
                    da.Fill(dt);
                    ConectionDataBase().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConectionDataBase().Close();
                throw ex;
            }
        }
    }
}
