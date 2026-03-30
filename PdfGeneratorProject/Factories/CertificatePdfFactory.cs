using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfGeneratorProject.Interfaces;
using PdfGeneratorProject.Models.Certificate;
namespace PdfGeneratorProject.Factories
{
    public class CertificatePdfFactory : IDocumentFactory
    {
        public IHeader CreateHeader() => new CertificateHeader();
        public IBody CreateBody() => new CertificateBody();
    }
}