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

namespace WikiEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var content = tbxContent.Text;
            if (string.IsNullOrEmpty(content))
            {
                return;
            }

            string[] lines = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrEmpty(lines[i]))
                {
                    lines[i] += @"\\";
                }
            }

            tbxContent.Text = string.Join("\r\n", lines);
        }
    }
}
