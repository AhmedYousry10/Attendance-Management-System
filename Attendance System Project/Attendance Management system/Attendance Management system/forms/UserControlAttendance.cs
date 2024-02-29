using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Management_system.forms
{

    public partial class UserControlAttendance : UserControl
    {

        public UserControlAttendance()
        {
            InitializeComponent();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected class from the ComboBox
            string selectedClass = comboBoxClass.SelectedItem.ToString();

            // Load the classes XML file
            XmlDocument classesXml = new XmlDocument();
            classesXml.Load(@"..\..\..\Data\classes.xml");

            // Find the class node based on the selected class name
            XmlNode classNode = classesXml.SelectSingleNode($"//Class[Name='{selectedClass}']");

            if (classNode != null)
            {
                // Get the ID of the selected class
                string classId = classNode.SelectSingleNode("ID").InnerText;

                // Get the selected date from the DateTimePicker
                string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                // Load the attendance XML file
                XmlDocument attendanceXml = new XmlDocument();
                attendanceXml.Load(@"..\..\..\Data\attendance.xml");

                // Find the attendance records node for the selected class
                XmlNode classAttendanceNode = attendanceXml.SelectSingleNode($"/attendance/class[@id='{classId}']");

                // Clear existing rows in the DataGridView
                dataGridViewMarkAttendance.Rows.Clear();

                // If the attendance records node for the selected class is found
                if (classAttendanceNode != null)
                {
                    // Get all record nodes under the class node
                    XmlNodeList recordNodes = classAttendanceNode.SelectNodes("record");

                    // Iterate through each record node and check for the matching date
                    foreach (XmlNode recordNode in recordNodes)
                    {
                        string recordDate = recordNode.SelectSingleNode("date").InnerText;

                        // Check if the record date matches the selected date
                        if (recordDate == selectedDate)
                        {
                            string id = recordNode.SelectSingleNode("id").InnerText;
                            string name = recordNode.SelectSingleNode("name").InnerText;
                            bool status = recordNode.SelectSingleNode("status").InnerText == "absent";

                            // Add a new row to the DataGridView
                            dataGridViewMarkAttendance.Rows.Add(id, name, status);
                        }
                    }
                }
            }
        }


        private void tabPageMarkAttendance_Leave(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                // Load the attendance XML file
                XmlDocument attendanceXml = new XmlDocument();
                attendanceXml.Load(@"..\..\..\Data\attendance.xml");

                // Get the class ID based on the selected class in the ComboBox
                string selectedClass = comboBoxClass.SelectedItem.ToString();
                XmlNode classNode = attendanceXml.SelectSingleNode($"//class[record[name='{selectedClass}']]");

                if (classNode != null)
                {
                    // Iterate through DataGridView rows to update attendance status
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        // Get student ID and status from DataGridView
                        string studentId = row.Cells["ID"].Value.ToString();
                        string status = Convert.ToBoolean(row.Cells["Column3"].Value) ? "present" : "absent";

                        // Find the record node for the student in the XML file
                        XmlNode studentRecordNode = classNode.SelectSingleNode($"record[id='{studentId}']");

                        if (studentRecordNode != null)
                        {
                            // Update the status in the XML file
                            XmlNode statusNode = studentRecordNode.SelectSingleNode("status");
                            if (statusNode != null)
                            {
                                statusNode.InnerText = status;
                            }
                        }
                    }

                    // Save the changes back to the XML file
                    attendanceXml.Save(@"..\..\..\Data\attendance.xml");
                }
            }
        }

        //private void dataGridViewMarkAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (comboBoxClass.SelectedIndex != -1)
        //    {
        //        // Load the attendance XML file
        //        XmlDocument attendanceXml = new XmlDocument();
        //        attendanceXml.Load("Data\\attendance.xml");

        //        // Get the class ID based on the selected class in the ComboBox
        //        string selectedClass = comboBoxClass.SelectedItem.ToString();
        //        XmlNode classNode = attendanceXml.SelectSingleNode($"//class[record[name='{selectedClass}']]");

        //        if (classNode != null)
        //        {
        //            // Iterate through DataGridView rows to update attendance status
        //            foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
        //            {
        //                // Get student ID and status from DataGridView
        //                string studentId = row.Cells["ID"].Value.ToString();
        //                string status = Convert.ToBoolean(row.Cells["Column3"].Value) ? "present" : "absent";

        //                // Find the record node for the student in the XML file
        //                XmlNode studentRecordNode = classNode.SelectSingleNode($"record[id='{studentId}']");

        //                if (studentRecordNode != null)
        //                {
        //                    // Update the status in the XML file
        //                    XmlNode statusNode = studentRecordNode.SelectSingleNode("status");
        //                    if (statusNode != null)
        //                    {
        //                        statusNode.InnerText = status;
        //                    }
        //                }
        //            }

        //            // Save the changes back to the XML file
        //            attendanceXml.Save("Data\\attendance.xml");
        //        }

        //    }

        //}

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ComboBox
            comboBoxClass.Items.Clear();

            try
            {
                // Load the classes XML file
                XmlDocument classesXml = new XmlDocument();
                classesXml.Load(@"..\..\..\Data\classes.xml");

                // Select all class nodes
                XmlNodeList classNodes = classesXml.SelectNodes("//Class/Name");

                // Iterate over each class node and add its name to the ComboBox
                foreach (XmlNode classNode in classNodes)
                {
                    comboBoxClass.Items.Add(classNode.InnerText);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while loading or parsing the XML file
                MessageBox.Show("Error loading class data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                // Load the attendance XML file
                XmlDocument attendanceXml = new XmlDocument();
                attendanceXml.Load(@"..\..\..\Data\attendance.xml");

                // Get the class ID based on the selected class in the ComboBox
                string selectedClass = comboBoxClass.SelectedItem.ToString();
                XmlNode classNode = attendanceXml.SelectSingleNode($"//class[record[name='{selectedClass}']]");

                if (classNode != null)
                {
                    // Iterate through DataGridView rows to update attendance status
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        // Get student ID and status from DataGridView
                        string studentId = row.Cells["ID"].Value.ToString();
                        string status = Convert.ToBoolean(row.Cells["Column3"].Value) ? "present" : "absent";

                        // Find the record node for the student in the XML file
                        XmlNode studentRecordNode = classNode.SelectSingleNode($"record[id='{studentId}']");

                        if (studentRecordNode != null)
                        {
                            // Update the status in the XML file
                            XmlNode statusNode = studentRecordNode.SelectSingleNode("status");
                            if (statusNode != null)
                            {
                                statusNode.InnerText = status;
                            }
                        }
                    }

                    // Save the changes back to the XML file
                    attendanceXml.Save(@"..\..\..\Data\attendance.xml");
                }
            }
        }
    }
}
