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
using QRCoder;

namespace Ostatecznietotenforms
{
    public partial class generator : Form
    {
        public generator()
        {
            InitializeComponent();
        }
        string sConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER";

      

        private void btnGen_Click(object sender, EventArgs e)
        {
            string idNrzamowienia = txtQRkod.Text;
            var rand = new Random();
            string QRdone = rand.Next(10000000, 40000000).ToString();
            txtQRkod.Text = QRdone;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(QRdone, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            kodpic.Image = code.GetGraphic(5);
            MessageBox.Show("Oto twój numer paczki, służy równierz do śledzenia jej!");
            
            using (SqlConnection sqlCon = new SqlConnection(sConnectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCad = new SqlCommand("KODadd", sqlCon);
                sqlCad.CommandType = CommandType.StoredProcedure;
                sqlCad.Parameters.AddWithValue("@Kod", txtQRkod.Text.Trim());
                sqlCad.ExecuteNonQuery();
               
               
            }


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            fmProfil t = new fmProfil();
            t.Show();
            this.Hide();
        }
    }

}
