using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    internal class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Data for course collected");
        }
        protected override void ProcessData()
        {
            Console.WriteLine("Data for course processed");
        }
        protected override void FormatReport()
        {
            Console.WriteLine("Data for course formated");
        }
    }
}
