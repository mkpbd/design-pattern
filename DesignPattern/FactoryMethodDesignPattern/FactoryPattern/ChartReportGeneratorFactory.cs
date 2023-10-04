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
    public class ChartReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new ChartReportGenerator();
        }
    }
    public class TabularReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new TabularReportGenerator();
        }
    }
    public class SummaryReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new SummaryReportGenerator();
        }
    }
}
