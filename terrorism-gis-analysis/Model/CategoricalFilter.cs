using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{

    public class CategoricalFilter : Filter
    {
        private string[] parameters;

        public CategoricalFilter(string columnName, string[] parameters) : base(columnName)
        {
            this.parameters = parameters;
        }

        public new string GetFilterExpression()
        {

            string exp = "(";
               
            for(int i=0; i<parameters.Length; i++)
            {
                string e = parameters[i];

                if (i < parameters.Length - 1)
                {
                    exp += base.columnName + "=" + e + " AND ";
                }
                else
                {
                    exp += base.columnName + "=" + e + ")";
                }

            }

            return exp;
        }

    }

   

}
