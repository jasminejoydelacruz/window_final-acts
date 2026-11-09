using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_final_acts
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateaccount_Click(object sender, EventArgs e)
        {
            UserData.FullName = txtFullname.Text;
            UserData.Username = txtUsername.Text;
            UserData.Email = txtEmail.Text;
            UserData.Password = txtPassword.Text;

            MessageBox.Show("Account Created Successfully!");

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
