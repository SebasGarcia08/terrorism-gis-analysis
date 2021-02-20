using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public void readData()
        {
            readTable(""); //TODO
            readColumnTypes(""); //TODO
            readColumnCategoricalValues();
        }

        public void readTable(string filePath)
        {

        }

        public void readColumnTypes(string filePath)
        {

        }

        public void readColumnCategoricalValues()
        {

        }


    }
}
