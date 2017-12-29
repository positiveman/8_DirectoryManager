using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _8_DirectoryManager
{
    [Serializable]
    public class File
    {
        [XmlIgnore]
        public string FullName { get; set; }
        [XmlAttribute]
        public string Name { get; set; }

        public File() { }

        public File(FileInfo file)
        {
            FullName = file.FullName;
            Name = file.Name;
        }

    }
}
