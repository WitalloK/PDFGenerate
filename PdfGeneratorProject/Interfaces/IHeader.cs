using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Infrastructure;

namespace PdfGeneratorProject.Interfaces
{
    public interface IHeader
    {
        void Compose(IContainer container);
    }
}