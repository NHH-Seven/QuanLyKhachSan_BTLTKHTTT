namespace BTLTKHTTTNHOM2
{
    partial class Phong
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSoPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageTimKiemRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.textBoxSearchSoPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateRoom = new System.Windows.Forms.TabPage();
            this.buttonXoaRoom = new System.Windows.Forms.Button();
            this.comboBoxPrice1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.buttonSuaRoom = new System.Windows.Forms.Button();
            this.textBoxSoPhong1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageTimKiemRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPageUpdateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageTimKiemRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(36, 14);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(922, 398);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.radioButtonNo);
            this.tabPageAddRoom.Controls.Add(this.radioButtonYes);
            this.tabPageAddRoom.Controls.Add(this.label11);
            this.tabPageAddRoom.Controls.Add(this.comboBoxPrice);
            this.tabPageAddRoom.Controls.Add(this.label7);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.buttonAdd);
            this.tabPageAddRoom.Controls.Add(this.textBoxSoPhong);
            this.tabPageAddRoom.Controls.Add(this.label8);
            this.tabPageAddRoom.Controls.Add(this.label9);
            this.tabPageAddRoom.Controls.Add(this.label10);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(914, 364);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Them Phong";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Items.AddRange(new object[] {
            "2000",
            "3000",
            "4000",
            "5000"});
            this.comboBoxPrice.Location = new System.Drawing.Point(153, 218);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(282, 29);
            this.comboBoxPrice.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(149, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Gia Phong";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Gia Dinh",
            "VIP"});
            this.comboBoxType.Location = new System.Drawing.Point(153, 140);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(282, 29);
            this.comboBoxType.TabIndex = 20;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(153, 275);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSoPhong
            // 
            this.textBoxSoPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSoPhong.Location = new System.Drawing.Point(496, 140);
            this.textBoxSoPhong.Name = "textBoxSoPhong";
            this.textBoxSoPhong.Size = new System.Drawing.Size(282, 28);
            this.textBoxSoPhong.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(492, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "So Phong";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(149, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Loai Phong";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Them Phong";
            // 
            // tabPageTimKiemRoom
            // 
            this.tabPageTimKiemRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageTimKiemRoom.Controls.Add(this.textBoxSearchSoPhong);
            this.tabPageTimKiemRoom.Controls.Add(this.label5);
            this.tabPageTimKiemRoom.Controls.Add(this.label6);
            this.tabPageTimKiemRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageTimKiemRoom.Name = "tabPageTimKiemRoom";
            this.tabPageTimKiemRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimKiemRoom.Size = new System.Drawing.Size(914, 364);
            this.tabPageTimKiemRoom.TabIndex = 1;
            this.tabPageTimKiemRoom.Text = "Tim Kiem Phong";
            this.tabPageTimKiemRoom.UseVisualStyleBackColor = true;
            this.tabPageTimKiemRoom.Click += new System.EventHandler(this.tabPageTimKiemRoom_Click);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room_Number,
            this.Room_Phone,
            this.Room_Type,
            this.Room_Price,
            this.Column1});
            this.dataGridViewRoom.Location = new System.Drawing.Point(60, 83);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(810, 263);
            this.dataGridViewRoom.TabIndex = 9;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // textBoxSearchSoPhong
            // 
            this.textBoxSearchSoPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchSoPhong.Location = new System.Drawing.Point(189, 49);
            this.textBoxSearchSoPhong.Name = "textBoxSearchSoPhong";
            this.textBoxSearchSoPhong.Size = new System.Drawing.Size(282, 28);
            this.textBoxSearchSoPhong.TabIndex = 8;
            this.textBoxSearchSoPhong.TextChanged += new System.EventHandler(this.textBoxSearchSoPhong_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(185, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "So Phong";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search Room:";
            // 
            // tabPageUpdateRoom
            // 
            this.tabPageUpdateRoom.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateRoom.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateRoom.Controls.Add(this.label12);
            this.tabPageUpdateRoom.Controls.Add(this.buttonXoaRoom);
            this.tabPageUpdateRoom.Controls.Add(this.comboBoxPrice1);
            this.tabPageUpdateRoom.Controls.Add(this.label4);
            this.tabPageUpdateRoom.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateRoom.Controls.Add(this.buttonSuaRoom);
            this.tabPageUpdateRoom.Controls.Add(this.textBoxSoPhong1);
            this.tabPageUpdateRoom.Controls.Add(this.label3);
            this.tabPageUpdateRoom.Controls.Add(this.label2);
            this.tabPageUpdateRoom.Controls.Add(this.label1);
            this.tabPageUpdateRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateRoom.Name = "tabPageUpdateRoom";
            this.tabPageUpdateRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateRoom.Size = new System.Drawing.Size(914, 364);
            this.tabPageUpdateRoom.TabIndex = 2;
            this.tabPageUpdateRoom.Text = "Sua va Xoa thong tin";
            this.tabPageUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // buttonXoaRoom
            // 
            this.buttonXoaRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoaRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonXoaRoom.FlatAppearance.BorderSize = 0;
            this.buttonXoaRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoaRoom.ForeColor = System.Drawing.Color.White;
            this.buttonXoaRoom.Location = new System.Drawing.Point(280, 284);
            this.buttonXoaRoom.Name = "buttonXoaRoom";
            this.buttonXoaRoom.Size = new System.Drawing.Size(96, 37);
            this.buttonXoaRoom.TabIndex = 15;
            this.buttonXoaRoom.Text = "Xoa";
            this.buttonXoaRoom.UseVisualStyleBackColor = false;
            this.buttonXoaRoom.Click += new System.EventHandler(this.buttonXoaRoom_Click);
            // 
            // comboBoxPrice1
            // 
            this.comboBoxPrice1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPrice1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPrice1.FormattingEnabled = true;
            this.comboBoxPrice1.Items.AddRange(new object[] {
            "2000",
            "3000",
            "4000",
            "5000"});
            this.comboBoxPrice1.Location = new System.Drawing.Point(153, 227);
            this.comboBoxPrice1.Name = "comboBoxPrice1";
            this.comboBoxPrice1.Size = new System.Drawing.Size(282, 29);
            this.comboBoxPrice1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(149, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gia Phong";
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Don",
            "Doi",
            "Gia Dinh",
            "VIP"});
            this.comboBoxType1.Location = new System.Drawing.Point(153, 149);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(282, 29);
            this.comboBoxType1.TabIndex = 12;
            // 
            // buttonSuaRoom
            // 
            this.buttonSuaRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSuaRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonSuaRoom.FlatAppearance.BorderSize = 0;
            this.buttonSuaRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSuaRoom.ForeColor = System.Drawing.Color.White;
            this.buttonSuaRoom.Location = new System.Drawing.Point(153, 284);
            this.buttonSuaRoom.Name = "buttonSuaRoom";
            this.buttonSuaRoom.Size = new System.Drawing.Size(96, 37);
            this.buttonSuaRoom.TabIndex = 11;
            this.buttonSuaRoom.Text = "Sua";
            this.buttonSuaRoom.UseVisualStyleBackColor = false;
            this.buttonSuaRoom.Click += new System.EventHandler(this.buttonSuaRoom_Click);
            // 
            // textBoxSoPhong1
            // 
            this.textBoxSoPhong1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSoPhong1.Location = new System.Drawing.Point(496, 149);
            this.textBoxSoPhong1.Name = "textBoxSoPhong1";
            this.textBoxSoPhong1.Size = new System.Drawing.Size(282, 28);
            this.textBoxSoPhong1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(492, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "So Phong";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(149, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loai Phong";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sua va Xoa thong tin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(492, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Trạng Thái :";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(616, 207);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(116, 25);
            this.radioButtonYes.TabIndex = 24;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Con Trong";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(616, 239);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(150, 25);
            this.radioButtonNo.TabIndex = 25;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Đa Đuoc Thue";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(618, 252);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(147, 25);
            this.radioButtonNo1.TabIndex = 28;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "Đã Được Thuê";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(618, 220);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(114, 25);
            this.radioButtonYes1.TabIndex = 27;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Còn Trống";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(494, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Trạng Thái :";
            // 
            // Room_Number
            // 
            this.Room_Number.DataPropertyName = "Room_ID";
            this.Room_Number.HeaderText = "No";
            this.Room_Number.MinimumWidth = 6;
            this.Room_Number.Name = "Room_Number";
            this.Room_Number.ReadOnly = true;
            // 
            // Room_Phone
            // 
            this.Room_Phone.DataPropertyName = "Room_So";
            this.Room_Phone.HeaderText = "So Phong";
            this.Room_Phone.MinimumWidth = 6;
            this.Room_Phone.Name = "Room_Phone";
            this.Room_Phone.ReadOnly = true;
            // 
            // Room_Type
            // 
            this.Room_Type.DataPropertyName = "Room_Loai";
            this.Room_Type.HeaderText = "Loai Phong";
            this.Room_Type.MinimumWidth = 6;
            this.Room_Type.Name = "Room_Type";
            this.Room_Type.ReadOnly = true;
            // 
            // Room_Price
            // 
            this.Room_Price.DataPropertyName = "Room_Gia";
            this.Room_Price.HeaderText = "Gia Phong";
            this.Room_Price.MinimumWidth = 6;
            this.Room_Price.Name = "Room_Price";
            this.Room_Price.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_Free";
            this.Column1.HeaderText = "Trang Thai";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 462);
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Phong";
            this.Text = "Phong";
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageTimKiemRoom.ResumeLayout(false);
            this.tabPageTimKiemRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPageUpdateRoom.ResumeLayout(false);
            this.tabPageUpdateRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageTimKiemRoom;
        private System.Windows.Forms.TabPage tabPageUpdateRoom;
        private System.Windows.Forms.Button buttonSuaRoom;
        private System.Windows.Forms.TextBox textBoxSoPhong1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.ComboBox comboBoxPrice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.TextBox textBoxSearchSoPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSoPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonXoaRoom;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}