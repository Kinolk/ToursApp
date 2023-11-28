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


namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// 
    /// https://nationalteam.worldskills.ru/skills/rabota-s-bazoy-dannykh-v-prilozhenii-chtenie-dobavlenie-redaktirovanie-udalenie-dannykh-chast-1/
    /// 6.Подтип
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HotelsPage());
            Manager.MainFrame = MainFrame;
            //Manager.MainFrame.Navigate(new HotelsPage());
          
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Btn_Back.Visibility = Visibility.Visible;

            }
            else
            {
                Btn_Back.Visibility= Visibility.Hidden;
            }
        }
    }
}
