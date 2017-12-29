using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DirectoryManager
{
    interface IDirectoryWriter
    {
        void WriteFile(Directory directoryToSave);
    }
}
