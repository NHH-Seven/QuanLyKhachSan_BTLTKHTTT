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
    public partial class Phong : Form
    {
        private string ID = "";
        private string Free = "";
        public Phong()
        {
            InitializeComponent();
        }

        private void tabPageTimKiemRoom_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
                Free = "Con Trong";
            if (radioButtonNo.Checked)
                Free = "Đa Đuoc Thue";
            if (comboBoxPrice.Text != "" && comboBoxType.Text != "" && textBoxSoPhong.Text != "" && Free != "")
            {
                string loai = comboBoxType.Text;
                string gia = comboBoxPrice.Text;
                string free = Free;
                Int64 so = Int64.Parse(textBoxSoPhong.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Roomm_Table (Room_Loai,Room_So,Room_Gia,Room_Free) values ('" + loai + "' , " + so + " , '"+ gia +"','"+free+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Da luu Thong Tin", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            else
            {
                MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSuaRoom_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Con Trong";
            if (radioButtonNo1.Checked)
                Free = "Đa Đuoc Thue";

            if (ID != "")
            {
                if (comboBoxPrice1.Text != "" && comboBoxType1.Text != "" && textBoxSoPhong1.Text != "" && Free != "")
                {
                    string loai = comboBoxType1.Text;
                    string gia = comboBoxPrice1.Text;
                    string free = Free;
                    Int64 so = Int64.Parse(textBoxSoPhong1.Text);
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "Update Roomm_Table set Room_Loai = '" + loai + "', Room_Gia = '" + gia + "' , Room_So ='" + so + "', Room_Free = '"+free+"'  where Room_ID = " + ID + "";
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

        private void buttonXoaRoom_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Con Trong";
            if (radioButtonNo1.Checked)
                Free = "Đa Đuoc Thue";
            if (ID != "")
            {
                if (comboBoxPrice1.Text != "" && comboBoxType1.Text != "" && textBoxSoPhong1.Text != "" && Free != "")
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "delete from Roomm_Table where Room_ID =" + ID + "";
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

        private void textBoxSearchSoPhong_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchSoPhong.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Roomm_Table where Room_So LIKE '" + textBoxSearchSoPhong.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewRoom.DataSource = ds.Tables[0];




            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Roomm_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewRoom.DataSource = ds.Tables[0];

            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                comboBoxType1.Text = row.Cells[1].Value.ToString();
                comboBoxPrice1.Text = row.Cells[2].Value.ToString();
                textBoxSoPhong1.Text = row.Cells[3].Value.ToString();
                Free = row.Cells[4].Value.ToString();
                if (Free == "Con Trong")
                    radioButtonYes.Checked = true;
                if (Free =="Đa Đuoc Thue")
                    radioButtonNo.Checked = true;

            }
        }
    }
}
