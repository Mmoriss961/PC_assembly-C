using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BD_connect
    { 
        MySqlConnection connection = new MySqlConnection("server=f0441836.xsph.ru;Port=3306;user=f0441836;password=becuxeuvew;database=f0441836_servis_bd");
        

        public void OpenConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }

            public void CloseConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();

            }

            public MySqlConnection GetConnection() => connection;
        }
    }

