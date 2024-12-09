using Template_Method_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ReportGenerator studentGenerator = new StudentReportGenerator();
        ReportGenerator courseGenerator = new CourseReportGenerator();
        studentGenerator.GenerateReport();
        courseGenerator.GenerateReport();
    }
}