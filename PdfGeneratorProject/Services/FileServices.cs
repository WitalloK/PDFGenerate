using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PdfGeneratorProject.Services
{
    public class FileService
    {
        public void SaveToFile(string fileName, string content)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            File.WriteAllText(path, content);
            Console.WriteLine($"Arquivo salvo em: {path}");
        }
    }
}