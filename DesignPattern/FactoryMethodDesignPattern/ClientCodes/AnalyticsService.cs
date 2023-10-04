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
    public class AnalyticsService
    {
        public void CreateReport(ReportGeneratorFactory factory, string data)
        {
            IReportGenerator reportGenerator = factory.CreateReportGenerator();
            reportGenerator.GenerateReport(data);
        }
    }
}
