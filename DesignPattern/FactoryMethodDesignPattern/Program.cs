using FactoryMethodDesignPattern.ClientCodes;
using FactoryMethodDesignPattern.FactoryPattern;

namespace FactoryMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var notificationSystem = new NotificationSystem();
            //// For a user who prefers email notifications:
            //notificationSystem.NotifyUser(new EmailNotifierFactory(), "This is an email notification!");
            //// For a user who prefers SMS notifications:
            //notificationSystem.NotifyUser(new SMSNotifierFactory(), "This is an SMS notification!");
            //// For a user who prefers push notifications:
            //notificationSystem.NotifyUser(new PushNotifierFactory(), "This is a push notification!");

            //var documentService = new DocumentService();
            //// User wants to export to PDF:
            //documentService.ExportDocument(new PdfConverterFactory(), "source.docx", "output.pdf");
            //// User wants to export to DOCX:
            //documentService.ExportDocument(new DocxConverterFactory(), "source.pdf", "output.docx");
            //// User wants to export to TXT:
            //documentService.ExportDocument(new TxtConverterFactory(), "source.pdf", "output.txt");

            var analyticsService = new AnalyticsService();
            // User wants a Chart report:
            analyticsService.CreateReport(new ChartReportGeneratorFactory(), "ChartData123");
            // User wants a Tabular report:
            analyticsService.CreateReport(new TabularReportGeneratorFactory(), "TabularData456");
            // User wants a Summary report:
            analyticsService.CreateReport(new SummaryReportGeneratorFactory(), "SummaryData789");

        }
    }
}