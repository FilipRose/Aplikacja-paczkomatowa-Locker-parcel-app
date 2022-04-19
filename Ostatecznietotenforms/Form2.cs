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
    public partial class fmRej : Form

    {
        
        string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER";
        public fmRej()
        {
            InitializeComponent();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtHaslo.Text == "")
                MessageBox.Show("Wszystkie Pola nie zostały wypełnione!");
            else if (txtHaslo.Text != txtPotwHaslo.Text)
                MessageBox.Show("Hasło nie pasuje!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCad = new SqlCommand("KlientADD", sqlCon);
                    sqlCad.CommandType = CommandType.StoredProcedure;
                    sqlCad.Parameters.AddWithValue("@Imie", txtImie.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Nazwisko", txtNazwisko.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Nr_tel", txtNr_tel.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Mail", txtMail.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Nick", txtLogin.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Haslo", HashCode.HashData(txtHaslo.Text.Trim()));
                    sqlCad.ExecuteNonQuery();
                    MessageBox.Show("Rejestracja przebiegła pomyślnie.");
                    Clear();
                }
            }
            void Clear()
            {
                txtImie.Text = txtNazwisko.Text = txtNr_tel.Text = txtMail.Text = txtLogin.Text = txtHaslo.Text = txtPotwHaslo.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fmMain n = new fmMain();
            n.Show();
            this.Hide();
        }
    }
}
