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
using Pizzeria.Models.Human;
using PizzeriaApp.Views;
using PizzeriaApp.Services;

namespace PizzeriaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowService windowService = new MainWindowService();
            this.DataContext = windowService;
        }
        private void launchCommand(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void addClient(object sender, RoutedEventArgs e)
        {
            List<Person> listPerson = new List<Person>();
            Person person = new Person();
            person.Firstname = "vital";
            person.Lastname = "ez,lr";
            person.Address = "lzjr";
            person.ContentMessage = "zf,l";

            listPerson.Add(person);
        }
        private void addCommis(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void addLivreur(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void handleClient(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void handleCommis(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void handleLivreur(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void deleteClient(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void deleteCommis(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello.");
        }
        private void deleteLivreur(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("Hello.");
        }
    }
}
