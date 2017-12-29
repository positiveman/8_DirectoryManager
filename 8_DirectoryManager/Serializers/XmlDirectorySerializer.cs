using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _8_DirectoryManager
{
    class XmlDirectorySerializer : BaseDirectorySerializer
    {
        private XmlSerializer _serializer;

        public XmlDirectorySerializer()
        {
            _serializer = new XmlSerializer(typeof(Directory));
        }

        public override Directory ReadFile(string path)
        {
            Directory result;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                result = (Directory)_serializer.Deserialize(fs);
            }
            return result;
        }

        public override void WriteFile(Directory directoryToSave)
        {
            string fileName = Path.Combine(directoryToSave.FullName, "folderStructure.xml");

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _serializer.Serialize(fs, directoryToSave);
            }
        }

    }
}
