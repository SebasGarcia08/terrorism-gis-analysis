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
        private readonly ModelController MController;
        private MainForm view;
        
        public AppController(MainForm view)
        {
            this.MController = new ModelController();
            this.view = view;
        }

        public string[] ReadAndGetColumns(string filePath)
        {
            MController.ReadHeaders(filePath);
            return MController.GetHeaders();
        }

        public DataTable ReadAndGetReport(BackgroundWorker bkgWorker, Dictionary<string, string> col2Type)
        {
            MController.ReadTable(bkgWorker, col2Type);
            return MController.GetDataTable();
        }

        public DataTable GetDataTable()
        {
            return MController.GetDataTable();
        }
        
        public FilterMakerForm CreateFiltererMaker()
        {
            Dictionary<string, string> vars2Types = MController.GetColumnTypes();
            Dictionary<string, HashSet<string>> col2Categorical = MController.GetCol2Categorical();
            return new FilterMakerForm(vars2Types, col2Categorical);
        }
    }
}
