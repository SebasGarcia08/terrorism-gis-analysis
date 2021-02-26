using System.Windows.Forms;

namespace terrorism_gis_analysis.UI
{
    public partial class FilterItemsPanel : Form
    {
        public FilterItemsPanel()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Bottom;
            AutoSize = true;
            Height = 300;
        }

        public void AddFilterCard(FilterItem filterItem)
        {
            PnlFilters.Controls.Add(filterItem);
            filterItem.BringToFront();
            filterItem.Show();
        }

        public void RemoveFilters()
        {
            PnlFilters.Controls.Clear();
        }
    }
}