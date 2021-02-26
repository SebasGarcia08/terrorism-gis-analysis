using System;
using System.Data;
using System.Windows.Forms;

namespace terrorism_gis_analysis.UI
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        public void SetDataSource(DataTable dt)
        {
            this.dataGridView.DataSource = dt;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
