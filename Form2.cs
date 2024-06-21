using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace submissionApp
{
    public partial class Form2 : Form
    {
        private List<Submission> submissions;
        private int currentIndex;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize form components
            // Load submissions or initialize data source
            submissions = Submission.GetAllSubmissions(); // Example: Load submissions from backend or file
            currentIndex = 0;
            DisplaySubmission(currentIndex);
        }

        private void DisplaySubmission(int index)
        {
            // Display submission details based on index
            if (index >= 0 && index < submissions.Count)
            {
                var currentSubmission = submissions[index];
                txtName.Text = currentSubmission.Name;
                txtEmail.Text = currentSubmission.Email;
                txtPhoneNumber.Text = currentSubmission.Phone;
                txtGitHubLink.Text = currentSubmission.GitHubLink;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Navigate to previous submission
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = 0;
            }
            DisplaySubmission(currentIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Navigate to next submission
            currentIndex++;
            if (currentIndex >= submissions.Count)
            {
                currentIndex = submissions.Count - 1;
            }
            DisplaySubmission(currentIndex);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard shortcuts
            if (e.Control && e.KeyCode == Keys.Left)
            {
                btnPrevious.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.Right)
            {
                btnNext.PerformClick();
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

        public Submission(string name, string email, string phone, string gitHubLink)
        {
            Name = name;
            Email = email;
            Phone = phone;
            GitHubLink = gitHubLink;
        }

        public static List<Submission> GetAllSubmissions()
        {
            // Implement the logic to get all submissions
            // For example, load from a database or file
            return new List<Submission>(); // Return a list of submissions
        }
    }
}
