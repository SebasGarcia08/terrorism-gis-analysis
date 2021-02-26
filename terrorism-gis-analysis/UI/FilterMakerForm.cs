using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using terrorism_gis_analysis.Controller;
using terrorism_gis_analysis.Model;
using System.Diagnostics;
namespace terrorism_gis_analysis.UI
{
    public partial class FilterMakerForm : Form
    {
        private AppController appController;
        private Dictionary<string, string> Variables2Type;
        private Dictionary<string, HashSet<string>> Col2Categorical;

        // String filter
        private readonly TextBox txtBox;

        // Numerical
        private readonly NumericUpDown numericMin;
        private readonly NumericUpDown numericMax;
        
        // Categorical
        private readonly ComboBox CBoxCategorical;

        string CurrSelection;

        private MainForm MainView;

        public FilterMakerForm(MainForm mainView, AppController appController, Dictionary<string, string> variables2Type, Dictionary<string, HashSet<string>> col2Categorical)
        {
            InitializeComponent();
            numericMin = new NumericUpDown() { Anchor = AnchorStyles.Top, Dock = DockStyle.Top, 
                Minimum = Decimal.MinValue, Maximum =  Decimal.MaxValue};
                
            numericMax = new NumericUpDown() { Anchor = AnchorStyles.Bottom, Dock = DockStyle.Bottom, 
                Minimum = Decimal.MinValue, Maximum =  Decimal.MaxValue};
            
            txtBox = new TextBox() { Anchor = AnchorStyles.Right, Dock = DockStyle.Top};
            
            CBoxCategorical = new ComboBox() { Anchor = AnchorStyles.Right, Dock = DockStyle.Top };
            TopLevel = false;
            Dock = DockStyle.Top;
            Variables2Type = variables2Type;
            Col2Categorical = col2Categorical;
            MainView = mainView;
            this.appController = appController;
        }

        private void BtnAddFilter_Click(object sender, EventArgs e)
        {
            if(CurrSelection != null)
            {
                string column = GetVariableSelected();
                string param;
                string filterInformation;
                if (CurrSelection.Equals(AppController.CATEGORICAL))
                {
                    var idx = CBoxCategorical.SelectedIndex;
                    if (idx != -1)
                    {
                        param = (string) CBoxCategorical.Items[CBoxCategorical.SelectedIndex];
                        CategoricalFilter filter = new CategoricalFilter(column, new string[] { param });
                        filterInformation = column + "\n" + param;
                        MainView.AppendControlToFiltersSidebar(new FilterItem(filterInformation));

                        appController.addCategoricalFilter(column, new string[]{param});
                    }
                }
                else if (CurrSelection.Equals(AppController.STRING))
                {
                    param = txtBox.Text;
                    StringFilter filter = new StringFilter(column, param);
                    filterInformation = column + "\n" + param;
                    MainView.AppendControlToFiltersSidebar(new FilterItem(filterInformation));

                    appController.addStringFilter(column, param);
                } 
                else
                {
                    int min = (int) numericMin.Value;
                    int max = (int) numericMax.Value;
                    NumberFilter filter = new NumberFilter(column, min, max);
                    filterInformation = column + "\n[" + min + "," + max + "]";
                    MainView.AppendControlToFiltersSidebar(new FilterItem(filterInformation));

                    appController.addNumberFilter(column, min, max);
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
            Debug.WriteLine("This is a fucking test");
            UpdateCBoxVariables(AppController.NUMERICAL);
            PnlOptionFilterer.Controls.Clear();
            PnlOptionFilterer.Controls.Add(numericMin);
            PnlOptionFilterer.Controls.Add(numericMax);
            numericMin.Show();
            numericMax.Show();
            CurrSelection = AppController.NUMERICAL;
        }

        private void RBtnCategorical_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCBoxVariables(AppController.CATEGORICAL);
            PnlOptionFilterer.Controls.Clear();
            PnlOptionFilterer.Controls.Add(CBoxCategorical);
            CBoxCategorical.Show();
            CurrSelection = AppController.CATEGORICAL;
        }

        private void UpdateCBoxVariables(string typeName)
        {
            CBoxVariables.Items.Clear();
            CBoxVariables.Text = "";
            foreach (var  col in Variables2Type.Keys)
                if (Variables2Type[col].Equals(typeName))
                    CBoxVariables.Items.Add(col);
        }

        private string GetVariableSelected()
        {
            var idx = CBoxVariables.SelectedIndex;
            if (idx != -1) return CBoxVariables.Items[idx].ToString();
            return null;
        }

        private void CBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrSelection != null && CurrSelection.Equals(AppController.CATEGORICAL))
            {
                var varSelected = GetVariableSelected();
                if (varSelected != null)
                {
                    CBoxCategorical.DataSource = Col2Categorical[varSelected].ToList();
                }
            }
        }

        //TODO - Reset feature  
        private void BtnReset_Click(object sender, EventArgs e)
        {
            appController.ResetFilters();
        }
    }
}
