using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using terrorism_gis_analysis.Model;
using terrorism_gis_analysis.UI;

namespace terrorism_gis_analysis.Controller
{
    public class AppController
    {
        public const string NUMERICAL = "NUMERICAL";
        public const string CATEGORICAL = "CATEGORICAL";
        public const string STRING = "STRING";
        
        private readonly ModelController ModelController;
        private MainForm View;
        
        public AppController(MainForm view)
        {
            this.ModelController = new ModelController();
            this.View = view;
        }

        public string[] ReadAndGetColumns(string filePath)
        {
            ModelController.ReadHeaders(filePath);
            return ModelController.GetHeaders();
        }

        public DataTable ReadAndGetReport(BackgroundWorker bkgWorker, Dictionary<string, string> col2Type)
        {
            ModelController.ReadTable(bkgWorker, col2Type);
            return ModelController.GetDataTable();
        }

        public DataTable GetDataTable()
        {
            return ModelController.GetDataTable();
        }
        
        public FilterMakerForm CreateFiltererMaker()
        {
            Dictionary<string, string> vars2Types = ModelController.GetColumnTypes();
            Dictionary<string, HashSet<string>> col2Categorical = ModelController.GetCol2Categorical();
            return new FilterMakerForm(View, this, vars2Types, col2Categorical);
        }
        
        public bool addStringFilter(string columnName, string param)
        {
            ModelController.AddStringFilter(columnName, param);
            
            DataRow[] QueryRows = ModelController.GetDataTableRows();
            View.ResetMap(QueryRows);
            
            return true; 
        }
        
        public bool addNumberFilter(string columnName, int param1, int param2)
        {
            ModelController.AddNumberFilter(columnName, param1, param2);
            
            DataRow[] QueryRows = ModelController.GetDataTableRows();
            View.ResetMap(QueryRows);
            
            return true; 
        }

        public bool addCategoricalFilter( string columnName, string[] parameters)
        {
            ModelController.AddCategoricalFilter(columnName, parameters);
            
            DataRow[] QueryRows = ModelController.GetDataTableRows();
            View.ResetMap(QueryRows);
            
            return true; 
        }
        
    }
}
