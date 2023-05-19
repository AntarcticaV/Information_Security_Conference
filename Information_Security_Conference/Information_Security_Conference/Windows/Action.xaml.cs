using Information_Security_Conference.Entity;
using Information_Security_Conference.FindImage;
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

namespace Information_Security_Conference.Windows
{
    /// <summary>
    /// Логика взаимодействия для Action.xaml
    /// </summary>
    public partial class Action : Window
    {
        private Entity.Action _Logo;
        public Action(Entity.Action logo)
        {
            InitializeComponent();
            _Logo = logo;
            LoadScreen();
        }

        public void LoadScreen()
        {
            using (var bd = new InformationSecurityConferenceEntities1())
            {
                bd.Organizatory.Load();
                var item = bd.Action.Where(o => o.IDAction == _Logo.IDAction).FirstOrDefault();
                Logo.Source = new BitmapImage(new Uri(item.Path));
                textBlockName.Text = item.Action1;
                textBlockCity.Text = item.Cities.NameCity;
                textBlockData.Text = item.Date.Day+"-"+item.Date.Month+"-"+item.Date.Year;
                textBlockOrganizer.Text = item.Organizatory.Name + " " + item.Organizatory.Surname + " " + item.Organizatory.Patronymic;
            }
        }
    }
}
