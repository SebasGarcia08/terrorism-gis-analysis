using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace terrorism_gis_analysis.Model
{
    public class ModelController
    {

        private List<Filter> filters;
        private Report report;

        public ModelController()
        {
            report = new Report();
            filters = new List<Filter>();
        }

        public string[] GetHeaders()
        {
            return report.GetHeaders();
        }

        public string[] ReadHeaders(string FilePath)
        {
            report.ReadHeaders(FilePath);
            return report.GetHeaders();
        }

        public void ReadTable(BackgroundWorker bkgWorker, Dictionary<string, string> header2Type)
        {
            report.SetColumTypes(header2Type);
            report.ReadTable(bkgWorker);
        }

        public DataRow[] Filter()
        {
            return report.FilterTable(GetFilterExpression());
        }

        public string GetFilterExpression()
        {
            string exp = "";
            
            for(int i=0; i<filters.Count; i++)
            {
                if (i < filters.Count - 1)
                    exp += filters[i].GetFilterExpression() + " AND ";
                else
                    exp += filters[i];
            }

            return exp;
        }

        public DataTable GetDataTable()
        {
            return report.GetDataTable();
        }
    }
}
