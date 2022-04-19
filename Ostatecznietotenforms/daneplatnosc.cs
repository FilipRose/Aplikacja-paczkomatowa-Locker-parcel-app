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
    public partial class daneplatnosc : Form
    {
        string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER";
        public daneplatnosc()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDane.Text == "" || txtKarta.Text == "")
                MessageBox.Show("Wszystkie Pola nie zostały wypełnione!");
         
           else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCad = new SqlCommand("PrzelewADD", sqlCon);
                    sqlCad.CommandType = CommandType.StoredProcedure;
                    sqlCad.Parameters.AddWithValue("@Dane", txtDane.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Karta", HashCode.HashData(txtKarta.Text.Trim()));
                    sqlCad.Parameters.AddWithValue("@Adres", txtAdres.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@CVV", HashCode.HashData(txtCVV.Text.Trim()));
                    sqlCad.ExecuteNonQuery();
                    MessageBox.Show("Przelew zlecone, nadaj paczkę w najbliższym punkcie w czasie 24h.");
                    Clear();
                }
            }
            void Clear()
            {
                txtDane.Text = txtKarta.Text = txtAdres.Text = txtCVV.Text =  "";
            }
            this.Hide();
        }


    }
}
