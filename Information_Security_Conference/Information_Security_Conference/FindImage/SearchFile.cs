using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Security_Conference.FindImage
{
    internal class SearchFile
    {
        public string SearchPath(string[] dir, string name)
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
