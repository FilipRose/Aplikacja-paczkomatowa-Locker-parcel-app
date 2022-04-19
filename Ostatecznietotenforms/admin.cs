using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ostatecznietotenforms
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        
        
        private void btnPokUz_Click(object sender, EventArgs e)
        {
            pokatabele.Visible = true;
            btnGenR.Visible = true;
            btnDel.Visible = true;
            txtId.Visible = true;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
            this.klientTableAdapter.Fill(this.serwis_ZarzadzajacyDataSet3.Klient);
            pokatabele.Visible = false;
            statZam.Visible = false;
            btnGenR.Visible = false;
            btnDel.Visible = false;
            txtId.Visible = false;
        }

        private void btnUStat_Click(object sender, EventArgs e)
        {
            statZam.Visible = true;
        }

        private void btnGenR_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.serwis_ZarzadzajacyDataSet3.Klient.CopyToDataTable(), "Klient");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Raport Wygenerowany", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }

            }



        }

        private void btnWylog_Click(object sender, EventArgs e)
        {
            fmMain fm = new fmMain();
            fm.Show();
            this.Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           
           
            
            SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER");
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("Delete  Klient where idKlient=@idKlient", sqlCon);
            cmd.Parameters.AddWithValue("@idKlient", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("Dane zostały usuniętę!");
        }

        

        private void btn_Ustaw_Click(object sender, EventArgs e)
        {
          //  SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER");
           // sqlCon.Open();
          //  SqlCommand cmd = new SqlCommand("Se")
        }
    }
}
