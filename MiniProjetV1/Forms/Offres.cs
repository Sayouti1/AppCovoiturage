using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace MiniProjetV1.Forms
{
    public partial class Offres : UserControl
    {        
        static readonly SqlConnection Con = new SqlConnection("Data Source=UBUNTU\\AZIZ;Initial Catalog=MiniProejtV1;Integrated Security=True");
        public Offres()
        {
            InitializeComponent();
            publierOffrePanel.Visible = false;
            pnlPayement.Visible = false;


        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select IdOffre,DatePublication,Depart,Arrive,DateDepart,Heure,Prix ,NbrPlaceMax-NbrPlaceOccupe as 'Places Disponibles' from OFFRES ORDER BY DatePublication DESC", Con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvOffres.DataSource = dtbl;
                Con.Close();
        }

        private void BtnPublierOffre_Click(object sender, EventArgs e)
        {
            publierOffrePanel.Visible = true;
            publierOffrePanel.BringToFront();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            publierOffrePanel.Visible=false;
        }

        private void BtnPublier_Click(object sender, EventArgs e)
        {
            if (txtDepart.Text == "" || txtArrive.Text == "" || txtHeure.Text == "")
                MessageBox.Show("Veuillez remplire les champs !!");
            else if (dpDateDepart.Value <= DateTime.Today) {
                MessageBox.Show("Erreur a la DATE de Depart");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("addOffre", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@UserID",Form1.Username);
                    cmd.Parameters.AddWithValue("@Depart", txtDepart.Text.Trim());
                    cmd.Parameters.AddWithValue("@Arrive", txtArrive.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateDepart",dpDateDepart.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Heure",txtHeure.Text);
                    cmd.Parameters.AddWithValue("@Prix",int.Parse(nbrPrix.Value.ToString()));
                    cmd.Parameters.AddWithValue("@NbrPlaceMax", int.Parse(nbrPlaceDisponible.Value.ToString()));

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Offre Added Successfuly!!");
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show(ex.Message + dpDateDepart.Value.ToString("yyyy-MM-dd") + "");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select IdOffre,DatePublication,Depart,Arrive,DateDepart,Heure,Prix ,NbrPlaceMax-NbrPlaceOccupe as 'Places Disponibles' from OFFRES WHERE Depart like '%" + txtDe.Text + "%' and Arrive like '%" + txtA.Text + "%' and DateDepart = '" + dtpLe.Value.ToString("yyyy-MM-dd") + "' ", Con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvOffres.DataSource = dtbl;
                Con.Close();

                MessageBox.Show(txtDe.Text + " jusqua " + txtA.Text + " le " + dtpLe.Value.ToString("yyyy-MM-dd")+" Trouvee");
            }catch(Exception ex) { 
                Con.Close();
                MessageBox.Show("ERROR !!! \n" + ex.Message);
                
            }
         }
        private int clickedIdOffre;        
        private void DgvOffres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedIdOffre = (e.RowIndex >= 0) ? int.Parse(dgvOffres.Rows[e.RowIndex].Cells[0].Value.ToString()): 0;
        }
        private int AuthorId;
        private void BtnReserver_Click(object sender, EventArgs e)
        {
            if (clickedIdOffre == 0)
                MessageBox.Show("Veuillez choisir une offre .!!");
            else
            {
                
                pnlPayement.Visible = true; 
                pnlPayement.BringToFront(); 
                txtOffreIdRecap.Text = clickedIdOffre+"";
                
                try
                {
                    Con.Open(); 
                    // Create a command to select the data from the database
                        string sql = "select U.Nom+' '+U.Prenom as 'Nom',Depart,Arrive,DateDepart,NbrPlaceMax-NbrPlaceOccupe as 'PlaceDisponible',Prix,O.UserId from OFFRES O,USERS U where IdOffre = "+clickedIdOffre+" and O.UserID = U.Id";
                        using (SqlCommand command = new SqlCommand(sql, Con))
                        {
                            //command.Parameters.AddWithValue("@id", yourId);

                            // Execute the command and get a data reader
                            using (SqlDataReader reader = command.ExecuteReader())
                            { 
                                   // Read the data from the reader
                                  while (reader.Read())
                                  {
                                        txtPlaceDispoRecap.Text = reader.GetInt32(reader.GetOrdinal("PlaceDisponible"))+"";
                                        txtDateDepartRecap.Text = reader.GetDateTime(reader.GetOrdinal("DateDepart")).ToString("d");
                                        txtDestinationRecap.Text = reader.GetString(reader.GetOrdinal("Arrive"));
                                        txtDepartRecap.Text =  reader.GetString(reader.GetOrdinal("Depart"));
                                        txtCreatorRecap.Text = reader.GetString(reader.GetOrdinal("Nom"));
                                        txtPrixPlaceRecap.Text = reader.GetInt32(reader.GetOrdinal("Prix"))+"";
                                        AuthorId = reader.GetInt32(reader.GetOrdinal("UserId"));
                                        NbrPlaceReserverRecap.Maximum = int.Parse(txtPlaceDispoRecap.Text);
                                  }
                            }
                        }
                    Con.Close();  
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Con.Close(); 
                }
                txtTotalPaye.Text = NbrPlaceReserverRecap.Value * int.Parse(txtPrixPlaceRecap.Text) + "";
                BtnPaye.Enabled = int.Parse(txtPlaceDispoRecap.Text) > 0 ? true : false;
                BtnPaye.Enabled = NbrPlaceReserverRecap.Value > 0 ? true : false;
            }
        }

        private void BtnCloseRecap_Click(object sender, EventArgs e)
        {
            pnlPayement.SendToBack();
            pnlPayement.Visible = false;
            pbTicket.Image = null;
            txtOffreIdRecap.Text=txtCreatorRecap.Text=txtDateDepartRecap.Text=txtDepartRecap.Text=txtDestinationRecap.Text=txtPlaceDispoRecap.Text="";
        }

        private void BtnPaye_Click(object sender, EventArgs e)
        {

            if (int.Parse(txtTotalPaye.Text) > Form1.UserSolde)
                MessageBox.Show("Solde Insuffisant ..Veuillez charger votre solde");
            /* Con.Open();
             SqlCommand cmd = new SqlCommand("SELECT Nom +'  '+Prenom from USERS WHERE Id ='" + Form1.Username+"' ", Con);
             string result = (String)cmd.ExecuteScalar();
             Con.Close();*/
            else
            {
                MessageBox.Show("Reservation avec success ...!");

                BarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
                var x = writer.Write("Offre Numero : " + txtOffreIdRecap.Text + "\n De \t : " + txtDepartRecap.Text + "\n A \t : " + txtDestinationRecap.Text + "\n Le \t : " + txtDateDepartRecap.Text + "\n Nombre de place \t : " + NbrPlaceReserverRecap.Value + "\n Total \t : " + txtTotalPaye.Text + " DH TTC ");
                var barcodeBitmap = new Bitmap(x);
                pbTicket.Image = barcodeBitmap;
                Form1 f = new Form1();
                f.TopUp(int.Parse(txtTotalPaye.Text)*(-1));

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Reserver", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@OffreID", int.Parse(txtOffreIdRecap.Text));
                    cmd.Parameters.AddWithValue("@AuthorId", AuthorId);                    
                    cmd.Parameters.AddWithValue("@PassagerID", Form1.Username);
                    cmd.Parameters.AddWithValue("@PlacesReserves", NbrPlaceReserverRecap.Value);
                    cmd.Parameters.AddWithValue("@PrixTotal", int.Parse(txtTotalPaye.Text));

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Transferer avec succes !!");
                    Form1.UserInfos();
                    BtnReserver_Click(new object(),new EventArgs());
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show(ex.Message + "");
                }

            }
        }

        private void NbrPlaceReserverRecap_ValueChanged(object sender, EventArgs e)
        {
            txtTotalPaye.Text = NbrPlaceReserverRecap.Value * int.Parse(txtPrixPlaceRecap.Text) +"";
            BtnPaye.Enabled = NbrPlaceReserverRecap.Value > 0 ? true : false;
        }
    }
}
