using System;
using System.Collections.Generic;
using System.IO;
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
    /// DGridHotels
    /// Manager
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HotelsPage());
            Manager.MainFrame = MainFrame;
            //Manager.MainFrame.Navigate(new HotelsPage());
            //Для TourPage
            ImportTours();
        }

        private void ImportTours()
        {
            var fileData = File.ReadAllLines(@"C:\Users\Dima0\Downloads\ToursApp_correct\import\import до\Туры.txt");
            var images = Directory.GetFiles(@"C:\Users\Dima0\Downloads\ToursApp_correct\import\import до\Туры фото");


            foreach (var line in fileData)
            {
                var data = line.Split('\t');

                var tempTour = new Tours
                {
                    Name = data[0].Replace("\"", " "),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsActual = (data[4] == "0") ? false : true
                };

                foreach (var tourType in data[5].Replace("\"", "").Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = toursEntities.GetContext().Type.ToList().FirstOrDefault(p => p.Name == tourType);
                    if (currentType != null)
                        tempTour.Type.Add(currentType);
                }
                try
                {

                    //tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempTour.Name)));
                    //Не работает, ошибка,  Не удается неявно преобразовать тип "byte[]" в "string"
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                toursEntities.GetContext().Tours.Add(tempTour);

                toursEntities.GetContext().SaveChanges();
            }
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

        private void Btn_tour_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TourPage());

            if(MainFrame.CanGoBack)
            {
                Btn_tour.Visibility = Visibility.Visible;

            }
            
        }
    }
}
