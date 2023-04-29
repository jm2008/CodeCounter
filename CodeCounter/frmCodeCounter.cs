using System;
using System.Windows.Forms;

namespace CodeCounter
{
    public partial class frmCodeCounter : Form
    {
        public frmCodeCounter()
        {
            InitializeComponent();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttnOpenFile.PerformClick();
        }

        private void BttnOpenFile_Click(object sender, EventArgs e)
        {
            dlgPickLanguage dlg = new dlgPickLanguage();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                file = dlg.file;
                language = dlg.language;
                txtFile.Text = dlg.filename;
            }

        }

        private string file;
        private string language;
        private string filename;

        private void BttnCountLines_Click(object sender, EventArgs e)
        {
            switch (language)
            {
                case "C":
                case "C++":
                case "C#":
                case "C/C++ Header":
                    CStyleCounter counter = new CStyleCounter(file);
                    long lines = counter.Count();
                    MessageBox.Show("There are " + lines.ToString() + " lines in this " + language + " source file.", "Results");
                    break;
                case "csproj":
                    csprojReader reader = new csprojReader(filename);
                    long numLines = reader.totalLines();

                    MessageBox.Show("The C# project has " + numLines.ToString() + " lines of code in it.", "Results");
                    break;
                case "vcxproj":
                    VcxprojReader cxReader = new VcxprojReader(filename);
                    long vcxLines = cxReader.TotalLines();

                    MessageBox.Show("The Visual C++ project has " + vcxLines.ToString() + " lines of code in it.", "Results");
                    break;
                default:
                    break;
            }

        }

        private void CountLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttnCountLines.PerformClick();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SupportedLanguagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CodeCounter can count the lines of source code in the following types of source files:\n" +
                "  * C\n  * C++\n  * C#\n  * C/C++ Header", "Supported Languages", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCodeCounter about = new AboutCodeCounter();
            about.ShowDialog();
        }

        private void BttnOpenProject_Click(object sender, EventArgs e)
        {
            dlgPickProjectType pickProjectType = new dlgPickProjectType();
            if (pickProjectType.ShowDialog() == DialogResult.OK)
            {
                // read all the project files and find the total lines
                if (pickProjectType.projectType == "csproj")
                {
                    language = "csproj";
                    filename = pickProjectType.filename;
                    txtFile.Text = filename;
                }
                else if (pickProjectType.projectType == "vcxproj")
                {
                    language = "vcxproj";
                    filename = pickProjectType.filename;
                    txtFile.Text = filename;
                }
            }
        }
    }
}
