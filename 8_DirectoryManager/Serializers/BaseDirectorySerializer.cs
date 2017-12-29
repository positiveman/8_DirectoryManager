using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DirectoryManager
{
    abstract class BaseDirectorySerializer : IDirectoryReader, IDirectoryWriter
    {
        public abstract Directory ReadFile(string path);
        public abstract void WriteFile(Directory directoryToSave);
        
    }
}
