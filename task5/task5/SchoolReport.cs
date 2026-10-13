
using System;

namespace SchoolSystemTask
{
    // Sealed prevents another class from inheriting from SchoolReport.
    public sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine($"Report Title: {ReportTitle}");
        }
    }
}
