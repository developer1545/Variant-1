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

namespace WpfApp4_Variant_1
{
    /// <summary>
    /// Логика взаимодействия для MaterialRed.xaml
    /// </summary>
    public partial class MaterialRed : Window
    {
        private Материал _currentMaterial = new Материал();
        public MaterialRed(Материал selectedMaterial)
        
        {
            InitializeComponent();
            if (selectedMaterial != null)
            {
                _currentMaterial = selectedMaterial;
            }
            DataContext = _currentMaterial;
        }

    

        private void BtnSave_click(object sender, RoutedEventArgs e)
        {
        StringBuilder errors = new StringBuilder();
        if (string.IsNullOrWhiteSpace(_currentMaterial.Тип_материала))
        {
            errors.AppendLine("Укажите Тип материала");
        }
        if (string.IsNullOrWhiteSpace(_currentMaterial.Наименование_материала))
        {
            errors.AppendLine("Укажите название материала");
        }
        if (_currentMaterial.Минимальное_количество == 0 && _currentMaterial.Минимальное_количество == null && _currentMaterial.Минимальное_количество < 0)
        {
            errors.AppendLine("Укажите минимальное количество");
        }
        if (string.IsNullOrWhiteSpace(_currentMaterial.ВсеПоставщики))
        {
            errors.AppendLine("Укажите поставщика(ов)");
        }
        if (errors.Length > 0)
        {
            MessageBox.Show(errors.ToString());
            return;
        }
        if (_currentMaterial.Количество_на_складе == null)
        {
                errors.AppendLine("Укажите количество материала на складе");
        }
        if (_currentMaterial.ID_Материала == 0)
        {
            ModelEntities.GetContext().Материал.Add(_currentMaterial);
        }
        try
        {
            ModelEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация успешно сохранена!");
            Window window = new MaterialRed(null);
            window.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message.ToString());
        }
       }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(1);
        }

        private void Add10_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(10);
        }

        private void Add100_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(100);
        }

        private void Subtract1_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(-1);
        }

        private void Subtract10_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(-10);
        }

        private void Subtract100_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(-100);
        }

        private void UpdateValue(int change)
        {
            if (int.TryParse(ValueTextBox.Text, out int currentValue))
            {
                currentValue += change;
                ValueTextBox.Text = currentValue.ToString();
            }
        }
    }
}
