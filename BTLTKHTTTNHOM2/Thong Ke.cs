using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLTKHTTTNHOM2
{
    public partial class Thong_Ke : Form
    {
        public Thong_Ke()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void user()
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =  HUYHIEU; database =Hotel_Management_System ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select SUM(User_ID) from User_Table" ;
            int userCount = (int)cmd.ExecuteScalar();
            labelUserCount.Text = userCount.ToString();

            con.Close();
        }
        public void client()
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =  HUYHIEU; database =Hotel_Management_System ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select SUM(Client_ID) from Client_table";
            int userCount = (int)cmd.ExecuteScalar();
            labelKhachHangCount.Text = userCount.ToString();

            con.Close();
        }
        public void Room()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =  HUYHIEU; database =Hotel_Management_System ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select SUM(Room_ID) from Roomm_Table";
            int userCount = (int)cmd.ExecuteScalar();
            labelPhongCount.Text = userCount.ToString();

            con.Close();

        }

        public void Dichvu()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =  HUYHIEU; database =Hotel_Management_System ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select SUM(DV_ID) from DichVuu_Table";
            int userCount = (int)cmd.ExecuteScalar();
            labelDVcount.Text = userCount.ToString();

            con.Close();
        }

        private void Thong_Ke_Load(object sender, EventArgs e)
        {
            user();
            Dichvu();
            Room();
            client();

        }
    }
    
}
