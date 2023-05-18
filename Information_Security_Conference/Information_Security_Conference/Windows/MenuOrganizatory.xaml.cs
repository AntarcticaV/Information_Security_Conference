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
    /// Логика взаимодействия для MenuOrganizatory.xaml
    /// </summary>
    public partial class MenuOrganizatory : Window
    {
        private User _user;
        public MenuOrganizatory(User user)
        {
            _user = user;
            InitializeComponent();
        }
    }
}
