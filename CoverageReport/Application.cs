using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using Microsoft.VisualStudio.Coverage.Analysis;

namespace CoverageReport
{
    public class Application
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage : CoveragerReport.exe \"input_coverage_file.coverage\" \"output_dir\" .");
            }
            string wspath = args[1] + "coverage.xml";
            CoverageInfo coverage = CoverageInfo.CreateFromFile(args[0]);
            DataSet data = coverage.BuildDataSet(null);
            data.WriteXml(wspath );
            data.Dispose();
            coverage.Dispose();
        }
    }
}
