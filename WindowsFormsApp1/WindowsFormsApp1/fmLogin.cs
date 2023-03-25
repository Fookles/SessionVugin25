using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            fmGrid fmgrid1 = new fmGrid();
            fmgrid1.Show();
            this.Hide();
        }
    }
}
