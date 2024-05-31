using System;
using System.Windows;
using System.Windows.Controls;

namespace YourNamespace
{
    public partial class MyWpfUserControl : UserControl
    {
        public MyWpfUserControl()
        {
            InitializeComponent();
        }

        private void BtnGiai_Click(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);

            float del = b * b - 4 * a * c;
            double x1 = 0, x2 = 0, x = 0;

            textdel.Text = del.ToString();

            if (del == 0)
            {
                x1 = x2 = -b / (2 * a);
            }
            else if (del < 0)
            {
                MessageBox.Show("Phương trình vô nghiệm!!");
            }
            else
            {
                x1 = (-b + Math.Sqrt(del)) / (2 * a);
                x2 = (-b - Math.Sqrt(del)) / (2 * a);
            }

            txtX1.Text = x1.ToString();
            txtX2.Text = x2.ToString();
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            txtX1.Text = "";
            txtX2.Text = "";
            textdel.Text = "";
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
