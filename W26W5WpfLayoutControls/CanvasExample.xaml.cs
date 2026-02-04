using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace W26W5WpfLayoutControls
{
    /// <summary>
    /// Interaction logic for CanvasExample.xaml
    /// </summary>
    public partial class CanvasExample : Window
    {
        public CanvasExample()
        {
            InitializeComponent();
        }

        private void btnShowGridExample_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Owner = this;
            win2.Show();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello " + txtFirstName.Text, "Message", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
                MessageBox.Show("YES clicked");
            else
                MessageBox.Show("NO clicked");
        }
    }
}
