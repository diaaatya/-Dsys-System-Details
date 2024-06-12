using System;
using System.Windows.Forms;

namespace Dsys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSystemDetails();
        }

        private void LoadSystemDetails()
        {
            // Fetch and display system details
            textBoxOS.Text = Environment.OSVersion.ToString();
            textBoxMachineName.Text = Environment.MachineName;
            textBoxUserName.Text = Environment.UserName;
            textBoxCLRVersion.Text = Environment.Version.ToString();
            textBoxSystemDirectory.Text = Environment.SystemDirectory;
            textBoxProcessorCount.Text = Environment.ProcessorCount.ToString();
            textBox64BitOS.Text = Environment.Is64BitOperatingSystem.ToString();
            textBox64BitProcess.Text = Environment.Is64BitProcess.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
