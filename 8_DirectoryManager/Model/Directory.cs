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
    public class Directory
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute("FullPath")]
        public string FullName { get; set; }
        [XmlArray("SubFolders")]
        public List<Directory> SubDirictories { get; set; }
        [XmlArray("Files")]
        public List<File> Files { get; set; }

        public Directory() { }

        public Directory(DirectoryInfo directory)
        {
            FullName = directory.FullName;
            Name = directory.Name;
            Files = new List<File>();
            SubDirictories = new List<Directory>();
        }

        public void AddFolder(Directory subfolder)
        {
            SubDirictories.Add(subfolder);
        }

        public void AddFile(File file)
        {
            Files.Add(file);
        }
    }
}
