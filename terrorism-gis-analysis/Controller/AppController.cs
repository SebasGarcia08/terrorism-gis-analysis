using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.ComponentModel;

namespace terrorism_gis_analysis.Controller
{
    class AppController
    {
        private DataTable dt;

        public AppController()
        {
        }

        public void ReadCSV(string filePath, BackgroundWorker bkgWorker)
        {
            char[] separator = new char[] { '\t' };

            this.dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            string[] headers = lines[0].Split(separator);

            // Lowercase column names
            for (int i = 0; i < headers.GetLength(0); i++)
                headers[i] = headers[i].ToLower();

            int numCols = headers.GetLength(0);
            string[] Fields;

            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < numCols; i++)
                dt.Columns.Add(headers[i], typeof(string));

            DataRow Row;
            double numLines = lines.GetLength(0);
            double linesRead = 0.0;

            for (int i = 1; i < lines.GetLength(0); i++)
            {
                Fields = lines[i].Split(separator);
                if (Fields.GetLength(0) == numCols)
                {
                    Row = dt.NewRow();
                    for (int f = 0; f < numCols; f++)
                        Row[f] = Fields[f];
                    dt.Rows.Add(Row);
                }
                linesRead += 1;
                int progress = (int) Math.Ceiling((linesRead / numLines) * 100);
                bkgWorker.ReportProgress(progress);
            }

            Console.WriteLine(dt.Select().Length);
        }

        public DataTable GetDataTable()
        {
            return dt;
        }
    }
}
