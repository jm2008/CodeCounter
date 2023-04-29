using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCounter
{
    public partial class dlgPickProjectType : Form
    {
        public string projectType;
        public string filename;

        public dlgPickProjectType()
        {
            InitializeComponent();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            Hide();
            if (rbtnCS.Checked)
            {
                projectType = "csproj";
                openFileDialog1.Filter = "C# Project Files|*.csproj";
            }
            else if (rbtnvcxproj.Checked)
            {
                projectType = "vcxproj";
                openFileDialog1.Filter = "Visual C++ Project Files|*.vcxproj";
            }

            DialogResult = DialogResult.OK;

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }

            Close();
        }
    }
}
