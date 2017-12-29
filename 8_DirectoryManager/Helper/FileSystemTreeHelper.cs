using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DirectoryManager
{
    static class FileSystemTreeHelper
    {
        private static int _indent = 0;

        #region Read And Print

        public static void ReadAndPrint(string path)
        {
            Print(ReadDirectoryTree(path));
        }

        public static void Print(Directory directory)
        {
            PrintOwnName(directory.FullName);

            if (directory.SubDirictories.Count > 0)
            {
                _indent++;
                foreach (var subdirectory in directory.SubDirictories)
                {
                    Print(subdirectory);
                }
                _indent--;
            }

            if (directory.Files.Count > 0)
            {
                _indent++;
                foreach (var file in directory.Files)
                {
                    PrintOwnName(file.Name);
                }
                _indent--;

                }
            }

        private static void PrintOwnName(string name)
        {
            for (int i = 0; i < _indent; i++)
            {
                Console.Write("  ");
            }
            Console.Write(name);
            Console.WriteLine();


        }

            #endregion

            #region Tree Processing

            public static Directory ReadDirectoryTree(string path)
            {
            DirectoryInfo root = new DirectoryInfo(path);

            return ProcessDirectory(root);

            }

        private static Directory ProcessDirectory(DirectoryInfo directory)
        {
            Directory currentFolder = new Directory(directory);

            if (directory.GetDirectories().Length > 0)
            {
                foreach (var item in directory.GetDirectories())
                {
                    currentFolder.AddFolder(ProcessDirectory(item));

                }

            }

            if (directory.GetFiles().Length > 0)
            {
                foreach (var item in directory.GetFiles())
                {
                    currentFolder.AddFile(new File(item));
                }

            }

            return currentFolder;
        }

        #endregion

    }

}

