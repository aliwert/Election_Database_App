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
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\SQLEXPRESS;Initial Catalog=DBELECTIONPROJECT;Integrated Security=True");
        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            // pull district names to cmbbx
            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select ILCEAD from TBLILCE", bgl);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.Close();

            // get sum result to graphics
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("Select SUM(APARTI), SUM(BPARTI), SUM(CPARTI),  SUM(DPARTI),  SUM(EPARTI) FROM TBLILCE", bgl);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Parties"].Points.AddXY("PARTY A", dr2[0]);
                chart1.Series["Parties"].Points.AddXY("PARTY B", dr2[1]);
                chart1.Series["Parties"].Points.AddXY("PARTY C", dr2[2]);
                chart1.Series["Parties"].Points.AddXY("PARTY D", dr2[3]);
                chart1.Series["Parties"].Points.AddXY("PARTY E", dr2[4]);

            }
            bgl.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("Select * From TBLILCE where ILCEAD=@P1", bgl);
            kmt.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                LblA.Text = dr[2].ToString();
                LblB.Text = dr[3].ToString();
                LblC.Text = dr[4].ToString();
                LblD.Text = dr[5].ToString();
                LblE.Text = dr[6].ToString();
            }
        }
    }
}
