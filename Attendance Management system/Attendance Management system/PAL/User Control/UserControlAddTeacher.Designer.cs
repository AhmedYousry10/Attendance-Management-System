namespace Attendance_Management_System.Forms
{
    partial class UserControlAddTeacher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlAddTeacher = new TabControl();
            tabPageAdd = new TabPage();
            buttonAdd = new Button();
            textBoxPass = new TextBox();
            labelPass = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelAdd = new Label();
            tabPageUpdate = new TabPage();
            buttonDelete = new Button();
            buttonFInd = new Button();
            buttonUpdate = new Button();
            textBoxUpPass = new TextBox();
            labelUpPass = new Label();
            textBoxUpEmail = new TextBox();
            labelUpEmail = new Label();
            textBoxUpID = new TextBox();
            labelUpID = new Label();
            textBoxUpName = new TextBox();
            labelUpName = new Label();
            labelUpdate = new Label();
            tabControlAddTeacher.SuspendLayout();
            tabPageAdd.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddTeacher
            // 
            tabControlAddTeacher.Alignment = TabAlignment.Bottom;
            tabControlAddTeacher.Anchor = AnchorStyles.None;
            tabControlAddTeacher.Controls.Add(tabPageAdd);
            tabControlAddTeacher.Controls.Add(tabPageUpdate);
            tabControlAddTeacher.Location = new Point(2, -2);
            tabControlAddTeacher.Margin = new Padding(3, 2, 3, 2);
            tabControlAddTeacher.Name = "tabControlAddTeacher";
            tabControlAddTeacher.SelectedIndex = 0;
            tabControlAddTeacher.Size = new Size(819, 374);
            tabControlAddTeacher.TabIndex = 2;
            tabControlAddTeacher.Selected += tabControlAddTeacher_Selected;
            // 
            // tabPageAdd
            // 
            tabPageAdd.Controls.Add(buttonAdd);
            tabPageAdd.Controls.Add(textBoxPass);
            tabPageAdd.Controls.Add(labelPass);
            tabPageAdd.Controls.Add(textBoxEmail);
            tabPageAdd.Controls.Add(labelEmail);
            tabPageAdd.Controls.Add(textBoxID);
            tabPageAdd.Controls.Add(labelID);
            tabPageAdd.Controls.Add(textBoxName);
            tabPageAdd.Controls.Add(labelName);
            tabPageAdd.Controls.Add(labelAdd);
            tabPageAdd.Location = new Point(4, 4);
            tabPageAdd.Margin = new Padding(3, 2, 3, 2);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3, 2, 3, 2);
            tabPageAdd.Size = new Size(811, 346);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Add Teacher";
            tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkSlateBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(536, 304);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(128, 33);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Location = new Point(443, 172);
            textBoxPass.Margin = new Padding(3, 2, 3, 2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(184, 23);
            textBoxPass.TabIndex = 8;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPass.Location = new Point(448, 150);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(59, 15);
            labelPass.TabIndex = 7;
            labelPass.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(73, 172);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(184, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEmail.Location = new Point(73, 150);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(443, 94);
            textBoxID.Margin = new Padding(3, 2, 3, 2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(184, 23);
            textBoxID.TabIndex = 4;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelID.Location = new Point(448, 72);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(73, 94);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 23);
            textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.Location = new Point(75, 72);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAdd.Location = new Point(10, 7);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(104, 21);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add Teacher";
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(buttonDelete);
            tabPageUpdate.Controls.Add(buttonFInd);
            tabPageUpdate.Controls.Add(buttonUpdate);
            tabPageUpdate.Controls.Add(textBoxUpPass);
            tabPageUpdate.Controls.Add(labelUpPass);
            tabPageUpdate.Controls.Add(textBoxUpEmail);
            tabPageUpdate.Controls.Add(labelUpEmail);
            tabPageUpdate.Controls.Add(textBoxUpID);
            tabPageUpdate.Controls.Add(labelUpID);
            tabPageUpdate.Controls.Add(textBoxUpName);
            tabPageUpdate.Controls.Add(labelUpName);
            tabPageUpdate.Controls.Add(labelUpdate);
            tabPageUpdate.Location = new Point(4, 4);
            tabPageUpdate.Margin = new Padding(3, 2, 3, 2);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Padding = new Padding(3, 2, 3, 2);
            tabPageUpdate.Size = new Size(688, 394);
            tabPageUpdate.TabIndex = 1;
            tabPageUpdate.Text = "Update Teacher";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.OrangeRed;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(613, 298);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(133, 32);
            buttonDelete.TabIndex = 23;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonFInd
            // 
            buttonFInd.BackColor = Color.DarkSlateBlue;
            buttonFInd.FlatStyle = FlatStyle.Flat;
            buttonFInd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonFInd.ForeColor = Color.White;
            buttonFInd.Location = new Point(379, 80);
            buttonFInd.Margin = new Padding(3, 2, 3, 2);
            buttonFInd.Name = "buttonFInd";
            buttonFInd.Size = new Size(142, 29);
            buttonFInd.TabIndex = 22;
            buttonFInd.Text = "Find";
            buttonFInd.UseVisualStyleBackColor = false;
            buttonFInd.Click += buttonFInd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DarkSlateBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(475, 298);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(133, 32);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxUpPass
            // 
            textBoxUpPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpPass.Location = new Point(388, 252);
            textBoxUpPass.Margin = new Padding(3, 2, 3, 2);
            textBoxUpPass.Name = "textBoxUpPass";
            textBoxUpPass.Size = new Size(184, 23);
            textBoxUpPass.TabIndex = 18;
            // 
            // labelUpPass
            // 
            labelUpPass.AutoSize = true;
            labelUpPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpPass.Location = new Point(391, 229);
            labelUpPass.Name = "labelUpPass";
            labelUpPass.Size = new Size(59, 15);
            labelUpPass.TabIndex = 17;
            labelUpPass.Text = "Password";
            // 
            // textBoxUpEmail
            // 
            textBoxUpEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpEmail.Location = new Point(73, 174);
            textBoxUpEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxUpEmail.Name = "textBoxUpEmail";
            textBoxUpEmail.Size = new Size(193, 23);
            textBoxUpEmail.TabIndex = 16;
            // 
            // labelUpEmail
            // 
            labelUpEmail.AutoSize = true;
            labelUpEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpEmail.Location = new Point(75, 149);
            labelUpEmail.Name = "labelUpEmail";
            labelUpEmail.Size = new Size(36, 15);
            labelUpEmail.TabIndex = 15;
            labelUpEmail.Text = "Email";
            // 
            // textBoxUpID
            // 
            textBoxUpID.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpID.Location = new Point(81, 88);
            textBoxUpID.Margin = new Padding(3, 2, 3, 2);
            textBoxUpID.Name = "textBoxUpID";
            textBoxUpID.Size = new Size(184, 23);
            textBoxUpID.TabIndex = 14;
            // 
            // labelUpID
            // 
            labelUpID.AutoSize = true;
            labelUpID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpID.Location = new Point(84, 64);
            labelUpID.Name = "labelUpID";
            labelUpID.Size = new Size(20, 15);
            labelUpID.TabIndex = 13;
            labelUpID.Text = "ID";
            // 
            // textBoxUpName
            // 
            textBoxUpName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpName.Location = new Point(388, 174);
            textBoxUpName.Margin = new Padding(3, 2, 3, 2);
            textBoxUpName.Name = "textBoxUpName";
            textBoxUpName.Size = new Size(184, 23);
            textBoxUpName.TabIndex = 12;
            // 
            // labelUpName
            // 
            labelUpName.AutoSize = true;
            labelUpName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpName.Location = new Point(391, 149);
            labelUpName.Name = "labelUpName";
            labelUpName.Size = new Size(40, 15);
            labelUpName.TabIndex = 11;
            labelUpName.Text = "Name";
            // 
            // labelUpdate
            // 
            labelUpdate.AutoSize = true;
            labelUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpdate.Location = new Point(8, 11);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(95, 15);
            labelUpdate.TabIndex = 10;
            labelUpdate.Text = "Update Teacher";
            // 
            // UserControlAddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAddTeacher);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlAddTeacher";
            Size = new Size(824, 376);
            tabControlAddTeacher.ResumeLayout(false);
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddTeacher;
        private TabPage tabPageAdd;
        private Button buttonAdd;
        private TextBox textBoxPass;
        private Label labelPass;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelAdd;
        private TabPage tabPageUpdate;
        private Button buttonDelete;
        private Button buttonFInd;
        private Button buttonUpdate;
        private TextBox textBoxUpPass;
        private Label labelUpPass;
        private TextBox textBoxUpEmail;
        private Label labelUpEmail;
        private TextBox textBoxUpID;
        private Label labelUpID;
        private TextBox textBoxUpName;
        private Label labelUpName;
        private Label labelUpdate;
    }
}
