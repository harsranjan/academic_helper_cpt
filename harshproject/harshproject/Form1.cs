using System.Diagnostics;

namespace harshproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\harsh.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void OpenHtmlFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("The specified HTML file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\index.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\index.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\periodic.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\trigo.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\algebra.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\coordinate.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\physics.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\compression tool\\homepage.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string htmlFilePath = "C:\\Users\\snksb\\source\\repos\\harshproject\\harshproject\\CPT project\\index.html"; // Replace with the actual path to your HTML file
            OpenHtmlFile(htmlFilePath);
        }
    }
}