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
using terrorism_gis_analysis.Model;


namespace terrorism_gis_analysis.UI
{
    public partial class FilterMakerForm : Form
    {
        private Dictionary<string, string> Variables2Type;
        private Dictionary<string, HashSet<string>> Col2Categorical;
        private Filter filter;
        
        // String filter
        TextBox txtBox;

        // Numerical
        NumericUpDown min;
        NumericUpDown max;

        // Categorical
        ComboBox CBoxCategorical;

        string CurrSelection;

        public FilterMakerForm()
        {
            InitializeComponent();
            this.min = new NumericUpDown() { Dock = DockStyle.Left };
            this.max = new NumericUpDown() { Dock = DockStyle.Right };
            this.txtBox = new TextBox();
            this.CBoxCategorical = new ComboBox();
        }

        public void SetVAriables(Dictionary<string, string> vars, Dictionary<string, HashSet<string>> Col2Categorical)
        {
            this.Variables2Type = vars;
            this.Col2Categorical = Col2Categorical;
        }

        private void BtnAddFilter_Click(object sender, EventArgs e)
        {
            if(CurrSelection != null)
            {
                if (CurrSelection.Equals(AppController.CATEGORICAL))
                {
                    
                } else if (CurrSelection.Equals(AppController.STRING))
                {

                } else
                {

                }
            }
        }

        private void RBtnString_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCBoxVariables(AppController.STRING);
            PnlOptionFilterer.Controls.Clear();
            PnlOptionFilterer.Controls.Add(txtBox);
            txtBox.Show();
            CurrSelection = AppController.STRING;
        }

        private void RBtnNumerical_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCBoxVariables(AppController.NUMERICAL);
            PnlOptionFilterer.Controls.Clear();
            PnlOptionFilterer.Controls.Add(min);
            PnlOptionFilterer.Controls.Add(max);
            min.Show();
            max.Show();
            CurrSelection = AppController.NUMERICAL;
        }

        private void RBtnCategorical_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCBoxVariables(AppController.CATEGORICAL);
            CBoxCategorical.DataSource = Col2Categorical[GetVariableSelected()].ToList();
            CurrSelection = AppController.CATEGORICAL;
        }

        public void UpdateCBoxVariables(string typeName)
        {
            CBoxVariables.Items.Clear();
            foreach (string col in Variables2Type.Keys)
                if (Variables2Type[col].Equals(typeName))
                    CBoxVariables.Items.Add(col);
        }

        private string GetVariableSelected()
        {
            return CBoxVariables.Items[CBoxVariables.SelectedIndex].ToString();
        }
    }
}
