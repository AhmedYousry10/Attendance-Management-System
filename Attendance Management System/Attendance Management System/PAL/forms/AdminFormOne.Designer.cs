namespace Attendance_Management_System.PAL.forms
{
    partial class AdminFormOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFormOne));
            panelBack = new Panel();
            labelTime = new Label();
            pictureBox2 = new PictureBox();
            pictureBoxExpand = new PictureBox();
            label4 = new Label();
            labelUsername = new Label();
            label7 = new Label();
            labelRole = new Label();
            panelExpand = new Panel();
            panelTop = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            buttonMinimize = new Button();
            button1 = new Button();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            panelExpand.SuspendLayout();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(258, 0);
            panelBack.Margin = new Padding(2, 3, 2, 3);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(926, 148);
            panelBack.TabIndex = 1;
            panelBack.Paint += panelBack_Paint;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelTime.ForeColor = Color.FromArgb(67, 3, 125);
            labelTime.Location = new Point(19, 21);
            labelTime.Margin = new Padding(2, 0, 2, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(28, 19);
            labelTime.TabIndex = 2;
            labelTime.Text = "{?}";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources._3829933;
            pictureBox2.Location = new Point(730, 0);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.expand_arrow;
            pictureBoxExpand.Location = new Point(794, 32);
            pictureBoxExpand.Margin = new Padding(2, 3, 2, 3);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(21, 21);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 3;
            pictureBoxExpand.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 3;
            label4.Text = "Welcome:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(120, 20);
            labelUsername.Margin = new Padding(2, 0, 2, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(28, 19);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "{?}";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(39, 51);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 5;
            label7.Text = "Role:";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(120, 51);
            labelRole.Margin = new Padding(2, 0, 2, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(28, 19);
            labelRole.TabIndex = 6;
            labelRole.Text = "{?}";
            // 
            // panelExpand
            // 
            panelExpand.BackColor = Color.FromArgb(67, 3, 125);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(button1);
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Controls.Add(panel3);
            panelExpand.Location = new Point(730, 49);
            panelExpand.Margin = new Padding(2, 3, 2, 3);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(185, 96);
            panelExpand.TabIndex = 7;
            panelExpand.Paint += panelExpand_Paint;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(67, 3, 125);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label7);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 59);
            panelTop.Margin = new Padding(2, 3, 2, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(926, 89);
            panelTop.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 161);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picOne;
            pictureBox1.Location = new Point(63, 4);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 19);
            label1.TabIndex = 1;
            label1.Text = "Attendance Management ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "System";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 681);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 4);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = Color.FromArgb(67, 3, 125);
            buttonMinimize.Image = (Image)resources.GetObject("buttonMinimize.Image");
            buttonMinimize.Location = new Point(0, 4);
            buttonMinimize.Margin = new Padding(2, 3, 2, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(183, 48);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.Text = "    Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(67, 3, 125);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 52);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(183, 48);
            button1.TabIndex = 2;
            button1.Text = "    Log Out";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // AdminFormOne
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F);
            ForeColor = Color.FromArgb(67, 3, 125);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminFormOne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Management System";
            WindowState = FormWindowState.Maximized;
            Load += AdminFormOne_Load;
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            panelExpand.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBack;
        private Label labelTime;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxExpand;
        private Panel panelTop;
        private Panel panelExpand;
        private Label labelRole;
        private Label label7;
        private Label labelUsername;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Button button1;
        private Button buttonMinimize;
    }
}