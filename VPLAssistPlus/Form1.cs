using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;            // Required for Step 6: Storage
using System.Threading.Tasks; // Required for Step 7: Multithreading
using System.Windows.Forms;

namespace VPLAssistPlus
{
    public partial class Form1 : Form
    {
        // 1. Create a list to hold your student objects
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // 2. The "Add Student" Button logic
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect data from boxes
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string course = cmbCourse.Text;
                double grade = double.Parse(txtGrade.Text);

                // Add to list and update screen
                studentList.Add(new Student(id, name, course, grade));
                UpdateScreen();

                lblStatus.Text = "Status: " + name + " added!";
            }
            catch
            {
                MessageBox.Show("Error: Please check your ID and Grade numbers.");
            }
        }

        // 3. The "Save" Button logic (MULTITHREADING REQUIREMENT)
        private async void btnSave_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Saving to file... (Background Thread)";

            // Task.Run makes this happen on a separate thread so the UI doesn't freeze
            await Task.Run(() =>
            {
                using (StreamWriter sw = new StreamWriter("students.txt"))
                {
                    foreach (var s in studentList)
                    {
                        sw.WriteLine($"{s.Name}|{s.ID}|{s.Course}|{s.Grade}");
                        System.Threading.Thread.Sleep(500); // Wait 0.5 sec per student to show it working
                    }
                }
            });

            lblStatus.Text = "Status: Data saved to students.txt!";
        }

        private void UpdateScreen()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = studentList;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Collect data (WP3: Depth of Knowledge)
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string course = cmbCourse.Text;
                double grade = double.Parse(txtGrade.Text);

                // 2. Use OOP Class (Requirement 2)
                Student s = new Student(id, name, course, grade);
                studentList.Add(s);

                // 3. Update Display (Requirement 1)
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = studentList;

                lblStatus.Text = "Status: Student added!";
            }
            catch
            {
                MessageBox.Show("Error: Please check your ID and Grade format."); // Requirement 7: Error Handling
            }
        }
    }
    }