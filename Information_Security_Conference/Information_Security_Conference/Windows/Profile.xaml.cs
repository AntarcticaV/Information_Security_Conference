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
using Information_Security_Conference.Entity;

namespace Information_Security_Conference.Windows
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        private Organizatory _org;
        public Profile(Organizatory org)
        {
            InitializeComponent();
            _org = org;
            LoadData();
        }

        private void LoadData()
        {
            TextBlockFSP.Text = _org.Name+" "+ _org.Surname+ " " + _org.Patronymic;
            TextBlockCountry.Text = _org.Countries.Country_name;
            TextBlockDate.Text = _org.Birthdate.Date.ToString();
            TextBlockEmail.Text = _org.Email;
            TextBlockGender.Text = _org.Gender.Title;
            TextBlockIDNumder.Text = _org.UniqueID.ToString();
            TextBlockPhoneNumber.Text = _org.Telephone;
            ImageOrg.Source = new BitmapImage(new Uri(_org.Path));
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBoxPassword_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckBoxPassword.IsChecked == true)
            {
                PasswordBox.IsEnabled = true;
                PasswordBoxCofirm.IsEnabled = true;
            }
            else
            {
                PasswordBox.IsEnabled =false;
                PasswordBoxCofirm.IsEnabled = false;
            }
        }

        private void CheckBoxView_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckBoxView.IsChecked == true)
            {
                PasswordBox.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordBox.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Hidden;
            }
        }
    }
}
