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
    public partial class fmMain : Form
    {

        public fmMain()
        {
            InitializeComponent();
        }

        private void btnRejestracja_Click(object sender, EventArgs e)
        {
            fmRej r = new fmRej();
            r.Show();
            this.Hide();
        }

        private void btnZalgouj_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtHaslo.Text == "admin12")
            {
                admin ad = new admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                if (txtLogin.Text != null && txtHaslo.Text != null)
                {


                    try
                    {
                        Login obj = new Login();
                        obj.sqlCon.ConnectionString = obj.locate;

                        obj.sqlCon.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT (*) FROM Klient where Nick = '" + txtLogin.Text + "' and Haslo ='" + HashCode.HashData(txtHaslo.Text.Trim()) + " ' ", obj.sqlCon);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            fmProfil v = new fmProfil();
                            v.Show();
                            this.Hide();

                        }
                        else if (txtLogin.Text == "" || HashCode.HashData(txtHaslo.Text.Trim()) == "")
                            MessageBox.Show("Wszystkie Pola nie zostały wypełnione!");
                        else
                        {
                            MessageBox.Show("Niepoprawne dane logowania!");
                        }

                        obj.sqlCon.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
