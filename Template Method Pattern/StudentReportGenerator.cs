using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    internal class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Report for student collected");
        }
        protected override void ProcessData()
        {
            Console.WriteLine("Data for student processed");
        }
        protected override void FormatReport()
        {
            Console.WriteLine("Student report formated");
        }
    }
}
