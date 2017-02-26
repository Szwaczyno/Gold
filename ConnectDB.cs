using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Gold
{
    class ConnectDB
    {
        string config;
        MySqlConnection connect;
        MySqlCommand command;

        MySqlDataAdapter dataAdapter;
        BindingSource source;

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
            startConnect(a_querry);
            try
            {
                command = new MySqlCommand(a_querry, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    query_good = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Błąd połączenie z bazą danych!");
            }

            connect.Close();
        }

        public void selectQuerry(string a_querry)
        {
            startConnect(a_querry);
            try
            {
                command = new MySqlCommand(a_querry, connect);
                response = command.ExecuteReader();
                if(response.Read())
                {
                    query_good = true;
                }
            }catch(Exception e)
            {
                MessageBox.Show("Błąd połączenia z bazą danych!");
            }
            connect.Close();
        }

        public BindingSource sendQueryReciveTable(string a_querry)
        {

            this.startConnect(a_querry);
            command = new MySqlCommand(a_querry, connect);
            dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            source = new BindingSource();

            source.DataSource = dataTable;

            try
            {

            }
            catch(Exception e)
            {
                MessageBox.Show("Błąd połączenia z bazą danych "+e);
            }
            return source;
            connect.Close();
        }

        private void startConnect(string a_querry)
        {
            query_good = false;
            connect.Open();
        }

    }
}
