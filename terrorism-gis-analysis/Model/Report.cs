using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.IO;
using terrorism_gis_analysis.Controller;
using System.Globalization;

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
        private Dictionary<string, char[]> extension2Sep;
        private char[] separator;

        public Report()
        {
            dt = new DataTable();
            columnTypes = new Dictionary<string, string>();
            columnCategoricalValues = new Dictionary<string, HashSet<string>>();

            extension2Sep = new Dictionary<string, char[]>();
            extension2Sep.Add("csv", new char[] { ','  });
            extension2Sep.Add("tsv", new char[] { '\t' });
        }

        public void ReadTable(BackgroundWorker bkgWorker)
        {
            string[] Fields;
            DataRow Row;
            double numLines = lines.GetLength(0);
            double linesRead = 0.0;

            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < numCols; i++)
            {
                if(columnTypes[headers[i]].Equals(AppController.NUMERICAL))
                    dt.Columns.Add(headers[i], typeof(double));
                else
                    dt.Columns.Add(headers[i], typeof(string));
            }

            for (int i = 1; i < lines.GetLength(0); i++)
            {
                Fields = lines[i].Split(separator);
                Row = dt.NewRow();
                for (int f = 0; f < numCols; f++)
                {
                    if(columnTypes[headers[f]] == AppController.NUMERICAL)
                        Row[f] = Convert.ToDouble(Fields[f], CultureInfo.InvariantCulture);
                    else
                        Row[f] = Fields[f];
                    // Add unique values of Categorical columns
                    if (columnTypes[headers[f]].Equals(AppController.CATEGORICAL))
                        columnCategoricalValues[headers[f]].Add(Fields[f]);
                }
                
                dt.Rows.Add(Row);
                linesRead += 1;
                int progress = (int) Math.Ceiling((linesRead / numLines) * 100);
                bkgWorker.ReportProgress(progress);
            }

            lines = null;
        }

        public void ReadHeaders(string FilePath)
        {
            string[] fileAndExtension = FilePath.Split(new char[] { '.' });
            string extension = fileAndExtension[fileAndExtension.Length - 1];
            this.separator = extension2Sep[extension];

            this.dt = new DataTable();
            lines = File.ReadAllLines(FilePath);

            string[] headers = lines[0].Split(separator);

            // Lowercase column names
            for (int i = 0; i < headers.GetLength(0); i++)
            {
                headers[i] = headers[i].ToLower();
            }

            this.numCols = headers.GetLength(0);

            this.headers = headers;
        }

        public string[] GetHeaders()
        {
            return headers;
        }

        public DataTable GetDataTable()
        {
            return dt;
        }

        public DataRow[] FilterTable(string FilterExpr)
        {
            return dt.Select(FilterExpr);
        }

        public void SetColumTypes(Dictionary<string, string> Header2Type)
        {
            this.columnTypes = Header2Type;
            foreach(string col in Header2Type.Keys)
            {
                if(Header2Type[col].Equals(AppController.CATEGORICAL))
                    columnCategoricalValues.Add(col, new HashSet<string>());
            }
        }

    }
}
