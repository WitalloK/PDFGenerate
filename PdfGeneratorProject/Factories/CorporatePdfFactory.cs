using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfGeneratorProject.Interfaces;
using PdfGeneratorProject.Models.Corporate;
namespace PdfGeneratorProject.Factories
{
    public class CorporatePdfFactory : IDocumentFactory
    {
        public IHeader CreateHeader() => new CorporateHeader();
        public IBody CreateBody() => new CertificateBody();
    }
}