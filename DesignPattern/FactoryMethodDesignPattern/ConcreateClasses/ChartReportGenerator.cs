using FactoryMethodDesignPattern.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreateClasses
{
    // Concrete Products
    public class ChartReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Chart Report with data: {data}");
            // Actual logic to generate a chart report...
        }
    }
    public class TabularReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Tabular Report with data: {data}");
            // Actual logic to generate a tabular report...
        }
    }
    public class SummaryReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Summary Report with data: {data}");
            // Actual logic to generate a summary report...
        }
    }
}
