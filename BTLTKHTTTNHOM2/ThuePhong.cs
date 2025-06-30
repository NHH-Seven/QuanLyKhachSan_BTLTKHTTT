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
    public partial class ThuePhong : Form
    {
        private string ID = "", No;
        public ThuePhong()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxClientID.Text != "" && comboBoxDV.Text != "" && comboBoxRoomNo.Text != "" && comboBoxType.Text != "")
            {
                string loai = comboBoxType.Text;
                string ID_client = textBoxClientID.Text;
                string ten = comboBoxDV.Text;
                string so = comboBoxRoomNo.Text;
                string datein = dateTimePickerIn.Text;
                string dateout = dateTimePickerOut.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into ThueePhong_Table (TP_Loai,TP_So, TP_ClientID,TP_DV,TP_In,TP_Out) values ('" + loai + "' , '" + so + "' ,  '" + ID_client + "' , '"+ ten+"' , '"+ datein+"' ,'"+dateout+"')";
                cmd.CommandText = "Update Roomm_Table set Room_Free = 'Da Thue'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Da luu thông tin ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                comboBoxType.Text = row.Cells[1].Value.ToString();
                comboBoxDV.Text = row.Cells[3]. Value.ToString();
                textBoxClientID.Text = row.Cells[2].Value.ToString();
                comboBoxRoomNo.Text = row.Cells[4].Value.ToString();
                dateTimePickerIn.Text = row.Cells[5].Value.ToString();
                dateTimePickerOut.Text = row.Cells[6].Value.ToString();
            }
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchClientID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from ThueePhong_Table where TP_ClientID LIKE '" + textBoxSearchClientID.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewReservation.DataSource = ds.Tables[0];




            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HUYHIEU; database = Hotel_Management_System ;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from ThueePhong_Table";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewReservation.DataSource = ds.Tables[0];

            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxClientID1.Text != "" && comboBoxDV1.Text != "" && comboBoxRoomNo1.Text != "" && comboBoxType1.Text != "")
                {
                    string loai = comboBoxType1.Text;
                    string ID_client = textBoxClientID1.Text;
                    string ten = comboBoxDV1.Text;
                    string so = comboBoxRoomNo1.Text  ;
                    string datein = dateTimePickerIn1.Text;
                    string dateout = dateTimePickerOut1.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "Update ThueePhong_Table set TP_Loai = '" + loai + "', TP_So = '" + so + "' , TP_ClientID ='" + ID_client + "' , TP_DV = '" + ten + "' , TP_In = '"+datein+"', TP_Out = '"+dateout+"' where TP_ID = " + ID + "";
                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Da luu Thong Tin", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (textBoxClientID1.Text != "" && comboBoxDV1.Text != "" && comboBoxRoomNo1.Text != "" && comboBoxType1.Text != "")
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HUYHIEU;database = Hotel_Management_System ;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "delete from ThueePhong_Table where TP_ID =" + ID + "";
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

        private void tabPageUpdateRaservation_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddReservation_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source HUYHIEU; database Hotel Management System; integrated security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("select DV_Name from DichVuu_Table", con))
                {
                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        comboBoxDV.Items.Add(sdr["DV_Name"].ToString());
                    }

                    sdr.Close();
                }
            }
        }
     

        private void tabPageSearchReservation_Click(object sender, EventArgs e)
        {

        }
    }
}
