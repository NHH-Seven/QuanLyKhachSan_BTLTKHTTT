using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTLTKHTTTNHOM2
{
    public partial class Dashboard : Form
    {
        public string Username;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void buttonNguoiDung_Click(object sender, EventArgs e)
        {
            MovePanel(buttonNguoiDung);
            NguoiDung nd = new NguoiDung();
            nd.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            this.Close();
            DialogResult result = MessageBox.Show("Are you want to log out?", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString("dd-MMM-yyyy hhh:mm:ss tt");
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            MovePanel(buttonKhachHang);
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPhong);
            Phong ph = new Phong();
            ph.Show();
        }

        private void buttonThuePhong_Click(object sender, EventArgs e)
        {
            MovePanel(buttonThuePhong);
            ThuePhong th = new ThuePhong();
            th.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            Thong_Ke dh = new Thong_Ke();
            dh.Show();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDichVu);
            Dichvu dv = new Dichvu();
            dv.Show();
        }
    }
}
