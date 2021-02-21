using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.ComponentModel;
using terrorism_gis_analysis.Model;

namespace terrorism_gis_analysis.Controller
{
    class AppController
    {
        public static readonly string NUMERICAL = "NUMERICAL";
        public static readonly string CATEGORICAL = "CATEGORICAL";
        public static readonly string STRING = "STRING";
        private ModelController MController;

        public AppController()
        {

        }

        public string[] ReadAndGetColumns(string FilePath)
        {
            MController.ReadHeaders(FilePath);
            return MController.GetHeaders();
        }

    }
}
