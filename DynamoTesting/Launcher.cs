using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        public repconLauncher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // Path to program
            string pathToProgram = "C:\\Program Files\\Autodesk\\AutoCAD 2022\\acad.exe";
           // string pathToProgram = "W:\\1_service\\2_environments\\MTQ\\english_software\\c3d_2020_en_mtq.lnk";

            // Make sure the file exists before starting the process
            if (System.IO.File.Exists(pathToProgram))
            {
                // Create a new process start info
                ProcessStartInfo processStartInfo = new ProcessStartInfo(pathToProgram);

                try
                {
                    // Start the process
                    Process.Start(processStartInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error starting external program: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("External program not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}