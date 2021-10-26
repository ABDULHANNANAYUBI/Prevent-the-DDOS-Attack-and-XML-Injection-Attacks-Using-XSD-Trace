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
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFiltreation formFiltreation = new FormFiltreation();
            formFiltreation.Show();
            FormFiltreation.listViewNew = Application.OpenForms["FormInformation"].Controls["flwLayotPnl"].Controls[0] as ListView;

        }
    }
}
