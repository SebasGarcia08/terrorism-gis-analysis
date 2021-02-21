using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace terrorism_gis_analysis.Model
{
    public class Report
    {
        private DataTable dataTable;
        private Dictionary<string, string> columnTypes;
        private Dictionary<string, string[]> columnCategoricalValues; 

        public Report()
        {
            dataTable = new DataTable();
            columnTypes = new Dictionary<string, string>();
            columnCategoricalValues = new Dictionary<string, string[]>();
        }

        //TODO
        public void readTable(string filePath, BackgroundWorker bkgworker, Dictionary<string, string> header2Type)
        {
            
        }

        //TODO
        public string[] readHeaders()
        {
            string[] a = {""};
            return a; 
        }

    }
}
