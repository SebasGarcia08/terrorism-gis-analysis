﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.ComponentModel;

namespace terrorism_gis_analysis.Controller
{
    class AppController
    {
        public static readonly string NUMERICAL;
        public static readonly string CATEGORICAL;
        public static readonly string STRING;

        private DataTable dt;

        public AppController()
        {
        }

        public DataTable GetDataTable()
        {
            return dt;
        }
    }
}
