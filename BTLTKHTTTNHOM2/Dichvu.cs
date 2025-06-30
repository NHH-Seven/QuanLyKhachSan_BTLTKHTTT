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
    public partial class Dichvu : Form
    {
        private string ID = "";
        public Dichvu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTenDV.Text != "" && comboBoxLoaiDV.Text != "" && comboBoxPrice.Text != "" )
            {
                string loai = comboBoxLoaiDV.Text;
                string ten = textBoxTenDV.Text;
                string gia = comboBoxPrice.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into DichVuu_Table (DV_Name,DV_Loai,DV_Gia) values ('" + ten + "' , '" + loai + "' ,  '" + gia + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Da luu thông tin ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearchTenDv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchTenDv.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from DichVuu_Table where DV_Name LIKE '" + textBoxSearchTenDv.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewDV.DataSource = ds.Tables[0];




            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from DichVuu_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewDV.DataSource = ds.Tables[0];

            }
        }

        private void dataGridViewDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridViewDV.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxTenDv1.Text = row.Cells[1].Value.ToString();
                comboBoxLoaiDV1.Text = row.Cells[2].Value.ToString();
                comboBoxPrice1.Text = row.Cells[3].Value.ToString();


            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxTenDv1.Text != "" && comboBoxLoaiDV1.Text != "" && comboBoxPrice1.Text != "" )
                {
                    string loai = comboBoxLoaiDV.Text;
                    string ten = textBoxTenDV.Text;
                    string gia = comboBoxPrice.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "Update DichVuu_Table set DV_Name = '" + ten + "', DV_Loai = '" + loai + "' , DV_Gia ='" + gia + "'  where DV_ID = " + ID + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Da luu Thong tin", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (textBoxTenDv1.Text != "" && comboBoxLoaiDV1.Text != "" && comboBoxPrice1.Text != "")
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "delete from DichVuu_Table where DV_ID =" + ID + "";
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
