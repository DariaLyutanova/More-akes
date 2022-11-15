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
    public partial class AuthorizationPage : Page
    {
        MainWindow mainWindow = new MainWindow();

        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void RegistrationHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.AutRegiFrameClass.Navigate(new RegistrationPage());
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
        }
    }
}
