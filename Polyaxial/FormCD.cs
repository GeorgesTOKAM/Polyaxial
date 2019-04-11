using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyaxial
{
    public partial class FormCD : Form
    {
        String nomfichier;

        public FormCD()
        {
            InitializeComponent();
        }

        private void FormCD_Load(object sender, EventArgs e)
        {
            tbrep.Text = @"C:\GMines\Polyaxial";
            tbnomf.Text = "Essai";
            tbnumessai.Text = "10";
            tbcote1.Text = "30.0";
            tbcote2.Text = "30.0";
            tbcote3.Text = "30.0";
            tbsigbp.Text = "100";
            tbsigmp.Text = "300";
            tbsighp.Text = "700";
        }

        private void btprec_Click(object sender, EventArgs e)
        {
            FormMain FormM = new FormMain();
            FormM.Show();
            this.Hide();
        }

        private void btparc_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void ChooseFolder()
        {
            if(fbdrep.ShowDialog()== DialogResult.OK)
            {
                tbrep.Text = fbdrep.SelectedPath;
            }
        }

        private void tbnumessai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && tbnumessai.Text.IndexOf('.') != 0)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbcote1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
