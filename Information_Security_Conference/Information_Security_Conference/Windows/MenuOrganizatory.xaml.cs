using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для MenuOrganizatory.xaml
    /// </summary>
    public partial class MenuOrganizatory : Window
    {
        private User _user;
        private Organizatory _org;
        public MenuOrganizatory(User user)
        {
            _user = user;
            InitializeComponent();
            SearchOrg();
        }

        private void SearchOrg()
        {
            using (var bd = new InformationSecurityConferenceEntities1())
            {
                bd.Gender.Load();
                bd.Countries.Load();
                var nowDate = DateTime.Now.TimeOfDay;
                _org = bd.Organizatory.FirstOrDefault(o => o.UniqueID == _user.UniqueID);
                ImageOrg.Source = new BitmapImage(new Uri(_org.Path));
                if (nowDate.Hours >= 9 && nowDate.Hours <= 11)
                {
                    if (_org.IDGender == 2)
                        TextBlockHello.Text += "Утро Мисис " + _org.Surname.ToString() + " " + _org.Name.ToString();
                    if( _org.IDGender == 1)
                        TextBlockHello.Text += "Утро Мистор " + _org.Surname.ToString() + " " + _org.Name.ToString();
                }
                if (nowDate.Hours >= 11 && nowDate.Hours <= 18)
                {
                    if (_org.IDGender == 2)
                        TextBlockHello.Text += "Дкнь Мисис " + _org.Surname.ToString() + " " + _org.Name.ToString();
                    if (_org.IDGender == 1)
                        TextBlockHello.Text += "Дунь Мистор " + _org.Surname.ToString() +" "+ _org.Name.ToString();
                }
                if (nowDate.Hours >= 18 && nowDate.Hours <= 24)
                {
                    if (_org.IDGender == 2)
                        TextBlockHello.Text += "Вечер Мисис " + _org.Surname.ToString() + " " + _org.Name.ToString();
                    if (_org.IDGender == 1)
                        TextBlockHello.Text += "Вечер Мистор " + _org.Surname.ToString() + " " + _org.Name.ToString();
                }
            }
        }

        private void ButtonProfile_Click(object sender, RoutedEventArgs e)
        {
            var gg = new Profile(_org);
            gg.ShowDialog();
        }
    }
}
