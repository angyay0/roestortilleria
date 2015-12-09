using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoesTortilleria.views
{
    public partial class LoginModule : Form
    {
        public LoginModule()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (Datos.LogIn(username.Text, password.Text)>0)
            {

                MainModule main = new MainModule();
                this.Hide();
                main.ShowDialog();
                username.Text = "";
                password.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario/Pass incorrecto");
            }
        
                
        }
    }
}
