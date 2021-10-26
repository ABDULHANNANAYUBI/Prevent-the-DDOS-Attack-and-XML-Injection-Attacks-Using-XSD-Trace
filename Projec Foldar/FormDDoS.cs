using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finite_Automata
{
    public partial class FormDDoS : Form
    {
        List<User> tempList = new List<User>();


        public FormDDoS()
        {
            InitializeComponent();
        }

        private void FormDDoS_Load(object sender, EventArgs e)
        {
            listInfos.View = View.Details;
            listInfos.GridLines = true;
            listInfos.FullRowSelect = true;

            listLastLoginInfo.View = View.Details;
            listLastLoginInfo.GridLines = true;
            listLastLoginInfo.FullRowSelect = true;

            listInfos.Columns.Add("USERNAME", 90);
            listInfos.Columns.Add("IP", 120);
            listInfos.Columns.Add("R. TIME", 90);
            listInfos.Columns.Add("LAST L. TIME", 90);
            listInfos.Columns.Add("L. COUNT", 80);

            listLastLoginInfo.Columns.Add("USERNAME", 90);
            listLastLoginInfo.Columns.Add("IP", 120);
            listLastLoginInfo.Columns.Add("R. TIME", 90);
            listLastLoginInfo.Columns.Add("LAST L. TIME", 90);
            listLastLoginInfo.Columns.Add("L. COUNT", 80);

            //foreach (var item in DB.users)
            //{
            //    string[] row = { item.Username, item.IP, item.RegistrationTime.ToString(), item.LastLoginTime.ToString(), item.CountLogin.ToString() };
            //    ListViewItem myRow = new ListViewItem(row);
            //    listInfos.Items.Add(myRow);
            //}

            //List<User> tempList = new List<User>();
            //tempList = DB.users.OrderBy(x => x.LastLoginTime).ToList();

            //string[] row2 = { tempList[tempList.Count - 1].Username, tempList[tempList.Count - 1].IP, tempList[tempList.Count - 1].RegistrationTime.ToString(), tempList[tempList.Count - 1].LastLoginTime.ToString(), tempList[tempList.Count - 1].CountLogin.ToString() };
            //ListViewItem myRow2 = new ListViewItem(row2);
            //listLastLoginInfo.Items.Add(myRow2);

            //double totalLoginCount = 0;
            //foreach (var item in DB.users)
            //{
            //    totalLoginCount += item.CountLogin;
            //}

            //rchInfo.Text = "Average Login Count of Users: " + Convert.ToDouble((totalLoginCount / DB.users.Count)).ToString() +
            //    Environment.NewLine + Environment.NewLine + tempList[tempList.Count - 1].Username + " (" + tempList[tempList.Count - 1].IP + ") --> " +
            //    tempList[tempList.Count - 1].CountLogin + " times login.";


        }


        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int i = 0;
        double totalLoginCount1 = 0;
        int counter1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int totalLoginCount = 0;
            DB.users[i].CountLogin += rnd.Next(1, 3);
            string[] row = { DB.users[i].Username, DB.users[i].IP, DB.users[i].RegistrationTime.ToString(), DB.users[i].LastLoginTime.ToString(), DB.users[i].CountLogin.ToString() };
            ListViewItem myRow = new ListViewItem(row);
            listInfos.Items.Add(myRow);
            tempList = DB.users.OrderBy(x => x.LastLoginTime).ToList();

            string[] row2 = { listInfos.Items[listInfos.Items.Count - 1].SubItems[0].Text, listInfos.Items[listInfos.Items.Count - 1].SubItems[1].Text,
                listInfos.Items[listInfos.Items.Count - 1].SubItems[2].Text, listInfos.Items[listInfos.Items.Count - 1].SubItems[3].Text,
                listInfos.Items[listInfos.Items.Count - 1].SubItems[4].Text };
            ListViewItem myRow2 = new ListViewItem(row2);
            listLastLoginInfo.Items.Clear();
            listLastLoginInfo.Items.Add(myRow2);
            for (int i = 0; i < listInfos.Items.Count; i++)
            {
                totalLoginCount += Convert.ToInt32(listInfos.Items[i].SubItems[4].Text);
                totalLoginCount1 = totalLoginCount;
            }
            rchInfo.Text = "Average Login Count of Users: " + Convert.ToDouble(((double)totalLoginCount / (double)listInfos.Items.Count)).ToString() +
                Environment.NewLine + Environment.NewLine + listInfos.Items[listInfos.Items.Count - 1].SubItems[0].Text + " (" + listInfos.Items[listInfos.Items.Count - 1].SubItems[1].Text + ") --> " +
                listInfos.Items[listInfos.Items.Count - 1].SubItems[4].Text + " times login.";
            i++;
            if (i % DB.users.Count == 0)
            {
                i = 0;
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Hide();
            FormInformation frminfo = new FormInformation();
            frminfo.Show();
            ListView lstview = new ListView();
            lstview = listInfos;
            ListView temp = new ListView();
            double roundUp = Math.Ceiling(totalLoginCount1 / listInfos.Items.Count);
            foreach (ListViewItem item in listInfos.Items)
            {
                if (Convert.ToInt32(item.SubItems[4].Text) >= roundUp)
                    listInfos.Items.Remove(item);
            }

            Application.OpenForms["FormInformation"].Controls["flwLayotPnl"].Controls.Add(listInfos);
            
            Application.OpenForms["FormInformation"].Controls["lblAverage2"].Text = String.Format("{0:0.00}", roundUp);
        }
    }
}
