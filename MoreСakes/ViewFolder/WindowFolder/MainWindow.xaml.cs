using MoreСakes.AppDataFolder.ClassFolder;
using MoreСakes.ViewFolder.PageFolder;
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
using System.Windows.Shapes;

namespace MoreСakes.ViewFolder.WindowFolder
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            GetFrame();
            MainFrame.Navigate(new MainPage());
            MainToggleButton.IsChecked = true;
        }

        #region Управление окном
        private void SpaseBarGrid_MouseDown(object sender, MouseButtonEventArgs e) // Для того, что бы окно перетаскивать
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) // Для того, что бы закрыть окно
        {
            Application.Current.Shutdown();
        }

        private void RollUpButton_Click(object sender, RoutedEventArgs e) // Для того, чтобы свернуть окно
        {
            WindowState = WindowState.Minimized;
        }
        #endregion

        public void GetFrame()
        {
            FrameClass.MainFrameClass = MainFrame;
        }
        private void MainToggleButton_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrameClass.Navigate(new MainPage());
            MainToggleButton.IsChecked = true;
            SettingsToggleButton.IsChecked = false;
            ImToggleButton.IsChecked = false;
        }

        private void SettingsToggleButton_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrameClass.Navigate(new SettingsPage());
            MainToggleButton.IsChecked = false;
            SettingsToggleButton.IsChecked = true;
            ImToggleButton.IsChecked = false;
        }

        private void ImToggleButton_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrameClass.Navigate(new ImPage());
            MainToggleButton.IsChecked = false;
            SettingsToggleButton.IsChecked = false;
            ImToggleButton.IsChecked = true;
        }
    }
}
