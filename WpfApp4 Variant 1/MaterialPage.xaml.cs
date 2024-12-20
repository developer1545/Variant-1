using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp4_Variant_1
{
    /// <summary>
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        public ObservableCollection<BitmapImage> Images { get; set; }
        public MaterialPage()
        {
            InitializeComponent();
            var allTypes = ModelEntities.GetContext().Материал.ToList();
    
            CheckActual.IsChecked = true;
            ComboType.ItemsSource = allTypes;
            ComboType.SelectedIndex = 0;
         
            UpdateMaterial();
            DataContext = this;
            //Manager.MainFrame.Navigate(new RedMaterPage());
        }
      
        private void UpdateMaterial()
        {
            
            var currentTours = ModelEntities.GetContext().Материал.ToList();
            
            currentTours = currentTours.Where(p => p.Наименование_материала.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            currentTours = ModelEntities.GetContext().Материал.ToList();
    
            LViewTours.ItemsSource = currentTours.OrderBy(p => p.Количество_на_складе).ToList();

        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateMaterial();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMaterial();
        }

        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {
            UpdateMaterial();
        }

        private void ButtonRedClick(object sender, RoutedEventArgs e)
        {
           Window window = new MaterialRed((sender as Button).DataContext as Материал);
           window.Show();
          
        }
    }
}
