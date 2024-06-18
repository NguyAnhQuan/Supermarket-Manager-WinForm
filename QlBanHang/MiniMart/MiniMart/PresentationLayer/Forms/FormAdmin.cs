using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormAdmin : System.Windows.Forms.Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
