using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _8_DirectoryManager.Serializers
{
    class BinaryDirectorySerializer : BaseDirectorySerializer
    {
        private BinaryFormatter _formatter;

        public BinaryDirectorySerializer()
        {
            _formatter = new BinaryFormatter();
        }

        public override Directory ReadFile(string path)
        {
            Directory result;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                result = (Directory)_formatter.Deserialize(fs);
            }
            return result;
        }

        public override void WriteFile(Directory directoryToSave)
        {
            string fileName = Path.Combine(directoryToSave.FullName, "folderStructure.dat");

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, directoryToSave);
            }
        }
    }
}
