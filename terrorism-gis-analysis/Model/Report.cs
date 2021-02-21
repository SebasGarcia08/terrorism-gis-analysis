using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.IO;
using terrorism_gis_analysis.Controller;

namespace terrorism_gis_analysis.Model
{
    public class Report
    {
        private DataTable dt;
        private Dictionary<string, string> columnTypes;
        private Dictionary<string, HashSet<string>> columnCategoricalValues;
        private string[] lines = null;
        private int numCols;
        private string[] headers;

        public Report()
        {
            dt = new DataTable();
            columnTypes = new Dictionary<string, string>();
            columnCategoricalValues = new Dictionary<string, HashSet<string>>();
        }

        public void readTable(BackgroundWorker bkgWorker, Dictionary<string, string> header2Type)
        {

            string[] Fields;
            DataRow Row;
            double numLines = lines.GetLength(0);
            double linesRead = 0.0;

            for (int i = 1; i < lines.GetLength(0); i++)
            {
                Fields = lines[i].Split(new char[] { ',' });
                if (Fields.GetLength(0) == numCols)
                {
                    Row = dt.NewRow();
                    for (int f = 0; f < numCols; f++)
                    {
                        Row[f] = Fields[f];
                        
                        // Add unique values of Categorical columns
                        if(columnTypes[headers[f]].Equals(AppController.CATEGORICAL))
                        {
                            HashSet<string> aux = columnCategoricalValues[headers[f]];
                            aux.Add(Fields[f]);
                            columnCategoricalValues[headers[f]] = aux;
                        }
                    }
                        
                    dt.Rows.Add(Row);
                }
                linesRead += 1;
                int progress = (int)Math.Ceiling((linesRead / numLines) * 100);
                bkgWorker.ReportProgress(progress);
            }

            lines = null;
        }

        public string[] readHeaders(string filePath)
        {
            this.dt = new DataTable();
            lines = File.ReadAllLines(filePath);

            string[] headers = lines[0].Split(new char[] { ',' });

            // Lowercase column names
            for (int i = 0; i < headers.GetLength(0); i++)
                headers[i] = headers[i].ToLower();

            this.numCols = headers.GetLength(0);


            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < numCols; i++)
                dt.Columns.Add(headers[i], typeof(string));

            this.headers = headers;

            return headers;
        }

    }
}
