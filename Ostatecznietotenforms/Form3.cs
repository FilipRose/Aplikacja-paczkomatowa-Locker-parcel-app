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
    public partial class fmProfil : Form
    {

        public fmProfil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmMain h = new fmMain();
            h.Show();
            this.Hide();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dodajadres.Visible = true;

        }

        private void fmProfil_Load(object sender, EventArgs e)
        {
            dodajadres.Visible = false;
            editProf.Visible = false;
            Nadpacz.Visible = false;
            status.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (txtMiasto.Text == "" || txtUlica.Text == "" || txtNrdomu.Text == "" || txtKod.Text == "")
                    MessageBox.Show("Wszystkie Pola nie zostały wypełnione!");
                else {
                    sqlCon.Open();
                    SqlCommand sqlCad = new SqlCommand("AdresAD", sqlCon);
                    sqlCad.CommandType = CommandType.StoredProcedure;
                    sqlCad.Parameters.AddWithValue("@Miasto", txtMiasto.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Ulica", txtUlica.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Nr_domu", txtNrdomu.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@KodPocztowy", txtKod.Text.Trim());
                    sqlCad.ExecuteNonQuery();
                    MessageBox.Show("Dodano Adres.");
                    Clear();
                    dodajadres.Hide();

                }
            }
            void Clear()
            {
                txtMiasto.Text = txtUlica.Text = txtNrdomu.Text = txtKod.Text = "";
            }
        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            generator g = new generator();
            g.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editProf.Visible = true;
        }

        private void btnNadaj_Click(object sender, EventArgs e)
        {
            Nadpacz.Visible = true;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            status.Visible = true;
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            //HashCode hs = new HashCode();
            Haslo obj = new Haslo();
          
            obj.sqlCon.ConnectionString = obj.locate;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT (*) FROM Klient where Haslo = '" +txtOldHaslo.Text.Trim() + "' and Mail ='" + txtOldMail.Text + " ' ", obj.sqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            obj.sqlCon.Open();


            if (dt.Rows[0][0].ToString() == "1")
            {

                if (txtNewHaslo.Text.Trim() == HashCode.HashData(txtPotwHaslo.Text.Trim()))
                {
                    SqlCommand cmd = new SqlCommand("Update Klient set Haslo  = '" + HashCode.HashData(txtPotwHaslo.Text.Trim()) + "' where Haslo = '" + txtOldHaslo.Text.Trim() + "'", obj.sqlCon);

                    cmd.ExecuteNonQuery();


                }
            }
             if (txtNewMail.Text == txtPotwMail.Text)
            {
                SqlCommand cmd = new SqlCommand("Update Klient set Mail  = '" + txtPotwMail.Text + "' where Mail = '" + txtOldMail.Text + "'", obj.sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dane zostały zmienione!");
            }
            else if (txtNewHaslo.Text != HashCode.HashData(txtPotwHaslo.Text))
            { 
                MessageBox.Show("Hasła nie są takie same! Spróbuj ponownie.");
            }
             
    
            else
            {
                MessageBox.Show("Stare dane są nie poprawne, spróbuj ponownie!");
                obj.sqlCon.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Serwis_Zarzadzajacy;Data Source=ROSE-COMPUTER";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (txtMiastoO.Text == "" || txtUlicaO.Text == "" || txtNrdomuO.Text == "" || txtKodpocztowyO.Text == "")
                    MessageBox.Show("Wszystkie Pola nie zostały wypełnione!");
                else
                {
                    sqlCon.Open();
                    SqlCommand sqlCad = new SqlCommand("AdresAD", sqlCon);
                    sqlCad.CommandType = CommandType.StoredProcedure;
                    sqlCad.Parameters.AddWithValue("@Miasto", txtMiastoO.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Ulica", txtUlicaO.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@Nr_domu", txtNrdomuO.Text.Trim());
                    sqlCad.Parameters.AddWithValue("@KodPocztowy", txtKodpocztowyO.Text.Trim());
                    sqlCad.ExecuteNonQuery();
                    MessageBox.Show("Dodano Adres Odbiorcy.");
                    Clear();
                    dodajadres.Hide();
                    daneplatnosc d = new daneplatnosc();
                    d.Show();
                }
            }
            void Clear()
            {
                txtMiastoO.Text = txtUlicaO.Text = txtNrdomuO.Text = txtKodpocztowyO.Text = "";
            }
        }

        private void btn_Sprawdz_Click(object sender, EventArgs e)
        {

        }
    }
}