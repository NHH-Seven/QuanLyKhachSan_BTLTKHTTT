﻿namespace BTLTKHTTTNHOM2
{
    partial class NguoiDung
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
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageSeachUser = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUdateandDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControlUser.SuspendLayout();
            this.tabPageSeachUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageUdateandDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageSeachUser);
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageUdateandDelete);
            this.tabControlUser.Location = new System.Drawing.Point(77, 0);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(930, 414);
            this.tabControlUser.TabIndex = 2;
            // 
            // tabPageSeachUser
            // 
            this.tabPageSeachUser.Controls.Add(this.dataGridViewUser);
            this.tabPageSeachUser.Controls.Add(this.textBoxSearchUsername);
            this.tabPageSeachUser.Controls.Add(this.label5);
            this.tabPageSeachUser.Controls.Add(this.label4);
            this.tabPageSeachUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSeachUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSeachUser.Name = "tabPageSeachUser";
            this.tabPageSeachUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeachUser.Size = new System.Drawing.Size(922, 385);
            this.tabPageSeachUser.TabIndex = 1;
            this.tabPageSeachUser.Text = "Tim Kiem Nguoi Dung";
            this.tabPageSeachUser.UseVisualStyleBackColor = true;
            this.tabPageSeachUser.Enter += new System.EventHandler(this.tabPageSeachUser_Enter);
            this.tabPageSeachUser.Leave += new System.EventHandler(this.tabPageSeachUser_Leave);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewUser.Location = new System.Drawing.Point(56, 101);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(810, 263);
            this.dataGridViewUser.TabIndex = 5;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxSearchUsername
            // 
            this.textBoxSearchUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchUsername.Location = new System.Drawing.Point(237, 67);
            this.textBoxSearchUsername.Name = "textBoxSearchUsername";
            this.textBoxSearchUsername.Size = new System.Drawing.Size(282, 30);
            this.textBoxSearchUsername.TabIndex = 4;
            this.textBoxSearchUsername.TextChanged += new System.EventHandler(this.textBoxSearchUsername_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(233, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tim Kiem Nguoi Dung:";
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.buttonAdd);
            this.tabPageAddUser.Controls.Add(this.textBoxPassword);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.textBoxUsername);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(922, 385);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Them Nguoi Dung";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.DragLeave += new System.EventHandler(this.tabPageAddUser_DragLeave);
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(153, 184);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(496, 142);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(282, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(492, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Location = new System.Drawing.Point(153, 142);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(282, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(149, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            // 
            // tabPageUdateandDelete
            // 
            this.tabPageUdateandDelete.Controls.Add(this.buttonDelete);
            this.tabPageUdateandDelete.Controls.Add(this.buttonUpdate);
            this.tabPageUdateandDelete.Controls.Add(this.textBoxPassword1);
            this.tabPageUdateandDelete.Controls.Add(this.label6);
            this.tabPageUdateandDelete.Controls.Add(this.textBoxUsername1);
            this.tabPageUdateandDelete.Controls.Add(this.label7);
            this.tabPageUdateandDelete.Controls.Add(this.label8);
            this.tabPageUdateandDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUdateandDelete.Name = "tabPageUdateandDelete";
            this.tabPageUdateandDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUdateandDelete.Size = new System.Drawing.Size(922, 385);
            this.tabPageUdateandDelete.TabIndex = 2;
            this.tabPageUdateandDelete.Text = "Sua va Xoa";
            this.tabPageUdateandDelete.UseVisualStyleBackColor = true;
            this.tabPageUdateandDelete.Leave += new System.EventHandler(this.tabPageUdateandDelete_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(266, 184);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Xoa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(153, 184);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Sua";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword1.Location = new System.Drawing.Point(496, 142);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(282, 22);
            this.textBoxPassword1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(492, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername1.Location = new System.Drawing.Point(153, 142);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(282, 22);
            this.textBoxUsername1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(149, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Add User";
            // 
            // NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 415);
            this.Controls.Add(this.tabControlUser);
            this.Name = "NguoiDung";
            this.Text = "NguoiDung";
            this.Load += new System.EventHandler(this.NguoiDung_Load);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageSeachUser.ResumeLayout(false);
            this.tabPageSeachUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageUdateandDelete.ResumeLayout(false);
            this.tabPageUdateandDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageSeachUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxSearchUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUdateandDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}