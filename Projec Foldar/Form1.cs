using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finite_Automata
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;

            foreach (var item in DB.users)
            {
                if (item.Username == txtUsername.Text && item.Password == txtPassword.Text)
                {
                    item.CountLogin++;
                    item.LastLoginTime = DateTime.Now;

                    notify = new NotifyIcon();
                    notify.BalloonTipText = "You have successfully logined!";
                    notify.BalloonTipTitle = "Login Successfull";
                    notify.Visible = true;
                    notify.Icon = SystemIcons.Information;
                    notify.BalloonTipIcon = ToolTipIcon.Info;
                    notify.ShowBalloonTip(1500);

                    Thread.Sleep(2000);

                    FormDDoS formDDoS = new FormDDoS();
                    formDDoS.Show();

                    flag = true;
                    break;
                }
            }

            if (flag == false)
            {
                notify = new NotifyIcon();
                notify.BalloonTipText = "Your username or password is wrong!";
                notify.BalloonTipTitle = "ERROR";
                notify.Visible = true;
                notify.Icon = SystemIcons.Information;
                notify.BalloonTipIcon = ToolTipIcon.Info;
                notify.ShowBalloonTip(1500);
            }
        }

        /// This code was taken from stackoverflow.com
        /// Not written by us!
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
