using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfGeneratorProject.Interfaces;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGeneratorProject.Models.Corporate
{
    public class CertificateBody : IBody
    {
        public void Compose(IContainer container)
        {
            container.PaddingVertical(10).Column(col =>
            {
                col.Spacing(5);
                col.Item().Text("Análise de Resultados").FontSize(14).Underline();
                col.Item().Text(Placeholders.Paragraphs());
            });
        }
    }
}