namespace BTLTKHTTTNHOM2
{
    partial class KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageTimKiem = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.textBoxSearchSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageAddKhachHang = new System.Windows.Forms.TabPage();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.textBoxDiaChi1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSDT1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.textBoxTen1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxHo1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlClient.SuspendLayout();
            this.tabPageTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageAddKhachHang.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Controls.Add(this.tabPageTimKiem);
            this.tabControlClient.Controls.Add(this.tabPageAddKhachHang);
            this.tabControlClient.Controls.Add(this.tabPageUpdate);
            this.tabControlClient.Location = new System.Drawing.Point(36, 14);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(930, 414);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageTimKiem
            // 
            this.tabPageTimKiem.Controls.Add(this.dataGridViewClient);
            this.tabPageTimKiem.Controls.Add(this.textBoxSearchSDT);
            this.tabPageTimKiem.Controls.Add(this.label6);
            this.tabPageTimKiem.Controls.Add(this.label7);
            this.tabPageTimKiem.Location = new System.Drawing.Point(4, 4);
            this.tabPageTimKiem.Name = "tabPageTimKiem";
            this.tabPageTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimKiem.Size = new System.Drawing.Size(922, 380);
            this.tabPageTimKiem.TabIndex = 0;
            this.tabPageTimKiem.Text = "Tim Kiem khach hang";
            this.tabPageTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Client_SDT,
            this.Client_Diachi});
            this.dataGridViewClient.Location = new System.Drawing.Point(57, 100);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(810, 263);
            this.dataGridViewClient.TabIndex = 9;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // textBoxSearchSDT
            // 
            this.textBoxSearchSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchSDT.Location = new System.Drawing.Point(236, 66);
            this.textBoxSearchSDT.Name = "textBoxSearchSDT";
            this.textBoxSearchSDT.Size = new System.Drawing.Size(282, 28);
            this.textBoxSearchSDT.TabIndex = 8;
            this.textBoxSearchSDT.TextChanged += new System.EventHandler(this.textBoxSearchSDT_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(232, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "So Dien Thoai";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tim Kiem Khach Hang:";
            // 
            // tabPageAddKhachHang
            // 
            this.tabPageAddKhachHang.Controls.Add(this.textBoxDiaChi);
            this.tabPageAddKhachHang.Controls.Add(this.label5);
            this.tabPageAddKhachHang.Controls.Add(this.textBoxSDT);
            this.tabPageAddKhachHang.Controls.Add(this.label4);
            this.tabPageAddKhachHang.Controls.Add(this.buttonAdd);
            this.tabPageAddKhachHang.Controls.Add(this.textBoxTen);
            this.tabPageAddKhachHang.Controls.Add(this.label3);
            this.tabPageAddKhachHang.Controls.Add(this.textBoxHo);
            this.tabPageAddKhachHang.Controls.Add(this.label2);
            this.tabPageAddKhachHang.Controls.Add(this.label1);
            this.tabPageAddKhachHang.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddKhachHang.Name = "tabPageAddKhachHang";
            this.tabPageAddKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddKhachHang.Size = new System.Drawing.Size(922, 380);
            this.tabPageAddKhachHang.TabIndex = 1;
            this.tabPageAddKhachHang.Text = "Them Khach Hang";
            this.tabPageAddKhachHang.UseVisualStyleBackColor = true;
            this.tabPageAddKhachHang.Click += new System.EventHandler(this.tabPageAddKhachHang_Click);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDiaChi.Location = new System.Drawing.Point(163, 206);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(625, 90);
            this.textBoxDiaChi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(159, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dia Chi";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSDT.Location = new System.Drawing.Point(163, 136);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(282, 28);
            this.textBoxSDT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(159, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "So Dien Thoai";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(163, 302);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTen
            // 
            this.textBoxTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTen.Location = new System.Drawing.Point(506, 66);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(282, 28);
            this.textBoxTen.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(502, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ten";
            // 
            // textBoxHo
            // 
            this.textBoxHo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHo.Location = new System.Drawing.Point(163, 66);
            this.textBoxHo.Name = "textBoxHo";
            this.textBoxHo.Size = new System.Drawing.Size(282, 28);
            this.textBoxHo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(159, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ho";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add User";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.buttonXoa);
            this.tabPageUpdate.Controls.Add(this.textBoxDiaChi1);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.textBoxSDT1);
            this.tabPageUpdate.Controls.Add(this.label9);
            this.tabPageUpdate.Controls.Add(this.buttonSua);
            this.tabPageUpdate.Controls.Add(this.textBoxTen1);
            this.tabPageUpdate.Controls.Add(this.label10);
            this.tabPageUpdate.Controls.Add(this.textBoxHo1);
            this.tabPageUpdate.Controls.Add(this.label11);
            this.tabPageUpdate.Controls.Add(this.label12);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(922, 380);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Sua va Xoa thong tin ";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(291, 303);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(96, 37);
            this.buttonXoa.TabIndex = 26;
            this.buttonXoa.Text = "Xoa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // textBoxDiaChi1
            // 
            this.textBoxDiaChi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDiaChi1.Location = new System.Drawing.Point(162, 207);
            this.textBoxDiaChi1.Multiline = true;
            this.textBoxDiaChi1.Name = "textBoxDiaChi1";
            this.textBoxDiaChi1.Size = new System.Drawing.Size(625, 90);
            this.textBoxDiaChi1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(158, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Dia Chi";
            // 
            // textBoxSDT1
            // 
            this.textBoxSDT1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSDT1.Location = new System.Drawing.Point(162, 137);
            this.textBoxSDT1.Name = "textBoxSDT1";
            this.textBoxSDT1.Size = new System.Drawing.Size(282, 28);
            this.textBoxSDT1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(158, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "So Dien Thoai";
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(162, 303);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(96, 37);
            this.buttonSua.TabIndex = 21;
            this.buttonSua.Text = "Sua";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // textBoxTen1
            // 
            this.textBoxTen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTen1.Location = new System.Drawing.Point(505, 67);
            this.textBoxTen1.Name = "textBoxTen1";
            this.textBoxTen1.Size = new System.Drawing.Size(282, 28);
            this.textBoxTen1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(501, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ten";
            // 
            // textBoxHo1
            // 
            this.textBoxHo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHo1.Location = new System.Drawing.Point(162, 67);
            this.textBoxHo1.Name = "textBoxHo1";
            this.textBoxHo1.Size = new System.Drawing.Size(282, 28);
            this.textBoxHo1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(158, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ho";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label12.Location = new System.Drawing.Point(4, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Add User";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_Firstname";
            this.Column2.HeaderText = "Ho";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_Lastname";
            this.Column3.HeaderText = "Ten";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Client_SDT
            // 
            this.Client_SDT.DataPropertyName = "Client_Phone";
            this.Client_SDT.HeaderText = "So dien thoai";
            this.Client_SDT.MinimumWidth = 6;
            this.Client_SDT.Name = "Client_SDT";
            this.Client_SDT.ReadOnly = true;
            // 
            // Client_Diachi
            // 
            this.Client_Diachi.DataPropertyName = "Client_Address";
            this.Client_Diachi.HeaderText = "Dia Chi";
            this.Client_Diachi.MinimumWidth = 6;
            this.Client_Diachi.Name = "Client_Diachi";
            this.Client_Diachi.ReadOnly = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 462);
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.tabControlClient.ResumeLayout(false);
            this.tabPageTimKiem.ResumeLayout(false);
            this.tabPageTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageAddKhachHang.ResumeLayout(false);
            this.tabPageAddKhachHang.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageTimKiem;
        private System.Windows.Forms.TabPage tabPageAddKhachHang;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.TextBox textBoxDiaChi1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSDT1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.TextBox textBoxTen1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxHo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Diachi;
    }
}