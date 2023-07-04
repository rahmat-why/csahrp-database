namespace PRG2_20232_P6_100
{
    partial class FormDeleteSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIdSP = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSet1 = new PRG2_20232_P6_100.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ms_supplierTableAdapter = new PRG2_20232_P6_100.DataSet1TableAdapters.ms_supplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdSP
            // 
            this.txtIdSP.DataSource = this.mssupplierBindingSource;
            this.txtIdSP.DisplayMember = "id_supplier";
            this.txtIdSP.FormattingEnabled = true;
            this.txtIdSP.Location = new System.Drawing.Point(311, 113);
            this.txtIdSP.Name = "txtIdSP";
            this.txtIdSP.Size = new System.Drawing.Size(100, 21);
            this.txtIdSP.TabIndex = 64;
            this.txtIdSP.ValueMember = "nama_supplier";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(455, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "ID Supplier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(242, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 22);
            this.label10.TabIndex = 60;
            this.label10.Text = "Form Delete Supplier";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // mssupplierBindingSource
            // 
            this.mssupplierBindingSource.DataMember = "ms_supplier";
            this.mssupplierBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // ms_supplierTableAdapter
            // 
            this.ms_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // FormDeleteSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 254);
            this.Controls.Add(this.txtIdSP);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "FormDeleteSupplier";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDeleteSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtIdSP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mssupplierBindingSource;
        private DataSet1TableAdapters.ms_supplierTableAdapter ms_supplierTableAdapter;
    }
}