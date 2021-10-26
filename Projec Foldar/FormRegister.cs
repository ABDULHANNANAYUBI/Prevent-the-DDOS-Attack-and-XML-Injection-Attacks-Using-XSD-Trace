using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finite_Automata
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user;
            IPGenerator ıPGenerator = new IPGenerator();

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                user = new User(txtUsername.Text, txtPassword.Text, ıPGenerator.GenerateIP(), DateTime.Now, DateTime.Now, 0);
                DB.Add(user);
                MessageBox.Show("Registration is successfull!", "Register Complete");
            }
            else
                MessageBox.Show("Passwords is not matched!", "ERROR");
        }
    }
}
