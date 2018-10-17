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


namespace QLSinhVienXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_WriteDatasetToXML_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select *from KHOA", @"Data Source=DESKTOP-KS2AHB8\SQLEXPRESS;Initial Catalog=QLSINHVIEN4;Integrated Security=True");
                DataSet ds = new DataSet();
                da.Fill(ds, "KHOA");
                ds.WriteXml("../../Khoa.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Ghi thành công!!!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ReadXMLToDataset_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("../../Khoa.xml", XmlReadMode.Auto);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_WriteXMLWithDff_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(" select * from KHOA", @"Data Source=DESKTOP-KS2AHB8\SQLEXPRESS;Initial Catalog=QLSINHVIEN4;Integrated Security=True");
                DataSet ds = new DataSet();
                da.Fill(ds, "KHOA");

                DataRow r = ds.Tables["KHOA"].Rows[0];

                r["NamThanhLap"] = "2000";

                ds.WriteXml("../../KhoaDiff.xml", XmlWriteMode.DiffGram);
                MessageBox.Show("Ghi thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
