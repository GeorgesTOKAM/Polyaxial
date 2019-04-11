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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ouverture formulaire fixer condition d'essai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btce_Click(object sender, EventArgs e)
        {
            FormCD frCD = new FormCD();
            frCD.Show();
            this.Hide();
        }
    }
}
