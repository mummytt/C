using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you want to exit program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.Filter = "Text Files (*.txt)|*.txt|All Files|*.*";
            odf.Title = "Open File";
            odf.InitialDirectory = "C:";
            odf.RestoreDirectory = true;

            DialogResult = odf.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(odf.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                lbpath.Text = odf.FileName.ToString();
                this.Text = "Notepad |" + odf.FileName;
            }
        }
    }
}
