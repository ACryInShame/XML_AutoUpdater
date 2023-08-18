using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_AutoUpdater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FinishLabel.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TargetFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Folders|no_extension";
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select Folder";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    MessageBox.Show($"Selected folder: {selectedFolder}");
                    SelectedTargetFolder.Text = selectedFolder;
                }
            }
        }

        private void SelectedTargetFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if(SelectedTargetFolder.Text != "")
            {
                AutoUpdateXmlElements.AutoUpdateXML(SelectedTargetFolder.Text);
                FinishLabel.Text = "Finished";
            }
            else
            {
                FinishLabel.Text = "No Target Folder Selected";
            }

        }
    }
}
