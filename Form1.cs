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

        // Przycisk restartujacy zmiana hasla
        private void btReset_Click(object sender, EventArgs e)
        {
            oldPassword.Text = "";
            newPassword.Text = "";
            repeatNewPassword.Text = "";
            btChange.Enabled = false;
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

        //Formularz stare haslo
        private void check_draw(object sender, EventArgs e)
        {
            if (oldPassword.Text != "" && newPassword.Text != "" &&
                newPassword.Text == repeatNewPassword.Text)
            {
                bt_changePassword.Enabled = true;
            }
            else bt_changePassword.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
