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

namespace ButtonStylesTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxShape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBoxShape.SelectedIndex)
            {
                case 0:
                    buttonStyle.Style = (Style)Application.Current.Resources[""];
                    break;
                case 1:         
                    buttonStyle.Style = (Style)Application.Current.Resources["RoundButton"];
                    break;
                case 2:
                    buttonStyle.Style = (Style)Application.Current.Resources["StarButton"];
                    break;
            }
        }

        private void ComboBoxColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBoxColor.SelectedIndex)
            {
                case 0:
                    buttonStyle.Background = SystemColors.ControlBrush;
                    break;
                case 1:
                    buttonStyle.Background = Brushes.Red;
                    break;
                case 2:
                    buttonStyle.Background = Brushes.Green;
                    break;
                case 3:
                    buttonStyle.Background = Brushes.Blue;
                    break;
            }
        }
    }
}
