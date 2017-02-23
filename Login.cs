using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gold
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // Zmienne przechowujace wartosc z textboxow
            string login = login_user.Text;
            string password = user_password.Text;

            // Konfiguracja polaczenia z bazda danych
            String config = "datasource=localhost;port=3306;username=michal;password=zaq1;database=gold"; 

            //Instancja polaczenia z baza danych
            MySqlConnection connect = new MySqlConnection(config);

            // Zaoytanie oraz obeikt odczytujacy Funkcja PASSWORD() koduje do md5
            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE login = '"+login+"' AND password = PASSWORD('"+password+"');",connect);
            MySqlDataReader read_db_query;


            if(login == "" || password == "")
            {
                MessageBox.Show("Należy podać pełne dane do logowania!");
            }
            else
            {
                try
                {
                    connect.Open(); // otwarcie polaczenia z baza
                    read_db_query = command.ExecuteReader(); // Wywolanie zaptanie i przypisanie do obiektu;

                    if (read_db_query.Read())
                    {
                        // .GetInt32(0) Pobiera wartość z kolumny o indeksie 0 i rzutuje ja na inta
                        Main main_window = new Main(read_db_query.GetInt32(0));
                        main_window.Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło");
                    }
                }
                catch (Exception warning)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych");
                }
                connect.Close(); // Zamkniecie polaczenia z baza
            }
            user_password.Text = "";
        }
    }
}
