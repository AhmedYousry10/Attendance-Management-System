using System;
using System.Drawing;
using System.Windows.Forms;
namespace Attendance_Management_System.Forms
{
    partial class New_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Password));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxShow_New = new PictureBox();
            pictureBoxHide_New = new PictureBox();
            textBoxNewPassword = new TextBox();
            panel3 = new Panel();
            pictureBoxShow_Confirm = new PictureBox();
            pictureBoxHide_Confirm = new PictureBox();
            textBoxConfirmPassword = new TextBox();
            buttonCancel1 = new Button();
            labelError = new Label();
            buttonChange = new Button();
            ComfirmPassword = new Label();
            NewPassword = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow_New).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide_New).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow_Confirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide_Confirm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(buttonCancel1);
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(buttonChange);
            panel1.Controls.Add(ComfirmPassword);
            panel1.Controls.Add(NewPassword);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 780);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBoxShow_New);
            panel2.Controls.Add(pictureBoxHide_New);
            panel2.Controls.Add(textBoxNewPassword);
            panel2.Location = new Point(346, 309);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 47);
            panel2.TabIndex = 35;
            // 
            // pictureBoxShow_New
            // 
            pictureBoxShow_New.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow_New.Cursor = Cursors.Hand;
            pictureBoxShow_New.Image = (Image)resources.GetObject("pictureBoxShow_New.Image");
            pictureBoxShow_New.Location = new Point(325, -1);
            pictureBoxShow_New.Margin = new Padding(5, 5, 5, 5);
            pictureBoxShow_New.Name = "pictureBoxShow_New";
            pictureBoxShow_New.Padding = new Padding(6, 7, 0, 0);
            pictureBoxShow_New.Size = new Size(51, 47);
            pictureBoxShow_New.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow_New.TabIndex = 4;
            pictureBoxShow_New.TabStop = false;
            pictureBoxShow_New.Click += pictureBoxShow_New_Click;
            pictureBoxShow_New.MouseHover += pictureBoxShow_New_MouseHover;
            // 
            // pictureBoxHide_New
            // 
            pictureBoxHide_New.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide_New.Cursor = Cursors.Hand;
            pictureBoxHide_New.ImageLocation = "";
            pictureBoxHide_New.Location = new Point(325, -1);
            pictureBoxHide_New.Margin = new Padding(5, 5, 5, 5);
            pictureBoxHide_New.Name = "pictureBoxHide_New";
            pictureBoxHide_New.Padding = new Padding(6, 7, 0, 0);
            pictureBoxHide_New.Size = new Size(51, 47);
            pictureBoxHide_New.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide_New.TabIndex = 3;
            pictureBoxHide_New.TabStop = false;
            pictureBoxHide_New.Click += pictureBoxHide_New_Click;
            pictureBoxHide_New.MouseHover += pictureBoxHide_New_MouseHover;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BorderStyle = BorderStyle.None;
            textBoxNewPassword.Location = new Point(7, 12);
            textBoxNewPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(310, 20);
            textBoxNewPassword.TabIndex = 2;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBoxShow_Confirm);
            panel3.Controls.Add(pictureBoxHide_Confirm);
            panel3.Controls.Add(textBoxConfirmPassword);
            panel3.Location = new Point(349, 429);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 47);
            panel3.TabIndex = 34;
            // 
            // pictureBoxShow_Confirm
            // 
            pictureBoxShow_Confirm.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow_Confirm.Cursor = Cursors.Hand;
            pictureBoxShow_Confirm.Image = (Image)resources.GetObject("pictureBoxShow_Confirm.Image");
            pictureBoxShow_Confirm.Location = new Point(325, -1);
            pictureBoxShow_Confirm.Margin = new Padding(5, 5, 5, 5);
            pictureBoxShow_Confirm.Name = "pictureBoxShow_Confirm";
            pictureBoxShow_Confirm.Padding = new Padding(6, 7, 0, 0);
            pictureBoxShow_Confirm.Size = new Size(51, 47);
            pictureBoxShow_Confirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShow_Confirm.TabIndex = 4;
            pictureBoxShow_Confirm.TabStop = false;
            pictureBoxShow_Confirm.Click += pictureBoxShow_Confirm_Click;
            pictureBoxShow_Confirm.MouseHover += pictureBoxShow_Confirm_MouseHover;
            // 
            // pictureBoxHide_Confirm
            // 
            pictureBoxHide_Confirm.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide_Confirm.Cursor = Cursors.Hand;
            pictureBoxHide_Confirm.ImageLocation = "";
            pictureBoxHide_Confirm.Location = new Point(325, -1);
            pictureBoxHide_Confirm.Margin = new Padding(5, 5, 5, 5);
            pictureBoxHide_Confirm.Name = "pictureBoxHide_Confirm";
            pictureBoxHide_Confirm.Padding = new Padding(6, 7, 0, 0);
            pictureBoxHide_Confirm.Size = new Size(51, 47);
            pictureBoxHide_Confirm.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide_Confirm.TabIndex = 3;
            pictureBoxHide_Confirm.TabStop = false;
            pictureBoxHide_Confirm.Click += pictureBoxHide_Confirm_Click;
            pictureBoxHide_Confirm.MouseHover += pictureBoxHide_Confirm_MouseHover;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BorderStyle = BorderStyle.None;
            textBoxConfirmPassword.Location = new Point(7, 12);
            textBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(310, 20);
            textBoxConfirmPassword.TabIndex = 2;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // buttonCancel1
            // 
            buttonCancel1.BackColor = Color.FromArgb(86, 36, 208);
            buttonCancel1.FlatAppearance.BorderSize = 0;
            buttonCancel1.FlatStyle = FlatStyle.Flat;
            buttonCancel1.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            buttonCancel1.ForeColor = Color.White;
            buttonCancel1.Location = new Point(346, 660);
            buttonCancel1.Margin = new Padding(3, 4, 3, 4);
            buttonCancel1.Name = "buttonCancel1";
            buttonCancel1.Size = new Size(377, 67);
            buttonCancel1.TabIndex = 32;
            buttonCancel1.Text = "Cancel";
            buttonCancel1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel1.UseVisualStyleBackColor = false;
            buttonCancel1.Click += buttonCancel1_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 11F);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(354, 496);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 22);
            labelError.TabIndex = 30;
            labelError.Visible = false;
            // 
            // buttonChange
            // 
            buttonChange.BackColor = Color.FromArgb(86, 36, 208);
            buttonChange.FlatAppearance.BorderSize = 0;
            buttonChange.FlatStyle = FlatStyle.Flat;
            buttonChange.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            buttonChange.ForeColor = Color.White;
            buttonChange.Location = new Point(347, 581);
            buttonChange.Margin = new Padding(3, 4, 3, 4);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(377, 67);
            buttonChange.TabIndex = 25;
            buttonChange.Text = "Change";
            buttonChange.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonChange.UseVisualStyleBackColor = false;
            buttonChange.Click += buttonChange_Click;
            // 
            // ComfirmPassword
            // 
            ComfirmPassword.AutoSize = true;
            ComfirmPassword.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            ComfirmPassword.Location = new Point(346, 401);
            ComfirmPassword.Name = "ComfirmPassword";
            ComfirmPassword.Size = new Size(185, 23);
            ComfirmPassword.TabIndex = 28;
            ComfirmPassword.Text = "Comfirm Password:";
            // 
            // NewPassword
            // 
            NewPassword.AutoSize = true;
            NewPassword.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            NewPassword.Location = new Point(347, 281);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(147, 23);
            NewPassword.TabIndex = 26;
            NewPassword.Text = "New Password:";
            // 
            // New_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 780);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "New_Password";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log In | New Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow_New).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide_New).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow_Confirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide_Confirm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel1;
        private Label labelError;
        private Button buttonChange;
        private Label ComfirmPassword;
        private Label NewPassword;
        private Panel panel2;
        private PictureBox pictureBoxShow_New;
        private PictureBox pictureBoxHide_New;
        private TextBox textBoxNewPassword;
        private Panel panel3;
        private PictureBox pictureBoxShow_Confirm;
        private PictureBox pictureBoxHide_Confirm;
        private TextBox textBoxConfirmPassword;
        private ToolTip toolTip1;
    }
}