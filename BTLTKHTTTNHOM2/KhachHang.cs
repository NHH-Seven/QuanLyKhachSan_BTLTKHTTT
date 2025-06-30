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

namespace BTLTKHTTTNHOM2
{
    public partial class KhachHang : Form
    {
        private string ID = "";
        public KhachHang()
        {
            InitializeComponent();
           
        }

        private void tabPageAddKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
              if(textBoxHo.Text != "" && textBoxTen.Text != "" && textBoxSDT.Text != "" && textBoxDiaChi.Text != "")
            {
                string ho = textBoxHo.Text;
                string ten = textBoxTen.Text;
                Int64 sdt = Int64.Parse(textBoxSDT.Text);
                string diachi = textBoxDiaChi.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Client_Table (Client_Firstname,Client_Lastname,Client_Phone,Client_Address) values ('"+ho+"' , '"+ten+"' , "+sdt+" , '"+diachi+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Da luu thông tin ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearchSDT_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchSDT.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Client_Table where Client_Phone LIKE '" + textBoxSearchSDT.Text +"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewClient.DataSource = ds.Tables[0];




            }             
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Client_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewClient.DataSource = ds.Tables[0];

            }
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxHo1.Text = row.Cells[1].Value.ToString();
                textBoxTen1.Text = row.Cells[2].Value.ToString();
                textBoxSDT1.Text = row.Cells[3].Value.ToString();
                textBoxDiaChi1.Text = row.Cells[4].Value.ToString();

            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxHo1.Text != "" && textBoxTen1.Text != "" && textBoxSDT1.Text != "" && textBoxDiaChi1.Text != "")
                {
                    string ho = textBoxHo1.Text;
                    string ten = textBoxTen1.Text;
                    Int64 sdt = Int64.Parse(textBoxSDT1.Text);
                    string diachi = textBoxDiaChi1.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "Update Client_Table set Client_Firstname = '" + ho + "', Client_Lastname = '" + ten + "' , Client_Phone ='"+ sdt +"' , Client_Address = '"+ diachi+ "' where Client_ID = " + ID + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Da luu tai khoan", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxHo1.Text != "" && textBoxTen1.Text != "" && textBoxSDT1.Text != "" && textBoxDiaChi1.Text != "")
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "delete from Client_Table where Client_ID =" + ID + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Da Xoa Thong tin", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
