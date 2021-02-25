using System.Windows.Forms;

namespace terrorism_gis_analysis.UI
{
    public partial class FilterItem : UserControl
    {
        public FilterItem(string filterInformation)
        {
            InitializeComponent();
            FilterInfo.Text = filterInformation;
            Dock = DockStyle.Top;
        }
    }
}