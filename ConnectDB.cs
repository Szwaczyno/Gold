using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gold
{
    class ConnectDB
    {
        string config;
        MySqlConnection connect;

        public MySqlDataReader response;
        public bool query_good;

        public void initialize()
        {
            config = "datasource=localhost;port=3306;username=michal;password=zaq1;database=gold";
            connect = new MySqlConnection(config);
            query_good = false;
        }

        public void sendUpdate(string a_querry)
        {
            try
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(a_querry,connect);
                
                if(command.ExecuteNonQuery() == 1)
                {
                    query_good = true;
                }
                else
                {
                    query_good = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Błąd połączenie z bazą danych ");
            }

    connect.Close();
        }
    }
}
