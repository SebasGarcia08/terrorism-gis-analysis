using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using terrorism_gis_analysis.Controller;

namespace terrorism_gis_analysis.UI
{
    public partial class HeaderTypeSelector : Form
    {

        private string name;
        
        public HeaderTypeSelector(string name)
        {
            InitializeComponent();
            this.name = name;
            HeaderName.Text = name;
        }

        public string GetTypeSelected()
        {
            if (RBtnCategorical.Checked)
                return AppController.CATEGORICAL;
            if (RBtnNumerical.Checked)
                return AppController.NUMERICAL;
            else
                return AppController.STRING;
        }

        public bool UseInToolTip()
        {
            return ChBoxToolTip.Checked;
        }

        public string GetName()
        {
            return name;
        }
    }
}
