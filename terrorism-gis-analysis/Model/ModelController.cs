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

        private List<Filter> Filters { set; get; }
        private Report Report { set; get; }

        public ModelController()
        {
            Report = new Report();
            Filters = new List<Filter>();
        }

        public string[] GetHeaders()
        {
            return Report.GetHeaders();
        }

        public string[] ReadHeaders(string FilePath)
        {
            Report.ReadHeaders(FilePath);
            return Report.GetHeaders();
        }

        public void ReadTable(BackgroundWorker bkgWorker, Dictionary<string, string> header2Type)
        {
            Report.InitializeColumnTypes(header2Type);
            Report.ReadTable(bkgWorker);
        }

        public DataRow[] Filter()
        {
            return Report.FilterTable(GetFilterExpression());
        }

        public string GetFilterExpression()
        {
            string exp = "";
            
            for(int i=0; i<Filters.Count; i++)
            {
                if (i < Filters.Count - 1)
                    exp += Filters[i].GetFilterExpression() + " AND ";
                else
                    exp += Filters[i];
            }

            return exp;
        }

        public DataTable GetDataTable()
        {
            return Report.GetDataTable();
        }

        public Dictionary<string, string> GetColumnTypes()
        {
            return Report.ColumnTypes;
        }

        public Dictionary<string, HashSet<string>> GetCol2Categorical()
        {
            return Report.ColumnCategoricalValues;
        }
    }
}
