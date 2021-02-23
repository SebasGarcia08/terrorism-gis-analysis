using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.ComponentModel;
using terrorism_gis_analysis.Model;
using terrorism_gis_analysis.UI;

namespace terrorism_gis_analysis.Controller
{
    class AppController
    {
        public const string NUMERICAL = "NUMERICAL";
        public const string CATEGORICAL = "CATEGORICAL";
        public const string STRING = "STRING";
        
        private readonly ModelController Model;
        private MainForm View;
        
        public AppController(MainForm view)
        {
            this.Model = new ModelController();
            this.View = view;
        }

        public string[] ReadAndGetColumns(string filePath)
        {
            Model.ReadHeaders(filePath);
            return Model.GetHeaders();
        }

        public DataTable ReadAndGetReport(BackgroundWorker bkgWorker, Dictionary<string, string> col2Type)
        {
            Model.ReadTable(bkgWorker, col2Type);
            return Model.GetDataTable();
        }

        public DataTable GetDataTable()
        {
            return Model.GetDataTable();
        }
        
        public FilterMakerForm CreateFiltererMaker()
        {
            Dictionary<string, string> vars2Types = Model.GetColumnTypes();
            Dictionary<string, HashSet<string>> col2Categorical = Model.GetCol2Categorical();
            return new FilterMakerForm(View, vars2Types, col2Categorical);
        }
    }
}
