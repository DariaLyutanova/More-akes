using MoreСakes.AppDataFolder.ClassFolder;
using MoreСakes.ViewFolder.WindowFolder;
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

namespace MoreСakes.ViewFolder.PageFolder
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            if (PersonalDataCheckBox.IsChecked == true)
            {
                RegistrationButton.IsEnabled = true;
                RegistrationButton.BorderBrush = Brushes.White;
                RegistrationButton.Foreground = Brushes.White;
            }
            else
            {
                RegistrationButton.IsEnabled = false;
                RegistrationButton.BorderBrush = Brushes.Gray;
                RegistrationButton.Foreground = Brushes.Gray;
            }
        }

        private void NextHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.AutRegiFrameClass.Navigate(new AuthorizationPage());
        }

        private void PersonalDataHyperlink_Click(object sender, RoutedEventArgs e)
        {
            PersonalDataWindow personalDataWindow = new PersonalDataWindow();
            personalDataWindow.ShowDialog();
        }
    }
}
