using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrorism_gis_analysis.Model
{
    interface IFilterGenerator
    {
        string GetFilterExpression();

    }
}
