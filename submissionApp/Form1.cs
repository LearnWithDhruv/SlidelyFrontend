using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace submissionApp
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form components
            // Optional: Load any initial data or configurations
            stopwatch.Reset();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            // Start or stop the stopwatch
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }
            else
            {
                stopwatch.Start();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs and save the submission
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string githubLink = txtGitHubLink.Text;
            long stopwatchTime = stopwatch.ElapsedMilliseconds;

            // Example: Send data to backend or save locally
            // Replace with actual implementation
            Submission submission = new Submission(name, email, phone, githubLink, stopwatchTime);
            submission.Save(); // Assuming Submission class handles saving to backend or file
            MessageBox.Show("Submission saved successfully.");

            // Clear form fields
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtGitHubLink.Text = "";
            stopwatch.Reset();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard shortcuts
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }
        }
    }

    // Assuming you have a Submission class defined somewhere in your project
    public class Submission
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GitHubLink { get; set; }
        public long StopwatchTime { get; set; }

        public Submission(string name, string email, string phone, string githubLink, long stopwatchTime)
        {
            Name = name;
            Email = email;
            Phone = phone;
            GitHubLink = githubLink;
            StopwatchTime = stopwatchTime;
        }

        public void Save()
        {
            // Implement the actual save logic here
            // For example, save to a database or a file
        }
    }
}
