﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    internal abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }
        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();
        private void ExportReport()
        {
            Console.WriteLine("Report sended");
        }
    }
}
