using MiniProjetV1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.ServiceModel.Security;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using ZXing;
using Bunifu.Framework.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniProjetV1
{
    
    public partial class Form1 : Form
    {
        static readonly SqlConnection Con = new SqlConnection("Data Source = UBUNTU\\AZIZ; Initial Catalog = MiniProejtV1; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
            ////if(Form1.Username == 0)
            // lblUsername2.Visible = true;
            if (Form1.Username == 0)
                BtnLogout.Visible = false;
            addUserControl(new Login());
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        public void addUserControl(UserControl userControl)
        {
            UserInfos();
            userControl.Dock = DockStyle.Fill;
            Container.Controls.Clear();
            Container.Controls.Add(userControl);
            userControl.BringToFront();
            
        }
        public static void UserInfos()
        {
           // Form1.guna2Button1.Visible = (Form1.Username == 0)?false: true;
            try
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nom +'  '+Prenom as 'FullName',Solde from USERS U,SOLDES S WHERE Id ='" + Form1.Username + "' AND Id = IdUser ", Con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Read the data from the reader
                    while (reader.Read())
                    {
                       Form1.FullName= reader.GetString(reader.GetOrdinal("FullName"));
                       Form1.UserSolde= reader.GetInt32(reader.GetOrdinal("Solde"));

                    }
                }
                Con.Close();

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            if (Username != 0) {

                BtnLogout.Visible = true;
                addUserControl(new Acceuil());
                UserInfos();
                lblUsername.Text = Form1.FullName;
                lblSolde.Text = Form1.UserSolde+"";
                /*try
                {

                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nom +'  '+Prenom as 'FullName',Solde from USERS U,SOLDES S WHERE Id ='" + Form1.Username + "' AND Id = IdUser ", Con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Read the data from the reader
                    while (reader.Read())
                    {
                        lblUsername.Text = reader.GetString(reader.GetOrdinal("FullName"));
                        lblSolde.Text = reader.GetInt32(reader.GetOrdinal("Solde"))+"";
                    }
                }
                Con.Close();

                }
                catch (Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);
                }*/
               
            }  
            else 
                
                
                
                addUserControl(new Login());



            btnAcceuil.ForeColor = Color.Blue;
            btnDemandes.ForeColor = btnOffres.ForeColor = Color.Black;

            btnAcceuil.BackColor = Color.AliceBlue;
            btnOffres.BackColor = btnDemandes.BackColor = Color.White;
            // Login uc1 = new Login();
            // addUserControl(uc1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOffres_Click(object sender, EventArgs e)
        {
            if (! (Form1.Username == 0))
            {
                BtnLogout.Visible = true;
                UserInfos();
                lblUsername.Text = Form1.FullName;
                lblSolde.Text = Form1.UserSolde + "";
                btnOffres.ForeColor = Color.Blue;
                btnAcceuil.ForeColor = btnDemandes.ForeColor = Color.Black;

                btnOffres.BackColor = Color.AliceBlue;
                btnAcceuil.BackColor = btnDemandes.BackColor = Color.White;
                Offres uc2 = new Offres();
                addUserControl(uc2);
            }
            else
                addUserControl(new Login());
        }

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            if (!(Form1.Username == 0))
            {
                BtnLogout.Visible = true;
                addUserControl(new MonCompte());
                UserInfos();
                lblUsername.Text = Form1.FullName;
                lblSolde.Text = Form1.UserSolde + "";
                btnDemandes.ForeColor = Color.Blue;
                btnAcceuil.ForeColor = btnOffres.ForeColor = Color.Black;
                btnDemandes.BackColor = Color.AliceBlue;
                btnOffres.BackColor = btnAcceuil.BackColor = Color.White;
            }
            else addUserControl(new Login());
        }
        bool pbTopUpClickeed = false;
        private void pbTopUp_Click(object sender, EventArgs e)
        {
            if (!pbTopUpClickeed && Form1.Username != 0) { 
                pnlTopUp.Visible = true;
                pbTopUpClickeed = true;
            }
            else
            {
                pnlTopUp.Visible = false;
                pbTopUpClickeed = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            pnlTopUp.Visible=false;
        }
        public void TopUp(int Value)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("TopUp", Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idUser", Form1.Username);
                cmd.Parameters.AddWithValue("@Value",Value );
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Montant ajoute avec success !!");
                UserInfos();
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show(ex.Message + "");
            }
        }
        public void BtnTopUP_Click(object sender, EventArgs e)
        {
            TopUp((int)NbrTopUp.Value);
            Form1.UserInfos();
            lblUsername.Text = Form1.FullName;
            lblSolde.Text = Form1.UserSolde + "";
            /* try
             {
                 Con.Open();
                 SqlCommand cmd = new SqlCommand("TopUp", Con)
                 {
                     CommandType = CommandType.StoredProcedure
                 };
                 cmd.Parameters.AddWithValue("@idUser", Form1.Username);
                 cmd.Parameters.AddWithValue("@Value", NbrTopUp.Value);
                 cmd.ExecuteNonQuery();
                 Con.Close();
                 MessageBox.Show("Montant ajoute avec success !!");
                 UserInfos();
             }
             catch (Exception ex)
             {
                 Con.Close();
                 MessageBox.Show(ex.Message + "");
             }*/
        }

        private void NbrTopUp_Leave(object sender, EventArgs e)
        {
            pnlTopUp.Visible=false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        { Form1.UserSolde = Form1.Username = 0;
            lblSolde.Text = "00.00";
            lblUsername.Text = "";
            BtnLogout.Visible = false;
            addUserControl(new Login());

        }

    }
    
}
