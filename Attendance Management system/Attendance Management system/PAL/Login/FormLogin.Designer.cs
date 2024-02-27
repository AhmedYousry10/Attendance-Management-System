﻿namespace AttendanceManagement.Attendance.Forms
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            labelFP = new Label();
            labelError = new Label();
            pictureBoxError = new PictureBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonLogin = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            panel1 = new Panel();
            pictureBoxPicture = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPicture).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Attendance_Management_system.Properties.Resources.icons8_cross_50;
            pictureBoxClose.Location = new Point(1157, 13);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 34);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = Attendance_Management_system.Properties.Resources.icons8_minimize_48;
            pictureBoxMinimize.Location = new Point(1120, 13);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(31, 34);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(labelFP);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Font = new Font("Century Gothic", 10F);
            groupBox1.Location = new Point(107, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Cursor = Cursors.Hand;
            labelFP.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelFP.ForeColor = Color.FromArgb(51, 154, 240);
            labelFP.Location = new Point(159, 279);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(152, 19);
            labelFP.TabIndex = 8;
            labelFP.Text = "Forgot Password?";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 9F);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(126, 241);
            labelError.Name = "labelError";
            labelError.Size = new Size(230, 20);
            labelError.TabIndex = 7;
            labelError.Text = "Invalid Username or Password";
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = Attendance_Management_system.Properties.Resources.icons8_important_32;
            pictureBoxError.Location = new Point(92, 240);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(25, 27);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 6;
            pictureBoxError.TabStop = false;
            pictureBoxError.Click += pictureBoxError_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(95, 185);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(241, 28);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(92, 148);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(51, 154, 240);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(159, 320);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 41);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(95, 100);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(265, 28);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.Location = new Point(92, 64);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = Attendance_Management_system.Properties.Resources.icons8_blind_26;
            pictureBoxHide.Location = new Point(337, 185);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(25, 28);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 4;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = Attendance_Management_system.Properties.Resources.icons8_eye_26;
            pictureBoxShow.Location = new Point(337, 185);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(25, 28);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 3;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(696, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 522);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBoxPicture
            // 
            pictureBoxPicture.Anchor = AnchorStyles.None;
            pictureBoxPicture.Image = Attendance_Management_system.Properties.Resources.icons8_account_100;
            pictureBoxPicture.Location = new Point(819, 177);
            pictureBoxPicture.Name = "pictureBoxPicture";
            pictureBoxPicture.Size = new Size(212, 237);
            pictureBoxPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPicture.TabIndex = 2;
            pictureBoxPicture.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(51, 154, 240);
            label3.Location = new Point(781, 448);
            label3.Name = "label3";
            label3.Size = new Size(354, 32);
            label3.TabIndex = 9;
            label3.Text = "Attendance Management";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(51, 154, 240);
            label4.Location = new Point(906, 500);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 10;
            label4.Text = "System";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(234, 646);
            label5.Name = "label5";
            label5.Size = new Size(235, 21);
            label5.TabIndex = 11;
            label5.Text = "Copy Right@ sherif ebrahim";
            label5.Click += label5_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBoxPicture);
            Controls.Add(panel1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private GroupBox groupBox1;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private Button buttonLogin;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label2;
        private Label labelError;
        private PictureBox pictureBoxError;
        private Label labelFP;
        private Panel panel1;
        private PictureBox pictureBoxPicture;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolTip toolTip;
    }
}