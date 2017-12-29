using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemTreeHelper.ReadAndPrint(@"C:\temp");

            Directory dir = FileSystemTreeHelper.ReadDirectoryTree(@"C:\temp");

            XmlDirectorySerializer serializer = new XmlDirectorySerializer();
            serializer.WriteFile(dir);

        }

      
            
         
                  
    }
}