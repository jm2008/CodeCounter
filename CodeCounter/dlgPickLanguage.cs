using System;
using System.IO;
using System.Windows.Forms;

namespace CodeCounter
{
    public partial class dlgPickLanguage : Form
    {
        public dlgPickLanguage()
        {
            InitializeComponent();
        }

        

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string file;
        public string language;
        public string filename;

        private void bttnOK_Click(object sender, EventArgs e)
        {
            // hide the dialog
            Hide();

            DialogResult = DialogResult.OK;

            // use the open file dialog to open the file
            if (rbtnC.Checked)
            {
                openFileDialog1.Filter = "C Source files|*.c";
                language = "C";
            }
            else if (rbtnCpp.Checked)
            {
                openFileDialog1.Filter = "C++ Source files|*.cpp;*.cxx;*.c++;*.C";
                language = "C++";
            }
            else if (rbtnCSharp.Checked)
            {
                openFileDialog1.Filter = "C# Source files|*.cs";
                language = "C#";
            }
            else if (rbtnHeader.Checked)
            {
                openFileDialog1.Filter = "C/C++ Header files|*.h;*.hpp";
                language = "C/C++ Header";
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string file = streamReader.ReadToEnd();
                streamReader.Close();
                this.file = file;
                filename = openFileDialog1.FileName;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

            Close();
        }
    }
}
