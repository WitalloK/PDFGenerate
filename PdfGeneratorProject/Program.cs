using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfGeneratorProject.Services;
using PdfGeneratorProject.Factories;

namespace PdfGeneratorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = PdfGenerator.Instance;

            Console.WriteLine("Sistema de Geração de Documentos Iniciado.\n");

            generator.GenerateAndSave(new CorporatePdfFactory(), "Relatorio_Final.pdf");
            generator.GenerateAndSave(new CertificatePdfFactory(), "Certificado.pdf");

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}