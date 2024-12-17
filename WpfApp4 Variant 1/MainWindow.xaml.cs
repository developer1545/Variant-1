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
using WpfApp4_Variant_1.Properties;


namespace WpfApp4_Variant_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MaterialPage());
            Manager.MainFrame = MainFrame;
            //ImportTours();
            Border.Visibility = Visibility.Hidden;

        }
        private void MouseExitOpt()
        {
            Border.Visibility = Visibility.Hidden;
        }
        private void MouseMoveOpt()
        {
            Border.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                //Manager.MainFrame.GoBack();
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Back.IsEnabled = true;
            }
            else
            {
                //Back.IsEnabled = false;
            }


        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

            MouseMoveOpt();
            // Window newWindow = new Autorized();
            // newWindow.Show();

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            //Manager.MainFrame.Navigate(new HotelsPage());
        }



        private void Account_click(object sender, MouseButtonEventArgs e)
        {
           Window newWindow = new Autorized();
           newWindow.Show();
        }

        private void MouseButtonAccEnter(object sender, MouseEventArgs e)
        {
            Menu.Background = Brushes.DarkGreen;
        }

        private void MouseButtonAccLeave(object sender, MouseEventArgs e)
        {
            Menu.Background = null;

        }

        private void MouseRedEnter(object sender, MouseEventArgs e)
        {
            Red.Background = Brushes.DarkGreen;
        }

        private void MouseRedLeave(object sender, MouseEventArgs e)
        {
            Red.Background = null;
        }

        private void MouseBackEnte(object sender, MouseEventArgs e)
        {
            Back.Background = Brushes.DarkGreen;
        }

        private void MouseBackLeave(object sender, MouseEventArgs e)
        {
            Back.Background = null;
        }

        private void MouseDownGrid(object sender, MouseButtonEventArgs e)
        {
            if (Border.Visibility == Visibility.Visible && e.OriginalSource != Border)
            {
                Border.Visibility = Visibility.Collapsed;
            }
        }

        private void Setting_click(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Setting();
            newWindow.Show();
        }

        private void Exit_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void MouseImageDown(object sender, MouseButtonEventArgs e)
        {
            //Manager.MainFrame.Navigate(new ToursPage());
        }

        private void MouseTextDown(object sender, MouseButtonEventArgs e)
        {
           // Window newWindows = new OOO();
            //newWindows.Show();
        }

        private void VxodEnter(object sender, MouseEventArgs e)
        {
            TextVxod.Background = Brushes.DarkGreen;
        }

        private void LeaveVxod(object sender, MouseEventArgs e)
        {
            TextVxod.Background = null;
        }

        private void SetEnter(object sender, MouseEventArgs e)
        {
            TextSet.Background = Brushes.DarkGreen;
        }

        private void SetLeave(object sender, MouseEventArgs e)
        {
            TextSet.Background = null;
        }

        private void OutEnter(object sender, MouseEventArgs e)
        {
            TextOut.Background = Brushes.DarkGreen;
        }

        private void OutLeave(object sender, MouseEventArgs e)
        {
            TextOut.Background = null;
        }
    }
}