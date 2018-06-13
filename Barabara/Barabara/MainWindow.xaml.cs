using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Barabara
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(Height.Text);
            double weight = double.Parse(Weight.Text);

            double hratio = height / 162;
            double head =-1.1968+ 0.229 * hratio * 25.9526 + 0.02604 * weight;
            double chest = -6.14877 + 0.4891 * hratio * 31.431 + 0.27893 * weight;
            double west = -5.70449 + 0.1497 * hratio * 29.2113 + 0.17966 * weight;

            string result = "この人をバラバラにした時、頭の重さは" + head.ToString() + "kgです…" + Environment.NewLine+
                "胸の重さは"+chest.ToString() + "kgです…"+Environment.NewLine +
                "おなかの重さは"+west.ToString()+"kgです…////";
            Result.Text = result;
        }
    }
}
