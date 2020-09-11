using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    public class MediaFile
    {
        private string fileName;
        private string path;

        public string FileName { get => fileName; set => fileName = value; }
        public string Path { get => path; set => path = value; }
    }
}
