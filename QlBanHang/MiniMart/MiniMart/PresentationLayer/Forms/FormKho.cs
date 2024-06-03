using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMart.PresentationLayer.Form
{
    public partial class FormKho : System.Windows.Forms.Form
    {
        public FormKho()
        {
            InitializeComponent();

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
