using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGeneratorProject.Interfaces
{
    public interface IDocumentFactory
    {
        IHeader CreateHeader();
        IBody CreateBody();
    }
}