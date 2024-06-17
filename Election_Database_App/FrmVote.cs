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

namespace Election_Database_App
{
    public partial class FrmVote : Form
    {
        public FrmVote()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\SQLEXPRESS;Initial Catalog=DBELECTIONPROJECT;Integrated Security=True");
        private void BtnVote_Click(object sender, EventArgs e)
        {

            bgl.Open();
            SqlCommand kmt = new SqlCommand("insert into TBLILCE(ILCEAD, APARTI, BPARTI, CPARTI,DPARTI,EPARTI) values (@P1, @P2, @P3, @P4, @P5, @P6)", bgl);
            kmt.Parameters.AddWithValue("@P1", TxtDistrictName.Text);
            kmt.Parameters.AddWithValue("@P2", TxtA.Text);
            kmt.Parameters.AddWithValue("@P3", TxtB.Text);
            kmt.Parameters.AddWithValue("@P4", TxtC.Text);
            kmt.Parameters.AddWithValue("@P5", TxtD.Text);
            kmt.Parameters.AddWithValue("@P6", TxtE.Text);
            kmt.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Successfully");
        }
    }
}
