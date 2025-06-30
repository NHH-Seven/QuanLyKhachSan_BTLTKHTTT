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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLTKHTTTNHOM2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
       
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "show password");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Hide password");
        }

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from User_Table where User_Name = '" + textBox1.Text + "' and User_Password ='" + textBox2.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Username = textBox1.Text;
                textBox1.Clear();
                textBox2.Clear();
                dsa.Show();



            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            textBox2.UseSystemPasswordChar = false;
            pictureBox3.Show();

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            textBox2.UseSystemPasswordChar = true;
            pictureBox2.Show();
        }
    }
}
