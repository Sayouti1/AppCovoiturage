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
    public partial class Acceuil : UserControl
    {
        private static readonly SqlConnection Con = new SqlConnection("Data Source=UBUNTU\\AZIZ;Initial Catalog=MiniProejtV1;Integrated Security=True");

        public Acceuil()
        {
            InitializeComponent();
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter(" Select top 4 Depart,Arrive,DateDepart,Heure,DatePublication from OFFRES ORDER BY DatePublication DESC ", Con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dgvLastOffre.DataSource = dtbl;
            Con.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //addUserControl(new Offres());
        }
    }
}
