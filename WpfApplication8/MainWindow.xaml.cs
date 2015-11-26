using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication8
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtDate_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            //popChooseDate.IsOpen = true;
            Pop_xiangji.IsOpen = true;
        }

        private void txtDate1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            popChooseDate1.IsOpen = true;
        }

        private void btn_xiangji_Click(object sender, RoutedEventArgs e)
        {
            Pop_xiangji.IsOpen = true;
        }

        private void btn123_Click(object sender, RoutedEventArgs e)
        {
            Pop_xiangji.IsOpen = false;
        }
    }
}
