using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20232_P6_100
{
    public partial class FormDeleteSupplier : Form
    {
        public FormDeleteSupplier()
        {
            InitializeComponent();
        }

        private void FormDeleteSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ms_supplier' table. You can move, or remove it, as needed.
            this.ms_supplierTableAdapter.Fill(this.dataSet1.ms_supplier);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=P5_100";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_DeleteSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_supplier", txtIdSP.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to deleted: " + exc.Message.ToString());
            }
        }
    }
}
