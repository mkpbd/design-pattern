using FactoryMethodDesignPattern.AllInterfaces;
using FactoryMethodDesignPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ClientCodes
{
    //Client Code
    public class DocumentService
    {
        public void ExportDocument(DocumentConverterFactory factory, string inputFile, string outputFile)
        {
            IDocumentConverter converter = factory.CreateConverter();
            converter.Convert(inputFile, outputFile);
        }
    }

}
