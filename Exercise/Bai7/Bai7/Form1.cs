using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai7
{
    public partial class Me : Form
    {
        public Me()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (*.txt)|*.txt|All Files|*.*";
            svf.Title = "Save File As";
            svf.InitialDirectory = "C:";

            DialogResult = svf.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svf.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                this.Text = "Notepad |" + svf.FileName;
                lbpath.Text = "Current Files: "+ svf.FileName ;
            }
        }
    }
}
