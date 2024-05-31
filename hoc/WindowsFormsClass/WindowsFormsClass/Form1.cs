using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void BtnGiai_click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(textB.Text);
            float c = float.Parse(textC.Text);

            float del = b*b -4*a*c;
            double x1=0, x2=0, x=0;

            textdel.Text = del.ToString();

            if (del == 0)
            {
                x1 = x2 = -b/(2*a);
            }
            else if (del < 0)
            {
                MessageBox.Show("Phuong trinh vo nghiem!!");
            }
            else
            {
                x1 = (-b + (Math.Sqrt(del))) / (2 * a);
                x2 = (-b - (Math.Sqrt(del))) / (2 * a);
            }

            txtX1.Text = x1.ToString(); 
            txtX2.Text = x2.ToString();
        }

        private void BtnXoa_click(object sender, EventArgs e)
        {
            txtX1.Text = "";
            txtX2.Text = "";
            textdel.Text = "";
        }

        private void BtnThoat_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxC_enter(object sender, EventArgs e)
        {
            //Form1.BtnGiai_click();
        }
    }
}
