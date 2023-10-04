using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.AllInterfaces
{
    //Product(Interface)
    public interface IReportGenerator
    {
        void GenerateReport(string data);
    }
}
