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
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = toursEntities.GetContext().Hotel.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Hotel));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = DGridHotels.SelectedItems.Cast<Hotel>().ToList();


            // string qustionMessageBoxText = "Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементы?";

            /*
             Открывается окно с надписью "Вы точно хотите удалить эти элементы?" и вариантами действий, Да и Нет
            
            
            */

            string qustionMessageBoxText = "Вы точно хотите удалить эти элементы?";
            string icnMessageBox = "Внимание!!!";

            MessageBoxButton messageBoxButton = MessageBoxButton.YesNo;
            MessageBoxResult messageBoxResult = MessageBox.Show(qustionMessageBoxText, icnMessageBox, messageBoxButton);


            // При нажатии на кнопку "Да" элемент бд удаляется и появляется окно с увемдомлением "Данные удалены!",
            switch (messageBoxResult)
            {
                case MessageBoxResult.Yes:
                    try
                    {
                        toursEntities.GetContext().Hotel.RemoveRange(hotelsForRemoving);
                        toursEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");

                        DGridHotels.ItemsSource = toursEntities.GetContext().Hotel.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    break;
                // Если нажать на кнопку "Нет" элемент не удаляется и появляется окно с увемдомлением "Данные не были удаленыудалены!"
                case MessageBoxResult.No:
                    MessageBox.Show("Данные не были удалены!");
                    break;

            }

            /* else нельзя было добавить
             * 
             * if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементы?", "Внимание!!!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes )
                MessageBox.Show("Данные удалены!"); 
            {
                try
                {
                    ToursAppEntities.GetContext().Hotel.RemoveRange(hotelsForRemoving);
                    ToursAppEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridHotels.ItemsSource = ToursAppEntities.GetContext().Hotel.ToList() ;
                }
                catch ( Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
            } */
        }
        //7 этап прописать https://nationalteam.worldskills.ru/skills/rabota-s-bazoy-dannykh-v-prilozhenii-chtenie-dobavlenie-redaktirovanie-udalenie-dannykh-chast-2/
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                toursEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridHotels.ItemsSource = toursEntities.GetContext().Hotel.ToList();
            }
        }
    }
}
