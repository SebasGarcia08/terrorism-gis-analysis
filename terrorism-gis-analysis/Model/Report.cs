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
        private DataTable Table;

        public Dictionary<string, string> ColumnTypes { get; private set;  }
        public Dictionary<string, HashSet<string>> ColumnCategoricalValues { get; }
        private Dictionary<string, char[]> Extension2Sep { get;  }

        private string[] Lines = null;
        private int NumCols;
        private string[] Headers;
        private char[] Separator;

        public Report()
        {
            Table = new DataTable();
            ColumnTypes = new Dictionary<string, string>();
            ColumnCategoricalValues = new Dictionary<string, HashSet<string>>();

            Extension2Sep = new Dictionary<string, char[]>();
            Extension2Sep.Add("csv", new char[] { ','  });
            Extension2Sep.Add("tsv", new char[] { '\t' });
        }

        public void ReadTable(BackgroundWorker bkgWorker)
        {
            string[] Fields;
            DataRow Row;
            double numLines = Lines.GetLength(0);
            double linesRead = 0.0;

            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < NumCols; i++)
            {
                if(ColumnTypes[Headers[i]].Equals(AppController.NUMERICAL))
                    Table.Columns.Add(Headers[i], typeof(double));
                else
                    Table.Columns.Add(Headers[i], typeof(string));
            }

            for (int i = 1; i < Lines.GetLength(0); i++)
            {
                Fields = Lines[i].Split(Separator);
                Row = Table.NewRow();
                for (int f = 0; f < NumCols; f++)
                {
                    if(ColumnTypes[Headers[f]] == AppController.NUMERICAL)
                        Row[f] = Convert.ToDouble(Fields[f], CultureInfo.InvariantCulture);
                    else
                        Row[f] = Fields[f];
                    // Add unique values of Categorical columns
                    if (ColumnTypes[Headers[f]].Equals(AppController.CATEGORICAL))
                        ColumnCategoricalValues[Headers[f]].Add(Fields[f]);
                }
                
                Table.Rows.Add(Row);
                linesRead += 1;
                int progress = (int) Math.Ceiling((linesRead / numLines) * 100);
                bkgWorker.ReportProgress(progress);
            }
        }

        public void ReadHeaders(string FilePath)
        {
            string[] fileAndExtension = FilePath.Split(new char[] { '.' });
            string extension = fileAndExtension[fileAndExtension.Length - 1];
            this.Separator = Extension2Sep[extension];

            this.Table = new DataTable();
            Lines = File.ReadAllLines(FilePath);

            string[] headers = Lines[0].Split(Separator);

            // Lowercase column names
            for (int i = 0; i < headers.GetLength(0); i++)
            {
                headers[i] = headers[i].ToLower();
            }

            this.NumCols = headers.GetLength(0);

            this.Headers = headers;
        }

        public string[] GetHeaders()
        {
            return Headers;
        }

        public DataTable GetDataTable()
        {
            return Table;
        }

        public DataRow[] FilterTable(string filterExpr)
        {
            return Table.Select(filterExpr);
        }

        public void InitializeColumnTypes(Dictionary<string, string> header2Type)
        {
            ColumnTypes = header2Type;
            foreach(string col in header2Type.Keys)
                if(header2Type[col].Equals(AppController.CATEGORICAL))
                    ColumnCategoricalValues.Add(col, new HashSet<string>());
        }
    }
}
