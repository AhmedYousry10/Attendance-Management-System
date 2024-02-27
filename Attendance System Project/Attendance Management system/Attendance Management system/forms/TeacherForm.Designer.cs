namespace Attendance_Management_system.forms
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonAttendance = new Button();
            buttonReport = new Button();
            panel1 = new Panel();
            panelback = new Panel();
            panelExpand = new Panel();
            buttonMinimize = new Button();
            buttonLogOut = new Button();
            panel3 = new Panel();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            paneltop = new Panel();
            labelRole = new Label();
            label7 = new Label();
            labelUsername = new Label();
            label4 = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelback.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            paneltop.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 180);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(97, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 23);
            label1.TabIndex = 1;
            label1.Text = "Attendance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Location = new Point(0, 180);
            buttonAttendance.Margin = new Padding(4);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(285, 54);
            buttonAttendance.TabIndex = 0;
            buttonAttendance.Text = "Attendance";
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // buttonReport
            // 
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Location = new Point(0, 234);
            buttonReport.Margin = new Padding(4);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(285, 54);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "Report";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 681);
            panel1.TabIndex = 1;
            // 
            // panelback
            // 
            panelback.BackColor = Color.White;
            panelback.Controls.Add(panelExpand);
            panelback.Controls.Add(pictureBoxExpand);
            panelback.Controls.Add(pictureBox2);
            panelback.Controls.Add(labelTime);
            panelback.Controls.Add(paneltop);
            panelback.Dock = DockStyle.Top;
            panelback.Location = new Point(285, 0);
            panelback.Name = "panelback";
            panelback.Size = new Size(899, 165);
            panelback.TabIndex = 2;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(67, 3, 125);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(panel3);
            panelExpand.Location = new Point(674, 52);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 107);
            panelExpand.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Century Gothic", 9F);
            buttonMinimize.ForeColor = Color.FromArgb(67, 3, 125);
            buttonMinimize.Image = Properties.Resources.icons8_minimize_25;
            buttonMinimize.Location = new Point(0, 5);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(198, 48);
            buttonMinimize.TabIndex = 4;
            buttonMinimize.Text = "Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Dock = DockStyle.Bottom;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            buttonLogOut.ForeColor = Color.FromArgb(67, 3, 125);
            buttonLogOut.Image = Properties.Resources.icons8_external_30;
            buttonLogOut.Location = new Point(0, 57);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(198, 48);
            buttonLogOut.TabIndex = 3;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 5);
            panel3.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(796, 34);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(27, 24);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 10;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += PictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(730, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.ForeColor = Color.FromArgb(67, 3, 125);
            labelTime.Location = new Point(24, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(35, 23);
            labelTime.TabIndex = 4;
            labelTime.Text = "{?}";
            // 
            // paneltop
            // 
            paneltop.BackColor = Color.FromArgb(67, 3, 125);
            paneltop.Controls.Add(labelRole);
            paneltop.Controls.Add(label7);
            paneltop.Controls.Add(labelUsername);
            paneltop.Controls.Add(label4);
            paneltop.Dock = DockStyle.Bottom;
            paneltop.Location = new Point(0, 65);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(899, 100);
            paneltop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(67, 3, 125);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(154, 57);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(35, 23);
            labelRole.TabIndex = 8;
            labelRole.Text = "{?}";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(67, 3, 125);
            label7.ForeColor = Color.White;
            label7.Location = new Point(50, 57);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 7;
            label7.Text = "Role:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(67, 3, 125);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(154, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(35, 23);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "{?}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(67, 3, 125);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 22);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 5;
            label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(panelback);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "TeacherForm";
            Text = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panelback.ResumeLayout(false);
            panelback.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonAttendance;
        private Button buttonReport;
        private Panel panel1;
        private Panel panelback;
        private Panel paneltop;
        private Label label4;
        private Label labelTime;
        private Label labelUsername;
        private Label label7;
        private Label labelRole;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxExpand;
        private Panel panelExpand;
        private Panel panel3;
        private Button buttonLogOut;
        private Button buttonMinimize;
        private System.Windows.Forms.Timer timerDateAndTime;
    }
}