using System.Collections.Generic;
using System.ComponentModel;

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

        public void ResetFilters()
        {
            Filters = new List<Filter>();
        }
        
        public bool AddStringFilter(string columnName, string param)
        {
            Filters.Add(new StringFilter(columnName, param));
            return true; 
        }
        
        public bool AddNumberFilter(string columnName, int param1, int param2)
        {
            Filters.Add(new NumberFilter(columnName, param1, param2));
            return true; 
        }

        public bool AddCategoricalFilter( string columnName, string[] parameters)
        {
            Filters.Add(new CategoricalFilter(columnName, parameters));

            return true; 
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
                    exp += Filters[i].GetFilterExpression();
            }

            return exp;
        }

        public DataTable GetDataTable()
        {
            return Report.GetDataTable();
        }
        public DataRow[] GetDataTableRows()
        {
            string expression = GetFilterExpression();
            DataRow[] rows = Report.GetDataTable().Select(expression);
            return rows;
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
