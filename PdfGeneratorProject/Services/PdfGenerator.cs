using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfGeneratorProject.Interfaces;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.IO;

namespace PdfGeneratorProject.Services
{
    public sealed class PdfGenerator
    {
        private static PdfGenerator _instance;
        private static readonly object _lock = new object();
        private readonly string _rootPath;

        private PdfGenerator()
        {
            string baseDir = AppContext.BaseDirectory;

            DirectoryInfo root = new DirectoryInfo(baseDir);
            while (root != null && !File.Exists(Path.Combine(root.FullName, "Program.cs")))
            {
                root = root.Parent;
            }

            _rootPath = root?.FullName ?? baseDir;

            QuestPDF.Settings.License = LicenseType.Community;
        }

        public static PdfGenerator Instance
        {
            get { lock (_lock) return _instance ??= new PdfGenerator(); }
        }

        public void GenerateAndSave(IDocumentFactory factory, string fileName)
        {
            string pdfFolderPath = Path.Combine(_rootPath, "PDF");

            if (!Directory.Exists(pdfFolderPath))
            {
                Directory.CreateDirectory(pdfFolderPath);
            }

            string fullPath = Path.Combine(pdfFolderPath, fileName);

            var header = factory.CreateHeader();
            var body = factory.CreateBody();

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Header().Element(header.Compose);
                    page.Content().Element(body.Compose);
                    page.Footer().AlignCenter().Text(x => x.CurrentPageNumber());
                });
            }).GeneratePdf(fullPath);

            Console.WriteLine($"Documento salvo em: {fullPath}");
        }
    }
}