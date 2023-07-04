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
    public partial class FormInputSupplier : Form
    {
        public FormInputSupplier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            // mengosongkan isian dalam textbox
            txtIdSP.Text = "";
            txtNamaSP.Text = "";
            txtTelp.Text = "";
            txtAlamat.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=P5_100";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_supplier", txtIdSP.Text);
            insert.Parameters.AddWithValue("nama_supplier", txtNamaSP.Text);
            insert.Parameters.AddWithValue("telp", txtTelp.Text);
            insert.Parameters.AddWithValue("alamat", txtAlamat.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }catch(Exception exc)
            {
                MessageBox.Show("Unable to saved: " + exc.Message.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
