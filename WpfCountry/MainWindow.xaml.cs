using CountryLab;
using WpfCountry;
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

namespace WpfCountry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public Model model = new Model();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;

            Closing += model.OnWindowClosing;
        }

        public async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Model.BaseList = await Model.XmlLoadAsync(Model.path);
            Model.ListToCollection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.SearchMonarchyList.Clear();
            Model.SearchKingdomList.Clear();
            Model.SearchRepublicList.Clear();

            model.Search();
            
            MonarchyDataGrid.ItemsSource = Model.SearchMonarchyList;
            KingdomDataGrid.ItemsSource = Model.SearchKingdomList;
            RepublicDataGrid.ItemsSource = Model.SearchRepublicList;
        }
    }
}

      
        