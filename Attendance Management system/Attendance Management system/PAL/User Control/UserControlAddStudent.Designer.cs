namespace Attendance_Management_System.Forms
{
    partial class UserControlAddStudent
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
            tabControlAddStudent = new TabControl();
            tabPageAdd = new TabPage();
            labelClass = new Label();
            comboBoxClass = new ComboBox();
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
            labelUpClass = new Label();
            comboBoxUpClass = new ComboBox();
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
            tabControlAddStudent.SuspendLayout();
            tabPageAdd.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Alignment = TabAlignment.Bottom;
            tabControlAddStudent.Anchor = AnchorStyles.None;
            tabControlAddStudent.Controls.Add(tabPageAdd);
            tabControlAddStudent.Controls.Add(tabPageUpdate);
            tabControlAddStudent.Location = new Point(36, 6);
            tabControlAddStudent.Margin = new Padding(3, 2, 3, 2);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(807, 408);
            tabControlAddStudent.TabIndex = 1;
            tabControlAddStudent.Selected += tabControlAddStudent_Selected;
            // 
            // tabPageAdd
            // 
            tabPageAdd.Controls.Add(labelClass);
            tabPageAdd.Controls.Add(comboBoxClass);
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
            tabPageAdd.Size = new Size(799, 380);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Add Student";
            tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelClass.Location = new Point(73, 218);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(33, 15);
            labelClass.TabIndex = 11;
            labelClass.Text = "Class";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(73, 242);
            comboBoxClass.Margin = new Padding(3, 2, 3, 2);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(184, 23);
            comboBoxClass.TabIndex = 10;
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
            labelPass.Location = new Point(445, 148);
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
            labelEmail.Location = new Point(70, 148);
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
            labelID.Location = new Point(445, 70);
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
            labelName.Location = new Point(73, 70);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAdd.Location = new Point(8, 4);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(105, 21);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add Student";
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(buttonDelete);
            tabPageUpdate.Controls.Add(buttonFInd);
            tabPageUpdate.Controls.Add(labelUpClass);
            tabPageUpdate.Controls.Add(comboBoxUpClass);
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
            tabPageUpdate.Size = new Size(799, 380);
            tabPageUpdate.TabIndex = 1;
            tabPageUpdate.Text = "Update Student";
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
            // labelUpClass
            // 
            labelUpClass.AutoSize = true;
            labelUpClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpClass.Location = new Point(73, 226);
            labelUpClass.Name = "labelUpClass";
            labelUpClass.Size = new Size(33, 15);
            labelUpClass.TabIndex = 21;
            labelUpClass.Text = "Class";
            // 
            // comboBoxUpClass
            // 
            comboBoxUpClass.FormattingEnabled = true;
            comboBoxUpClass.Location = new Point(73, 252);
            comboBoxUpClass.Margin = new Padding(3, 2, 3, 2);
            comboBoxUpClass.Name = "comboBoxUpClass";
            comboBoxUpClass.Size = new Size(193, 23);
            comboBoxUpClass.TabIndex = 20;
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
            labelUpPass.Location = new Point(388, 226);
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
            labelUpEmail.Location = new Point(73, 147);
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
            labelUpID.Location = new Point(81, 62);
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
            labelUpName.Location = new Point(388, 147);
            labelUpName.Name = "labelUpName";
            labelUpName.Size = new Size(40, 15);
            labelUpName.TabIndex = 11;
            labelUpName.Text = "Name";
            // 
            // labelUpdate
            // 
            labelUpdate.AutoSize = true;
            labelUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUpdate.Location = new Point(5, 9);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(130, 21);
            labelUpdate.TabIndex = 10;
            labelUpdate.Text = "Update Student";
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlAddStudent";
            Size = new Size(862, 436);
            Load += UserControlAddStudent_Load;
            tabControlAddStudent.ResumeLayout(false);
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddStudent;
        private TabPage tabPageUpdate;
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
        private Label labelUpClass;
        private ComboBox comboBoxUpClass;
        private Button buttonDelete;
        private Button buttonFInd;
        private TabPage tabPageAdd;
        private Label labelClass;
        private ComboBox comboBoxClass;
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
    }
}
