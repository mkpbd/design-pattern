using FactoryMethodDesignPattern.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreateClasses
{
    // Concrete Products
    public class PdfConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to PDF and saving as {outputFile}.");
            // Actual PDF conversion logic goes here...
        }
    }

    public class DocxConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to DOCX and saving as {outputFile}.");
            // Actual DOCX conversion logic goes here...
        }
    }
    public class TxtConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to TXT and saving as {outputFile}.");
            // Actual TXT conversion logic goes here...
        }
    }

}
