using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    public class Controller
    {

        private Filter[] filters;
        private Report report;

        public Controller()
        {

        }

        public String getFilterExpression()
        {
            string exp = "";
            
            for(int i=0; i<filters.Length; i++)
            {
                if (i < filters.Length - 1)
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
