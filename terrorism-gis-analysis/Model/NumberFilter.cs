using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    public class NumberFilter : Filter
    {
        private int param1;
        private int param2;

        public NumberFilter(string columnName, int param1, int param2) : base(columnName)
        {
            this.param1 = param1;
            this.param2 = param2;
        }

        public new string GetFilterExpression()
        {
            return "(" + base.columnName + " >= " + param1 + " AND " + base.columnName + " <= " + param2 + ")"; 
        }


    }
}
