using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_system;
using Attendance_Management_system.PAL;
using Attendance_Management_System.Forms;
namespace AttendanceManagement.Attendance.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");

        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();

        }

        private void pictureBoxError_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinimize, "Minimize");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string filepath = "C:\\Users\\lap0\\OneDrive\\Desktop\\Main\\attendance-program2\\c#\\AttendanceManagement\\AttendanceManagement\\xml\\SystemData.xml";

            List<Person> allUsers = LoadUsersFromXml(filepath);

            string email = textBoxName.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter email and password");
                return;
            }

            foreach (var user in allUsers)
            {
                if (user.Email == email && user.Password == password)
                {
                    if (user.UserType == "admin")
                    {
                        OpenDashboardForm(user.Name, user.UserType);
                    }
                    else if (user.UserType == "teacher")
                    {
                        OpenTeacherDashboardForm(user.Name, user.UserType);
                    }

                    ClearInputFields();
                    return;
                }
            }

            ShowError();
        }

        private List<User> LoadUsersFromXml(string filepath)
        {
            throw new NotImplementedException();
        }

        private void OpenDashboardForm(string username, string role)
        {
            FormMain dashboard = new FormMain();
            dashboard.Username = username;
            dashboard.Role = role;
            dashboard.ShowDialog();
        }

        private void OpenTeacherDashboardForm(string username, string role)
        {
            Teacher teacherDashboard = new Teacher();
            teacherDashboard.name = username;
            teacherDashboard.Role = role;
            teacherDashboard.ShowDialog();
        }

        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxPassword.Clear();
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxName.Focus();
        }

        private void ShowError()
        {
            pictureBoxError.Show();
            labelError.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}