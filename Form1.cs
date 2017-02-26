using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gold
{
    public partial class Main : Form
    {
        int id_user_login;
        public Main(int id_user)
        {
            InitializeComponent();
            id_user_login = id_user;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        // -SETTINGS- Przycisk restartujacy pola tekstowe
        private void btReset_Click(object sender, EventArgs e)
        {
            oldPassword.Text = "";
            newPassword.Text = "";
            repeatNewPassword.Text = "";
            btChange.Enabled = false;
            txtNewLogin.Text = "";
            txtNewLogin_Password.Text = "";
        }

        //Przycisk wprowadzajacy zmiany zmiana hasla
        private void btChange_Click(object sender, EventArgs e)
        {
            ConnectDB db = new ConnectDB();
            db.initialize();
            db.sendUpdate("UPDATE user SET password = PASSWORD('"+newPassword.Text+"') WHERE idUser = '"+id_user_login+"' AND password = PASSWORD('"+oldPassword.Text+"')");

            if(db.query_good)
            {
                MessageBox.Show("Zmieniono haslo");
                btReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Haslo nie zostalo zmienione");
                btReset_Click(sender, e);
            }
            check_draw(sender, e);
        }

        // -SETINGS- Ustawianie przyciskow w tryb enebled 
        private void check_draw(object sender, EventArgs e)
        {
            if (oldPassword.Text != "" && newPassword.Text != "" &&
                newPassword.Text == repeatNewPassword.Text)
            {
                bt_changePassword.Enabled = true;
            }
            else bt_changePassword.Enabled = false;
            if (txtNewLogin_Password.Text != "" && txtNewLogin.Text != "")
            {
                btChangeLogin.Enabled = true;
            }
            else btChangeLogin.Enabled = false;
        }



        private void btChangeLogin_Click(object sender, EventArgs e)
        {
            ConnectDB db = new ConnectDB();
            db.initialize();
            db.sendUpdate("UPDATE user SET login = '"+txtNewLogin.Text+"' WHERE idUser = '"+id_user_login+"' AND password = PASSWORD('"+txtNewLogin_Password.Text+"');");

            if(db.query_good)
            {
                MessageBox.Show("Zaktualizowano login. Nowy login: "+ txtNewLogin.Text);
            }
            else
            {
                MessageBox.Show("Nie zaktualizowano loginu. Błędne hasło");
            }
            btReset_Click(sender, e);
            check_draw(sender, e);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void tab_password_Click(object sender, EventArgs e)
        {

        }

        private void bt_LOGOUT_Click(object sender, EventArgs e)
        {
            this.id_user_login = 0;

            Login login = new Login();
            login.Show();
            this.Close();
        }

        //Group box search person
        private void btResetSearchWorker_Click(object sender, EventArgs e)
        {
            txtSurnameWorker.Text = "";
        }
        private void txtSurnameWorker_TextChanged(object sender, EventArgs e)
        {
            if (txtSurnameWorker.Text != "") btSearchWorker.Enabled = true;
            else btSearchWorker.Enabled = false;
        }
        private void btSearchWorker_Click(object sender, EventArgs e)
        {
            ConnectDB db = new ConnectDB();
            db.initialize();
            BindingSource source = db.sendQueryReciveTable("SELECT imie AS Imie,nazwisko AS Nazwisko,login AS Login,pracownik AS Pracownik FROM user WHERE CONCAT(nazwisko,' ',imie) LIKE '%" + txtSurnameWorker.Text + "%' ORDER BY nazwisko;");
            girdUsers.DataSource = source;
        }
    }
}
