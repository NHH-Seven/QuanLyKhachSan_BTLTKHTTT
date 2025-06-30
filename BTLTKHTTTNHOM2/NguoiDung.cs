using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace BTLTKHTTTNHOM2
{
    public partial class NguoiDung : Form
    {

        private string ID = "";
        public NguoiDung()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        private void clear1()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            ID = "";

        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void tabPageSeachUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }
            

        private void tabPageUdateandDelete_Leave(object sender, EventArgs e)
        {
            clear1();
        }
     

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                string name = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into User_Table (User_Name,User_Password) values ('"+name+"' , '"+password+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Da luu tai khoan", "success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clear();
            }
               
            else
            {
                MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabPageSeachUser_Enter(object sender, EventArgs e)
        {
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxUsername1.Text != "" && textBoxPassword1.Text != "")
                {
                    string name = textBoxUsername1.Text;
                    string password = textBoxPassword1.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "Update User_Table set User_Name = '" + name + "', User_Password = '" + password + "' where User_ID = "+ID+"";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    MessageBox.Show("Da luu tai khoan", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear1();
                }

                else
                {
                    MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Vui long chon hang tu bang ", "Lua chon hang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxUsername1.Text != "" && textBoxPassword1.Text != "")
                {
                    
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "delete from User_Table where User_ID =" + ID + "";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    MessageBox.Show("Da Xoa Tai Khoan", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear1();
                }

                else
                {
                    MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Vui long chon hang tu bang ", "Lua chon hang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchUsername.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from User_Table where User_Name LIKE '" + textBoxSearchUsername.Text +"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewUser.DataSource = ds.Tables[0];




            }             
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from User_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewUser.DataSource = ds.Tables[0];

            }
        }
        
        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {

               DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
            }

            

            
        }

        private void tabPageSeachUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System;integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from User_Table";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewUser.DataSource = ds.Tables[0];
        }

        private void tabPageUdateandDelete_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System;integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from User_Table";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewUser.DataSource = ds.Tables[0];
        }
    }
}
