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
    public partial class fmGrid : Form
    {
        public fmGrid()
        {
            InitializeComponent();
        }

        private void fmGrid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEx2171DataSet1.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter1.Fill(this.demoEx2171DataSet1.transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEx2171DataSet.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.demoEx2171DataSet.transport);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmAdd fmAdd1 = new fmAdd();
            fmAdd1.Show();
            this.Hide();
        }
    }
}
