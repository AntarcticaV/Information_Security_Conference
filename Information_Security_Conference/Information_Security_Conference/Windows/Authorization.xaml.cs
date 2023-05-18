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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        //public bool CaptchaCheck;
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            

            using (var bd = new InformationSecurityConferenceEntities1())
            {
                var user = bd.User.FirstOrDefault(item => item.UniqueID.ToString() == textBoxLogin.Text && item.Password==passwordBox.Password);
                if (user != null)
                {
                    var gg = new Captcha();
                    gg.ShowDialog();
                    if (gg.Check)
                    {
                        switch (user.IDRole)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                var org = new MenuOrganizatory(user);
                                org.Show();
                                this.Close();
                                break;
                            default:
                                textBlockError.Text = "Ну несвязно";
                                break;
                        }
                    }

                }
                else
                {
                    textBlockError.Text = "Неверный логин или пороль";
                }
            }
            
            
        }
    }
}
