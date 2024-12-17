﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private Account _currentAccount1 = new Account();
        private string[] massive = { "User", "Admin", "Manager" };
        public Register()
        {
            InitializeComponent();
            DataContext = _currentAccount1;
            ComboBoxAccount.ItemsSource = massive;

        }



        private void Vxod_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentAccount1.Login))
            {
                errors.AppendLine("Укажите логин");
            }
            if (string.IsNullOrWhiteSpace(_currentAccount1.Password))
            {
                errors.AppendLine("Укажите пароль");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentAccount1.Type == "")
            {
                errors.AppendLine("Укажите тип пользователя");
            }
            if (_currentAccount1.Id == 0)
            {
                Users.GetContext().Accounts.Add(_currentAccount1);
            }
            try
            {
                Users.GetContext().SaveChanges();
                MessageBox.Show("Информация успешно сохранена!");
                MessageBox.Show("Новый пользователь создан");
                //Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void VxodPere_click(object sender, MouseButtonEventArgs e)
        {
            Window newWindow = new Autorized();
            newWindow.Show();
        }



        private void MouseEnter(object sender, MouseEventArgs e)
        {
            TextRe.TextDecorations = TextDecorations.Underline;
        }
        private void Block_MouseLeave(object sender, MouseEventArgs e)
        {
            TextRe.TextDecorations = null;
        }
    }

}
