using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    public abstract class Filter : IFilterGenerator
    {
        protected string columnName;

        public Filter(string columnName)
        {
            this.columnName = columnName;
            
        }

        public string GetFilterExpression()
        {
            throw new NotImplementedException();
        }
    }

}
