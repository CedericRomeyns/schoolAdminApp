using Cedric_oma_app.MVVM.View;
using System.Windows;

namespace Cedric_oma_app
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

        #region Window-Buttons
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }
        #endregion

        #region Menu-Buttons
        private void HomeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new HomeView();
        }
        private void OverzichtRadioButton_Checked(object sender, RoutedEventArgs e)
        {
         MainContentControl.Content = new OverzichtView();
        }
        private void StudentenRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new StudentenView();
        }
        #endregion







    }
}