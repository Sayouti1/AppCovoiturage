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

namespace MiniProjetV1.Forms
{
    public partial class MonCompte : UserControl
    {
        static readonly SqlConnection Con = new SqlConnection("Data Source=UBUNTU\\AZIZ;Initial Catalog=MiniProejtV1;Integrated Security=True");
        public MonCompte()
        {
            InitializeComponent();
        }

        private void Demandes_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");

            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select IdOffre ,Depart,Arrive ,DateDepart ,NbrPlaceMax-NbrPlaceOccupe as 'Places' from OFFRES where UserID = "+Form1.Username+" ORDER BY DatePublication DESC", Con);
            SqlDataAdapter da2 = new SqlDataAdapter("select RL.offreID, O.Depart,O.Arrive,O.DateDepart,RL.PlacesReserves,U.Nom+' '+U.Prenom as 'FullName' from ReservationLog RL,OFFRES O,USERS U where RL.PassagerID="+Form1.Username+" and U.Id = RL.AuthorId and RL.offreID = O.IdOffre", Con);
            DataTable dtbl = new DataTable();
            DataTable dtbl2 = new DataTable();
            da.Fill(dtbl);
            da2.Fill(dtbl2);
            dgvMesOffres.DataSource = dtbl;
            dgvMesReservations.DataSource = dtbl2;
            Con.Close();


        }

        private int clickedIdOffre;

        private void dgvMesOffres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedIdOffre = (e.RowIndex >= 0) ? int.Parse(dgvMesOffres.Rows[e.RowIndex].Cells[0].Value.ToString()) : 0;
            if(! (clickedIdOffre ==  0)) {
                
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select RL.offreID,U.Nom,U.Prenom,Rl.PlacesReserves,RL.PrixTotal from ReservationLog RL, USERS U where PassagerID = U.Id and RL.offreID = "+clickedIdOffre+"", Con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dgvMesPassagers.DataSource = dtbl;
                Con.Close();
            }
        }

        private void btnDeleteOffre_Click(object sender, EventArgs e)
        {
            if (!(clickedIdOffre == 0))
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from ReservationLog where OffreID = " + clickedIdOffre + "", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(dt);
                // da.Fill(ds);
                Con.Close();
                if (dt.Rows[0][0].ToString() == "0")
                {
                    DialogResult dr = MessageBox.Show(" Suprimer L'Offre Numero " + clickedIdOffre + " !!", " Test", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            {
                                Con.Open();
                                SqlCommand cmmd = new SqlCommand("Delete from OFFRES where IdOffre = " + clickedIdOffre + "", Con);
                                cmmd.CommandType = CommandType.Text;
                                cmmd.ExecuteNonQuery();
                                Con.Close();
                                MessageBox.Show("Supprimer Avec Success");
                                break;
                            }
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Impossible d'annuler l'offre ;Des Passagers ont deja reserves cet offre !!");
                }

            }
            else
                MessageBox.Show("Selectioner une offre a supprimer");

        }
    }
}
