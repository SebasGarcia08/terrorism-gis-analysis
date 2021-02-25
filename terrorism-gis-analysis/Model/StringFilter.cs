using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    public class StringFilter : Filter, IFilterGenerator
    {
        private string param;
        
        public StringFilter(string columnName, string param) : base(columnName)
        {
            this.param = param;
        }

        public override string GetFilterExpression()
        {
            return "(" + base.columnName + " LIKE \'%" + param + "%\')";
        }

    }
}
