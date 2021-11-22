using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task08_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Защиту от отсутствия папки не предусматриваем
            string path = @"G:\BIM_Automation";            

            Console.WriteLine("Список вложенных папок:");
            string[] dirCommon = Directory.GetDirectories(path);
            string[] dirFolders = new string[dirCommon.Length];
                        

            for (int i = 0; i < dirCommon.Length; i++)
            {
                Console.WriteLine(dirCommon[i]);
                dirFolders[i] = dirCommon[i];
            }

            Console.WriteLine();

            foreach (string folderPath in dirFolders)
            {
                string[] dirFiles = Directory.GetFiles(folderPath);
               
                Console.WriteLine($"Список вложенных файлов в папке {folderPath}:");
                
                foreach (string file in dirFiles)
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine();
            }            
        }
    }
}
