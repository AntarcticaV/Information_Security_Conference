using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Information_Security_Conference.Entity;
using Information_Security_Conference.FindImage;
using Information_Security_Conference.Windows;
using Action = Information_Security_Conference.Windows.Action;

namespace Information_Security_Conference
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private FindLogoAction FindLogoAction { get; set; } = new FindLogoAction();
        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        public MainWindow()
        {
            InitializeComponent();
            
            LoadList();
            LoadCheckBox();
        }

        public void LoadList()
        {
            using (var bd = new InformationSecurityConferenceEntities1())
            {
                //ListAction.Items.Clear();
                var Logo = bd.Action.ToList();
                bd.Event.Load();
                ListAction.ItemsSource = Logo;
            }
        }

        public void LoadCheckBox()
        {
            using (var bd = new InformationSecurityConferenceEntities1())
            {
                var Event= bd.Event.ToList();
                ComboBoxEvent.ItemsSource = Event;
            }
        }

        private void ListAction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (Entity.Action)(ListAction.SelectedItem);
            new Action(item).ShowDialog();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new Authorization().Show();
            this.Close();
        }

        private void ListAction_OnClick(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxEvent.SelectionBoxItem == "" && datePicker.Text == "")
            {
                LoadList();
            }
            if (ComboBoxEvent.SelectionBoxItem != "" && datePicker.Text == "")
            {
                using (var bd = new InformationSecurityConferenceEntities1())
                {
                    //ListAction.Items.Clear();
                    bd.Event.Load();
                    Event gg = (Event)ComboBoxEvent.SelectionBoxItem;
                    var Logo = bd.Action.Where(o => o.Event.Title == gg.Title).ToList();
                    
                    ListAction.ItemsSource = Logo;
                }
            }

            if (ComboBoxEvent.SelectionBoxItem == "" && datePicker.Text != "")
            {
                using (var bd = new InformationSecurityConferenceEntities1())
                {
                    bd.Event.Load();
                    var Logo = bd.Action.Where(o => o.Date == datePicker.SelectedDate).ToList();
                    ListAction.ItemsSource = Logo;
                }
            }

            if (ComboBoxEvent.SelectionBoxItem != "" && datePicker.Text != "")
            {
                using (var bd = new InformationSecurityConferenceEntities1())
                {
                    bd.Event.Load();
                    Event gg = (Event)ComboBoxEvent.SelectionBoxItem;
                    var Logo = bd.Action.Where(o => o.Date == datePicker.SelectedDate && o.Event.Title==gg.Title).ToList();
                    ListAction.ItemsSource = Logo;
                }
            }
        }
    }
}
