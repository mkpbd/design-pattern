using FactoryMethodDesignPattern.AllInterfaces;
using FactoryMethodDesignPattern.ConcreateClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.FactoryPattern
{
    //Concrete Creators
    public class PdfConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new PdfConverter();
        }
    }
    public class DocxConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new DocxConverter();
        }
    }
    public class TxtConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new TxtConverter();
        }
    }
}
