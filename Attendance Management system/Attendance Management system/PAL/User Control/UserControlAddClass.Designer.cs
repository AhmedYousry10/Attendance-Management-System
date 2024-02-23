namespace Attendance_Management_System.Forms
{
    partial class UserControlAddClass
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
            tabControlAddClass = new TabControl();
            tabPageAddClass = new TabPage();
            buttonAdd = new Button();
            labelTeacher = new Label();
            comboBoxTeacher = new ComboBox();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelAdd = new Label();
            tabPageUp = new TabPage();
            buttonDelete = new Button();
            buttonFind = new Button();
            buttonUpdate = new Button();
            labelUpTeacher = new Label();
            comboBoxUpTeacher = new ComboBox();
            textBoxUpID = new TextBox();
            labelUpID = new Label();
            textBoxUpName = new TextBox();
            labelUpName = new Label();
            labelUp = new Label();
            tabControlAddClass.SuspendLayout();
            tabPageAddClass.SuspendLayout();
            tabPageUp.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddClass
            // 
            tabControlAddClass.Alignment = TabAlignment.Bottom;
            tabControlAddClass.Controls.Add(tabPageAddClass);
            tabControlAddClass.Controls.Add(tabPageUp);
            tabControlAddClass.Dock = DockStyle.Fill;
            tabControlAddClass.ItemSize = new Size(76, 22);
            tabControlAddClass.Location = new Point(0, 0);
            tabControlAddClass.Name = "tabControlAddClass";
            tabControlAddClass.SelectedIndex = 0;
            tabControlAddClass.Size = new Size(882, 376);
            tabControlAddClass.TabIndex = 0;
            tabControlAddClass.Selected += tabControlAddClass_Selected;
            // 
            // tabPageAddClass
            // 
            tabPageAddClass.Controls.Add(buttonAdd);
            tabPageAddClass.Controls.Add(labelTeacher);
            tabPageAddClass.Controls.Add(comboBoxTeacher);
            tabPageAddClass.Controls.Add(textBoxID);
            tabPageAddClass.Controls.Add(labelID);
            tabPageAddClass.Controls.Add(textBoxName);
            tabPageAddClass.Controls.Add(labelName);
            tabPageAddClass.Controls.Add(labelAdd);
            tabPageAddClass.Location = new Point(4, 4);
            tabPageAddClass.Margin = new Padding(3, 2, 3, 2);
            tabPageAddClass.Name = "tabPageAddClass";
            tabPageAddClass.Padding = new Padding(3, 2, 3, 2);
            tabPageAddClass.Size = new Size(874, 346);
            tabPageAddClass.TabIndex = 0;
            tabPageAddClass.Text = "Add Class";
            tabPageAddClass.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkSlateBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(459, 197);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(157, 35);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTeacher.Location = new Point(70, 133);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(51, 15);
            labelTeacher.TabIndex = 6;
            labelTeacher.Text = "Teacher";
            // 
            // comboBoxTeacher
            // 
            comboBoxTeacher.FormattingEnabled = true;
            comboBoxTeacher.Location = new Point(70, 158);
            comboBoxTeacher.Margin = new Padding(3, 2, 3, 2);
            comboBoxTeacher.Name = "comboBoxTeacher";
            comboBoxTeacher.Size = new Size(184, 23);
            comboBoxTeacher.TabIndex = 5;
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
            labelID.Location = new Point(443, 68);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(70, 94);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 23);
            textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.Location = new Point(70, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAdd.Location = new Point(5, 2);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(83, 21);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add Class";
            // 
            // tabPageUp
            // 
            tabPageUp.Controls.Add(buttonDelete);
            tabPageUp.Controls.Add(buttonFind);
            tabPageUp.Controls.Add(buttonUpdate);
            tabPageUp.Controls.Add(labelUpTeacher);
            tabPageUp.Controls.Add(comboBoxUpTeacher);
            tabPageUp.Controls.Add(textBoxUpID);
            tabPageUp.Controls.Add(labelUpID);
            tabPageUp.Controls.Add(textBoxUpName);
            tabPageUp.Controls.Add(labelUpName);
            tabPageUp.Controls.Add(labelUp);
            tabPageUp.Location = new Point(4, 4);
            tabPageUp.Margin = new Padding(3, 2, 3, 2);
            tabPageUp.Name = "tabPageUp";
            tabPageUp.Padding = new Padding(3, 2, 3, 2);
            tabPageUp.Size = new Size(817, 346);
            tabPageUp.TabIndex = 1;
            tabPageUp.Text = "Update Class";
            tabPageUp.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(585, 278);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(157, 35);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.DarkSlateBlue;
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonFind.ForeColor = Color.White;
            buttonFind.Location = new Point(339, 86);
            buttonFind.Margin = new Padding(3, 2, 3, 2);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(159, 31);
            buttonFind.TabIndex = 16;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.DarkSlateBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(424, 278);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(157, 35);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelUpTeacher
            // 
            labelUpTeacher.AutoSize = true;
            labelUpTeacher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpTeacher.Location = new Point(82, 178);
            labelUpTeacher.Name = "labelUpTeacher";
            labelUpTeacher.Size = new Size(51, 15);
            labelUpTeacher.TabIndex = 14;
            labelUpTeacher.Text = "Teacher";
            // 
            // comboBoxUpTeacher
            // 
            comboBoxUpTeacher.FormattingEnabled = true;
            comboBoxUpTeacher.Location = new Point(82, 212);
            comboBoxUpTeacher.Margin = new Padding(3, 2, 3, 2);
            comboBoxUpTeacher.Name = "comboBoxUpTeacher";
            comboBoxUpTeacher.Size = new Size(184, 23);
            comboBoxUpTeacher.TabIndex = 13;
            // 
            // textBoxUpID
            // 
            textBoxUpID.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpID.Location = new Point(82, 95);
            textBoxUpID.Margin = new Padding(3, 2, 3, 2);
            textBoxUpID.Name = "textBoxUpID";
            textBoxUpID.Size = new Size(184, 23);
            textBoxUpID.TabIndex = 12;
            // 
            // labelUpID
            // 
            labelUpID.AutoSize = true;
            labelUpID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpID.Location = new Point(82, 70);
            labelUpID.Name = "labelUpID";
            labelUpID.Size = new Size(20, 15);
            labelUpID.TabIndex = 11;
            labelUpID.Text = "ID";
            // 
            // textBoxUpName
            // 
            textBoxUpName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpName.Location = new Point(327, 212);
            textBoxUpName.Margin = new Padding(3, 2, 3, 2);
            textBoxUpName.Name = "textBoxUpName";
            textBoxUpName.Size = new Size(184, 23);
            textBoxUpName.TabIndex = 10;
            // 
            // labelUpName
            // 
            labelUpName.AutoSize = true;
            labelUpName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUpName.Location = new Point(327, 178);
            labelUpName.Name = "labelUpName";
            labelUpName.Size = new Size(40, 15);
            labelUpName.TabIndex = 9;
            labelUpName.Text = "Name";
            // 
            // labelUp
            // 
            labelUp.AutoSize = true;
            labelUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUp.Location = new Point(5, 2);
            labelUp.Name = "labelUp";
            labelUp.Size = new Size(108, 21);
            labelUp.TabIndex = 8;
            labelUp.Text = "Update Class";
            // 
            // UserControlAddClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAddClass);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlAddClass";
            Size = new Size(882, 376);
            Load += UserControlAddClass_Load;
            tabControlAddClass.ResumeLayout(false);
            tabPageAddClass.ResumeLayout(false);
            tabPageAddClass.PerformLayout();
            tabPageUp.ResumeLayout(false);
            tabPageUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControlAddClass;
        private TabPage tabPageAddClass;
        private TabPage tabPageUp;
        private Label labelName;
        private Label labelAdd;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Label labelID;
        private Button buttonAdd;
        private Label labelTeacher;
        private ComboBox comboBoxTeacher;
        private Button buttonDelete;
        private Button buttonFind;
        private Button buttonUpdate;
        private Label labelUpTeacher;
        private ComboBox comboBoxUpTeacher;
        private TextBox textBoxUpID;
        private Label labelUpID;
        private TextBox textBoxUpName;
        private Label labelUpName;
        private Label labelUp;
    }
}
