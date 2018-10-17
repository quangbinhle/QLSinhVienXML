namespace QLSinhVienXML
{
    partial class Form1
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
            this.btn_WriteDatasetToXML = new System.Windows.Forms.Button();
            this.btn_ReadXMLToDataset = new System.Windows.Forms.Button();
            this.btn_WriteXMLWithDff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_WriteDatasetToXML
            // 
            this.btn_WriteDatasetToXML.Location = new System.Drawing.Point(37, 31);
            this.btn_WriteDatasetToXML.Name = "btn_WriteDatasetToXML";
            this.btn_WriteDatasetToXML.Size = new System.Drawing.Size(120, 30);
            this.btn_WriteDatasetToXML.TabIndex = 0;
            this.btn_WriteDatasetToXML.Text = "WriteDatasetToXML";
            this.btn_WriteDatasetToXML.UseVisualStyleBackColor = true;
            this.btn_WriteDatasetToXML.Click += new System.EventHandler(this.btn_WriteDatasetToXML_Click);
            // 
            // btn_ReadXMLToDataset
            // 
            this.btn_ReadXMLToDataset.Location = new System.Drawing.Point(216, 31);
            this.btn_ReadXMLToDataset.Name = "btn_ReadXMLToDataset";
            this.btn_ReadXMLToDataset.Size = new System.Drawing.Size(120, 30);
            this.btn_ReadXMLToDataset.TabIndex = 1;
            this.btn_ReadXMLToDataset.Text = "ReadXMLToDataset";
            this.btn_ReadXMLToDataset.UseVisualStyleBackColor = true;
            this.btn_ReadXMLToDataset.Click += new System.EventHandler(this.btn_ReadXMLToDataset_Click);
            // 
            // btn_WriteXMLWithDff
            // 
            this.btn_WriteXMLWithDff.Location = new System.Drawing.Point(387, 31);
            this.btn_WriteXMLWithDff.Name = "btn_WriteXMLWithDff";
            this.btn_WriteXMLWithDff.Size = new System.Drawing.Size(120, 30);
            this.btn_WriteXMLWithDff.TabIndex = 2;
            this.btn_WriteXMLWithDff.Text = "WriteXMLWithDff";
            this.btn_WriteXMLWithDff.UseVisualStyleBackColor = true;
            this.btn_WriteXMLWithDff.Click += new System.EventHandler(this.btn_WriteXMLWithDff_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_WriteXMLWithDff);
            this.Controls.Add(this.btn_ReadXMLToDataset);
            this.Controls.Add(this.btn_WriteDatasetToXML);
            this.Name = "Form1";
            this.Text = "WriteReadXMLToDataset";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_WriteDatasetToXML;
        private System.Windows.Forms.Button btn_ReadXMLToDataset;
        private System.Windows.Forms.Button btn_WriteXMLWithDff;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

