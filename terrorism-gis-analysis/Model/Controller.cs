using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    public class Controller
    {

        private List<Filter> filters;
        private Report report;

        public Controller()
        {
            report = new Report();
            filters = new List<Filter>();
        }

        public string[] getHeaders(string filePath)
        {
            return report.readHeaders(filePath);
        }

        public void readTable(BackgroundWorker bkgWorker, Dictionary<string, string> header2Type)
        {
            report.readTable(bkgWorker, header2Type);
        }

        public String getFilterExpression()
        {
            string exp = "";
            
            for(int i=0; i<filters.Count; i++)
            {
                if (i < filters.Count - 1)
                {
                    exp += filters[i].GetFilterExpression() + " AND ";
                }
                else
                {
                    exp += filters[i];
                }
            }

            return exp;

        }


    }
}
