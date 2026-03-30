using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfGeneratorProject.Interfaces;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGeneratorProject.Models.Certificate
{
    public class CertificateHeader : IHeader
    {
        public void Compose(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text("Certificado de Conclusão - Selo de Autenticidade Digital").FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);
                    col.Item().Text($"{DateTime.Now:dd/MM/yyyy}").FontSize(10);
                });
                row.ConstantItem(100).Height(50).Placeholder();
            });
        }
    }
}