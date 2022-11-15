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
    public partial class EntranceWindow : Window
    { 
        public EntranceWindow()
        {
            InitializeComponent();
            GetFrame();
            AuthorizationRegistrationFrame.Navigate(new AuthorizationPage());
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
            FrameClass.AutRegiFrameClass = AuthorizationRegistrationFrame;
        }
    }
}
