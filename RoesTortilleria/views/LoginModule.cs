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
            string[] data = Datos.LogIn(username.Text, password.Text,true);

            if (data != null )
            {

                MainModule main = new MainModule(data[0],data[1]);
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
