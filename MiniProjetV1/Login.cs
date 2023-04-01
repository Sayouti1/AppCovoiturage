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
using MiniProjetV1.Forms;

namespace MiniProjetV1
{
   
    public partial class Login : UserControl
    { 
        static readonly SqlConnection con = new SqlConnection("Data Source=UBUNTU\\AZIZ;Initial Catalog=MiniProejtV1;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
            signUpPanel.Visible= false;
            loginPanel.Visible= false;
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            signUpPanel.Visible = true;
            loginPanel.Visible = false;
            signUpPanel.Width = 687;
            loginPanel.Width = 10;
            signUpPanel.BringToFront();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            signUpPanel.Visible = false;
            loginPanel.Visible = true;
            loginPanel.Width = 687;
            signUpPanel.Width = 10;
            loginPanel.BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {   if (txtNom.Text == "" || txtPrenom.Text == "" || txtTelephone.Text == "" || txtEmail.Text == "" || txtMotDePasse.Text == "" || (btnMr.Checked == false && btnMlle.Checked == false))
                MessageBox.Show("Veuillez remplire les champs !!");
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("addUser", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", (btnMr.Checked) ? "M" : "F");
                    cmd.Parameters.AddWithValue("@Phone", txtTelephone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pass_word", txtMotDePasse.Text.Trim());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    MessageBox.Show("Inscription reussite !!");
                }catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message + "");
                }
            }
        }
        void Clear()
        {
            txtEmail.Text = txtMotDePasse.Text = txtNom.Text = txtPrenom.Text = txtTelephone.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {   
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from USERS where Email = '"+ loginEmail.Text.Trim()+ "' and Pass_word = '"+loginMotDePasse.Text.Trim()+"'",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);
           // da.Fill(ds);
            con.Close();
            // if (ds.Tables[0].Rows.Count > 0)
            //    MessageBox.Show("Existss");
            // else MessageBox.Show("noooot");
            if (dt.Rows[0][0].ToString() == "1") {
                con.Open();

                SqlCommand cmad = new SqlCommand("SELECT Id from USERS WHERE EMAIL ='" + loginEmail.Text.Trim() + "' ", con);
                Form1.Username = (int)cmad.ExecuteScalar();
                con.Close();
            
                MessageBox.Show(Form1.Username+" a ete connecte avec success !!");
                //Form1.addUserControl(new Acceuil());

            }
            else
            {
                MessageBox.Show("Email ou Mot de passe incorrect !!!");
            }


        }

    }
}
