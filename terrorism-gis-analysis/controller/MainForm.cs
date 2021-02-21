using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace terrorism_gis_analysis
{
    public partial class MainForm : Form
    {
        public readonly String TABLE = "Table";
        public readonly String MAP = "Map";
        public readonly String CHARTS = "Charts";
        private DataTable dataTable;

        public MainForm()
        {
            dataTable = new DataTable();
            InitializeComponent();
        }

        private void CBoxChangePanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedField = (string) CBoxChangePanel.SelectedItem;
            if (selectedField.Equals(MAP))
            {
                MapForm mapForm = new MapForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadForm(this.PanelFormLoader, mapForm);
            }
            else if (selectedField.Equals(CHARTS))
            {
                ChartsForm chartsForm = new ChartsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadForm(this.PanelFormLoader, chartsForm);
            }
            else if (selectedField.Equals(TABLE))
            {
                TableForm tableForm = new TableForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadForm(this.PanelFormLoader, tableForm);
            }
        }

        private void LoadForm(Panel panel, Form form)
        {
            panel.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);
            form.Show();
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ReadData(openFileDialog.FileName);
                CBoxChangePanel.Items.Add(MAP);
                CBoxChangePanel.Items.Add(CHARTS);
                CBoxChangePanel.Items.Add(TABLE);
            }
            else
            {

            }
        }

        public void ReadData(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[] headers = lines[0].Split(new char[] { ',' });
            
            // Lowercase column names
            for (int i = 0; i < headers.GetLength(0); i++)
                headers[i] = headers[i].ToLower();

            int numCols = headers.GetLength(0);
            string[] Fields;

            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < numCols; i++)
                dataTable.Columns.Add(headers[i], typeof(string));

            DataRow Row;
            for (int i = 1; i < lines.GetLength(0) - 5; i++)
            {
                Fields = lines[i].Split(new char[] { ',' });
                if (Fields.GetLength(0) == numCols)
                {
                    Row = dataTable.NewRow();
                    for (int f = 0; f < numCols; f++)
                    {
                        Row[f] = Fields[f];
                    }
                    dataTable.Rows.Add(Row);
                }
            }
        }

    }
}
