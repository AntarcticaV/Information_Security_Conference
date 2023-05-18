using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information_Security_Conference.Entity;

namespace Information_Security_Conference.FindImage
{
    internal class FindLogoAction
    {
        public List<LogoModel> Logo { get; set; } = new List<LogoModel>();

        public FindLogoAction()
        {
            var dir = Directory.GetFiles(
                "C:\\Учеба\\Разработка програмных модулей\\Вариант 1\\Сессия 1\\Мероприятия_import", "*.*g");
            using (var bd = new InformationSecurityConferenceEntities1())
            {
                var listAction = bd.Action.ToList();
                foreach (var val in listAction)
                {
                    Logo.Add(new LogoModel(val.IDAction, val.Action1,val.Event.Title,val.Date.Date, SearchFile(dir, val.Logo)));
                }
            }
        }

        public string SearchFile(string[] dir, string name)
        {
            string output = "";
            foreach (var file in dir)
            {
                var file_info = new FileInfo(file);
                if (file_info.Name == name)
                {
                    output = file_info.FullName;
                    break;
                }
            }
            return output;
        }
    }
}
