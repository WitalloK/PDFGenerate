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
    public class CorporateHeader : IHeader
    {
        public void Compose(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text("RELATÓRIO CORPORATIVO").FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);
                    col.Item().Text($"{DateTime.Now:dd/MM/yyyy}").FontSize(10);
                });
                row.ConstantItem(100).Height(50).Placeholder();
            });
        }
    }
}