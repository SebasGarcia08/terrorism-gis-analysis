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
using terrorism_gis_analysis.Controller;

namespace terrorism_gis_analysis
{
    public partial class MainForm : Form
    {
        public readonly String TABLE = "Table";
        public readonly String MAP = "Map";
        public readonly String CHARTS = "Charts";

        private AppController Controller;

        public MainForm()
        {
            InitializeComponent();
            this.Controller = new AppController();
        }
        
        private void CBoxChangePanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedField = (string) CBoxChangePanel.SelectedItem;
            if (selectedField.Equals(MAP))
            {
                MapForm mapForm = new MapForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadForm(mapForm);
            }
            else if (selectedField.Equals(CHARTS))
            {
                ChartsForm chartsForm = new ChartsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadForm(chartsForm);
            }
            else if (selectedField.Equals(TABLE))
            {
                TableForm tableForm = new TableForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadForm(tableForm);
            }
        }

        private void LoadForm(Form form)
        {
            this.PanelFormLoader.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(form);
            form.Show();
        }

        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar.Visible = true;
                LblPercentage.Visible = true;
                BkgWorkerDataReader.RunWorkerAsync();
            }
            else
            {

            }
        }

        private void BkgWorkerDataReader_DoWork(object sender, DoWorkEventArgs e)
        {
            Controller.ReadCSV(openFileDialog.FileName, BkgWorkerDataReader);
        }

        private void BkgWorkerDataReader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar.Value = e.ProgressPercentage;

            // Change the value of the ProgressBar to the BackgroundWorker progress.
            LblPercentage.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void BkgWorkerDataReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        { 
            CBoxChangePanel.Items.Add(MAP);
            CBoxChangePanel.Items.Add(CHARTS);
            CBoxChangePanel.Items.Add(TABLE);
            progressBar.Visible = false;
            LblPercentage.Visible = false;
        }
    }
}
