using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    public class StringFilter : Filter
    {
        private string param;
        
        public StringFilter(string columnName, string param) : base(columnName)
        {
            this.param = param;
        }

        public new string GetFilterExpression()
        {
            return "(" + base.columnName + " LIKE \'%" + param + "\')";
        }

    }
}
