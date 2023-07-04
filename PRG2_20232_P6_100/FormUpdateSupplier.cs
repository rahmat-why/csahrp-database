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
    public partial class FormUpdateSupplier : Form
    {
        static string connectionString = "integrated security=true; data source=.; initial catalog=P5_100";
        SqlConnection connection = new SqlConnection(connectionString);

        public FormUpdateSupplier()
        {
            InitializeComponent();
        }

        private void FormUpdateSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ms_supplier' table. You can move, or remove it, as needed.
            this.ms_supplierTableAdapter.Fill(this.dataSet1.ms_supplier);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("sp_UpdateSupplier", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_supplier", txtIdSP.Text);
            update.Parameters.AddWithValue("nama_supplier", txtNamaSP.Text);
            update.Parameters.AddWithValue("telp", txtTelp.Text);
            update.Parameters.AddWithValue("alamat", txtAlamat.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to updated: " + exc.Message.ToString());
            }
        }

        public void clear()
        {
            // mengosongkan isian dalam textbox
            txtIdSP.Text = "";
            txtNamaSP.Text = "";
            txtTelp.Text = "";
            txtAlamat.Text = "";
        }

        private DataTable RunQuery(string query)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=P5_100";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return dataTable;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtIdSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand getSupplier = new SqlCommand("sp_GetSupplier", connection);
            getSupplier.CommandType = CommandType.StoredProcedure;

            getSupplier.Parameters.AddWithValue("id_supplier", txtIdSP.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(getSupplier);
            DataTable result = new DataTable();

            connection.Open();

            adapter.Fill(result);

            connection.Close();

            try
            {
                // Memeriksa apakah data ditemukan atau tidak
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Menampilkan data yang ditemukan ke dalam kontrol pada form kedua (Form2)
                    txtIdSP.Text = result.Rows[0]["id_supplier"].ToString();
                    txtNamaSP.Text = result.Rows[0]["nama_supplier"].ToString();
                    txtTelp.Text = result.Rows[0]["telp"].ToString();
                    txtAlamat.Text = result.Rows[0]["alamat"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
