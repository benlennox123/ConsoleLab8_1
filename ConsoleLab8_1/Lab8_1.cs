using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleLab8_1
{
    class Lab8_1
    {
        static void Main(string[] args)
        {
            string path = @"LabTest";
            FindCatalogList(path);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        public static void FindCatalogList(string path)
        {
            string[] FileList = Directory.GetFiles(path);
            foreach (string FileName in FileList)
            {
                Console.WriteLine("Найден файл: \t{0}", FileName);
            }
            string[] CatalogList = Directory.GetDirectories(path);
            foreach (string CatalogName in CatalogList)
            {
                FindCatalogList(CatalogName);
                Console.WriteLine("Найден каталог: {0}", CatalogName);
            }

        }
    }
}
