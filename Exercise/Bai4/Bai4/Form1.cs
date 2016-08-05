using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbgiatri.Visible = false;

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                MessageBox.Show("Vui long nhap dung gia tri cua n");
                return;
            }
            int n = int.Parse(tbSon.Text);
            for (int i = 1; i <=n; i++)
            {
                if (songuyento(i) == 1)
                {
                    tbResult.Text += i.ToString() + ",";
                    
                }
                
            }
            
        }

        public int songuyento(int n)
        {
            int i, dem = 0;
            for (i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    dem += 1;
                }

            }
            if (dem <= 0)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public Boolean Check()
        {   
            bool check = false;
            if (String.IsNullOrEmpty(tbSon.Text) || tbSon.Text.Any(Char.IsLetter))
            {
                check = true;
            }
            return check;
        }


    }
}
