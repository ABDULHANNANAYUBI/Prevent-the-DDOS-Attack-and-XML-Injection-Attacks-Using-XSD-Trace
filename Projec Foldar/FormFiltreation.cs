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
    public partial class FormFiltreation : Form
    {
        public FlowLayoutPanel FlpFinalList = new FlowLayoutPanel();
        public static ListView listViewNew;
        public FormFiltreation()
        {
            InitializeComponent();
            timer1.Start();
            listViewNew = new ListView();
            lstViewFinal.View = View.Details;
            lstViewFinal.GridLines = true;
            lstViewFinal.FullRowSelect = true;

            lstViewFinal.Columns.Add("USERNAME", 90);
            lstViewFinal.Columns.Add("IP", 120);
            lstViewFinal.Columns.Add("R. TIME", 90);
            lstViewFinal.Columns.Add("LAST L. TIME", 90);
            lstViewFinal.Columns.Add("L. COUNT", 80);

            chkboxStatic.Items.Add("Type will be checked", CheckState.Unchecked);
            chkboxStatic.Items.Add("Length will be checked", CheckState.Unchecked);
            chkboxStatic.Items.Add("Space permitted or not", CheckState.Unchecked);
            chkboxDynamic.Items.Add("Type will be checked", CheckState.Unchecked);
            chkboxDynamic.Items.Add("Length will be checked", CheckState.Unchecked);
            chkboxDynamic.Items.Add("Special character(?, #, $, &...) checks", CheckState.Unchecked);
            chkboxDynamic.Items.Add("First character of the column can be caps or some special indications", CheckState.Unchecked);
            chkboxDynamic.Items.Add("Numeric values permitted in the column", CheckState.Unchecked);

        }
        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void chkboxStatic_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int i = 0;
        public int TypeCheck(int i, int ifStatic)
        {
            if (listViewNew.Items[i].SubItems[0].Text is string)
            {
                if (ifStatic == 0)
                {
                    return 33;
                }
                else if (ifStatic == 1)
                {
                    return 20;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public int LenghtCheck(int i, int ifStatic)
        {
            /// sonradan Not işlemi kaldırılacak...!
            if ((listViewNew.Items[i].SubItems[0].Text.Length >= 8 && listViewNew.Items[i].SubItems[0].Text.Length < 14))
            {
                if (ifStatic == 0)
                {
                    return 33;
                }
                else if (ifStatic == 1)
                {
                    return 20;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public int SpaceCheck(int i, int ifStatic)
        {
            if (!(listViewNew.Items[i].SubItems[0].Text.Contains(" ")))
            {
                if (ifStatic == 0)
                {
                    return 34;
                }
                else if (ifStatic == 1)
                {
                    return 20;
                }
                else
                {
                    return 0;
                }
            }

            else
            {
                return 0;
            }
        }

        public int SpecialCharCheck(int id)
        {
            List<char> blockedChars = new List<char>();

            char[] tempChars = { '#', '&', '?', ',', '*', '.', '$' }; // blocked charecters

            blockedChars.AddRange(tempChars);
            string userName = listViewNew.Items[id].SubItems[0].Text;

            int flag = 0;

            for (int i = 0; i < userName.Length; i++)
            {
                if (blockedChars.Contains(userName[i])) // valid username
                {
                    flag = 1;
                    return 0;
                }
            }
            if (flag == 0) // not valid username
                return 20;

            return 0;
        }
        public int FirstCharCheck(int id)
        {
            string firstChar = listViewNew.Items[id].SubItems[0].Text;
            char secondChar = firstChar[0];
            bool hasUpperCase = char.IsUpper(secondChar);

            if (hasUpperCase)
                return 20;

            return 0;
        }

        public int NumericCharCheck(int id)
        {
            string firstChar = listViewNew.Items[id].SubItems[0].Text;
            bool containsInt = firstChar.Any(char.IsDigit);
            if (containsInt)
                return 20;

            return 0;
        }

        int k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNextDynamic.Enabled = false;
            btnNextDynamic.Visible = false;

            lblUser.Text = listViewNew.Items[k].SubItems[0].Text;
            if (TypeCheck(k, 0) == 33)
            {
                prgsBarLoadingStatic.Increment(TypeCheck(k, 0));
                chkboxStatic.SetItemChecked(0, true);
            }
            if (LenghtCheck(k, 0) == 33)
            {
                prgsBarLoadingStatic.Increment(LenghtCheck(k, 0));
                chkboxStatic.SetItemChecked(1, true);
            }
            if (SpaceCheck(k, 0) == 34)
            {
                prgsBarLoadingStatic.Increment(SpaceCheck(k, 0));
                chkboxStatic.SetItemChecked(2, true);
            }
            timer1.Stop();
        }
        int n = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            prgsBarLoadingStatic.Value = 0;
            for (int i = 0; i < chkboxStatic.Items.Count; i++)
            {
                if (chkboxStatic.GetItemChecked(i))
                {
                    chkboxStatic.SetItemChecked(i, false);
                }
            }
            k++;
            if (k == listViewNew.Items.Count)
            {
                timer1.Stop();
                MessageBox.Show("Ther is not Enough User");
                prgsBarLoadingStatic.Value = 0;
                prgsBarGeneral.Increment(50);
                timer2.Start();
                k = 0;
                btnNext.Enabled = false;
                btnNextDynamic.Enabled = true;
                btnNextDynamic.Visible = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            lblUser.Text = listViewNew.Items[n].SubItems[0].Text;
            if(TypeCheck(n, 1) == 20)
            {
                prgsBarLoadingDynamic.Increment(20);
                chkboxDynamic.SetItemChecked(0, true);
            }
            if(LenghtCheck(n,1) == 20)
            {
                prgsBarLoadingDynamic.Increment(20);
                chkboxDynamic.SetItemChecked(1, true);
            }
            if (SpecialCharCheck(n) == 20)
            {
                prgsBarLoadingDynamic.Increment(SpecialCharCheck(n));
                chkboxDynamic.SetItemChecked(2, true);
            }
            if(FirstCharCheck(n) == 20)
            {
                chkboxDynamic.SetItemChecked(3, true);
                prgsBarLoadingDynamic.Increment(FirstCharCheck(n));
            }
            if (NumericCharCheck(n) == 20)
            {
                prgsBarLoadingDynamic.Increment(NumericCharCheck(n));
                chkboxDynamic.SetItemChecked(4, true);
            }
            timer2.Stop();
        }
        private void FormFiltreation_Load(object sender, EventArgs e)
        {
        }
        bool enterFlag = false;
        private void btnNextDynamic_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < chkboxDynamic.Items.Count; i++)
            {
                if (chkboxDynamic.GetItemChecked(i) == false)
                {
                    flag = false;
                    break;
                }
            }
            if (flag && !enterFlag)
            {
                string[] row = { listViewNew.Items[n].SubItems[0].Text, listViewNew.Items[n].SubItems[1].Text,
                    listViewNew.Items[n].SubItems[2].Text, listViewNew.Items[n].SubItems[3].Text, listViewNew.Items[n].SubItems[4].Text };
                ListViewItem myRow = new ListViewItem(row);
                lstViewFinal.Items.Add(myRow);
            }
            n++;
            timer2.Start();
            if (n == listViewNew.Items.Count)
            {
                prgsBarLoadingDynamic.Value = 0;
                timer2.Stop();
                MessageBox.Show("Ther is not Enough User");
                n = 0;
                enterFlag = true;
                prgsBarGeneral.Increment(50);
                lblUser.Text = "";
                prgsBarLoadingDynamic.Value = 0;
            }
            prgsBarLoadingDynamic.Value = 0;
            
            for (int i = 0; i < chkboxDynamic.Items.Count; i++)
            {
                if (chkboxDynamic.GetItemChecked(i))
                {
                    chkboxDynamic.SetItemChecked(i, false);
                }
            }
        }
    }
}
