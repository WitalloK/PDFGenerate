using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Infrastructure;

namespace PdfGeneratorProject.Interfaces
{
    public interface IBody
    {
        void Compose(IContainer container);
    }
}