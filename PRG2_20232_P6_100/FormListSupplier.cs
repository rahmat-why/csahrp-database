using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20232_P6_100
{
    public partial class FormListSupplier : Form
    {
        public FormListSupplier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataset();
        }

        private void RefreshDataset()
        {
            // TODO: This line of code loads data into the 'dataSet1.ms_supplier' table. You can move, or remove it, as needed.
            this.ms_supplierTableAdapter.Fill(this.dataSet1.ms_supplier);
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputSupplier formInput = new FormInputSupplier();
            formInput.MdiParent = this;
            formInput.TopLevel = false;
            formInput.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }
    }
}
