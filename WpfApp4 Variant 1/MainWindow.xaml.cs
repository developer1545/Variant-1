using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4_Variant_1.Properties;


namespace WpfApp4_Variant_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MaterialPage());
            Manager.MainFrame = MainFrame;
            //ImportMaterial();
            Border.Visibility = Visibility.Hidden;

        }
        private void MouseExitOpt()
        {
            Border.Visibility = Visibility.Hidden;
        }
        private void MouseMoveOpt()
        {
            Border.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                //Manager.MainFrame.GoBack();
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Back.IsEnabled = true;
            }
            else
            {
                //Back.IsEnabled = false;
            }


        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

            MouseMoveOpt();
            // Window newWindow = new Autorized();
            // newWindow.Show();

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            //Manager.MainFrame.Navigate(new HotelsPage());
        }



        private void Account_click(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Autorized();
            newWindow.Show();
        }

        private void MouseButtonAccEnter(object sender, MouseEventArgs e)
        {
            Menu.Background = Brushes.DarkGreen;
        }

        private void MouseButtonAccLeave(object sender, MouseEventArgs e)
        {
            Menu.Background = null;

        }

        private void MouseRedEnter(object sender, MouseEventArgs e)
        {
            Red.Background = Brushes.DarkGreen;
        }

        private void MouseRedLeave(object sender, MouseEventArgs e)
        {
            Red.Background = null;
        }

        private void MouseBackEnte(object sender, MouseEventArgs e)
        {
            Back.Background = Brushes.DarkGreen;
        }

        private void MouseBackLeave(object sender, MouseEventArgs e)
        {
            Back.Background = null;
        }

        private void MouseDownGrid(object sender, MouseButtonEventArgs e)
        {
            if (Border.Visibility == Visibility.Visible && e.OriginalSource != Border)
            {
                Border.Visibility = Visibility.Collapsed;
            }
        }

        private void Setting_click(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Setting();
            newWindow.Show();
        }

        private void Exit_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void MouseImageDown(object sender, MouseButtonEventArgs e)
        {
            //Manager.MainFrame.Navigate(new ToursPage());
        }

        private void MouseTextDown(object sender, MouseButtonEventArgs e)
        {
            // Window newWindows = new OOO();
            //newWindows.Show();
        }

        private void VxodEnter(object sender, MouseEventArgs e)
        {
            TextVxod.Background = Brushes.DarkGreen;
        }

        private void LeaveVxod(object sender, MouseEventArgs e)
        {
            TextVxod.Background = null;
        }

        private void SetEnter(object sender, MouseEventArgs e)
        {
            TextSet.Background = Brushes.DarkGreen;
        }

        private void SetLeave(object sender, MouseEventArgs e)
        {
            TextSet.Background = null;
        }

        private void OutEnter(object sender, MouseEventArgs e)
        {
            TextOut.Background = Brushes.DarkGreen;
        }

        private void OutLeave(object sender, MouseEventArgs e)
        {
            TextOut.Background = null;
        }

        public class ByteArrayToImageSourceConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is byte[] byteArray)
                {
                    using (var stream = new MemoryStream(byteArray))
                    {
                        var image = new BitmapImage();
                        image.BeginInit();
                        image.CacheOption = BitmapCacheOption.OnLoad;
                        image.StreamSource = stream;
                        image.EndInit();
                        image.Freeze(); // Замораживание для использования в разных потоках
                        return image;
                    }
                }
                return null;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }        
        /*private void ImportMaterial()
        {
            // Путь к папке с изображениями
            var imagesDirectory = @"C:\Users\antom\OneDrive\Рабочий стол\2024-2025\УП.01.01\Variant 1";
            var images = Directory.GetFiles(imagesDirectory);

            // Получаем все материалы из базы данных
            var materials = ModelEntities.GetContext().Материал.ToList();

            foreach (var material in materials)
            {
                // Проверяем, заполнено ли поле изображения
                if (material.Изображение_материала == null) // или пустая строка, если используется строковый тип
                {
                    // Находим файл изображения для данного материала
                    var imagePath = images.FirstOrDefault(img => img.Contains(material.Наименование));

                    if (imagePath != null)
                    {
                        try
                        {
                            // Читаем файл изображения в байты
                            material.Изображение_материала = File.ReadAllBytes(imagePath);

                            // Сохраняем изменения в базе данных
                            ModelEntities.GetContext().SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при обработке материала {material.Наименование}: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Изображение для материала {material.Наименование} не найдено.");
                    }
                }
            } */

        /* private void ImportMaterial()
         {
             var fileData = File.ReadAllLines(@"C:\Users\antom\OneDrive\Рабочий стол\2024-2025\УП.01.01\Variant 1\materials_k_import.txt");
             var images = Directory.GetFiles(@"C:\Users\antom\OneDrive\Рабочий стол\2024-2025\УП.01.01\Variant 1");

             foreach (var line in fileData)
             {
                 var data = line.Split('\t');

                 var tempMaterial = new Материал
                 {
                     ID_Поставщика = Int32.Parse(data[0]),
                     Наименование = Convert.ToString(data[1]),
                     Тип_материала = Convert.ToString(data[2]),
                     Возможные_поставщики = Convert.ToString(data[3]),
                     Количество_в_упаковке = Int32.Parse(data[4]),
                     Единица_измерения = Convert.ToString(data[5]),
                     Количество_на_складе = Int32.Parse(data[6]),
                     Минимальное_допустимое_количество = Int32.Parse(data[7]),
                     Описание = Convert.ToString(data[8]),

                     Стоимость_сырья = decimal.Parse(data[10]),
                     История_изменениний = Convert.ToString(data[11]),





                 };
                 try
                 {
                     tempMaterial.Изображение_материала = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempMaterial.Наименование)));
                 }
                 catch (Exception ex) { Console.WriteLine(ex.Message); }

                 ModelEntities.GetContext().Материал.Add(tempMaterial);
                 ModelEntities.GetContext().SaveChanges();
             }

                 /*foreach (var TypeOfMaterial in data[2].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                 {
                     var currentType = ModelEntities.GetContext().Материал.ToList().FirstOrDefault(p => p.Наименование == TypeOfMaterial);
                     if (currentType != null)
                     {
                         tempMaterial.М.Add(currentType);
                     }
                 */



    }
    }


