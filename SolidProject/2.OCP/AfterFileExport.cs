using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public abstract class AfterFileExport
    {
        public abstract void Export(string filePath, DataTable data);
    }

    public class CsvFileExport: AfterFileExport
    {
      public override void Export(string filePath, DataTable data)
        {
            // code logic to export data to export file
        }
    }

    public class JsonFileExport : AfterFileExport
    {
        public override void Export(string filePath, DataTable data)
        {
            // code logic to export data to export to json file
        }
    }
}
