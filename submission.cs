using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SubmissionApp
{
    public class Submission
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GitHubLink { get; set; }
        public long StopwatchTime { get; set; }

        private static readonly string filePath = "submissions.json";

        public Submission(string name, string email, string phone,
