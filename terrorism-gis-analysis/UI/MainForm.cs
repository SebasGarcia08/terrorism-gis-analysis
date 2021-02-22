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
using System.Runtime.InteropServices;
using terrorism_gis_analysis.UI;

namespace terrorism_gis_analysis
{

    public partial class MainForm : Form
    {

        public readonly string TABLE = "Table";
        public readonly string MAP = "Map";
        public readonly string CHARTS = "Charts";

        private AppController Controller;

        private MapForm MapForm;
        private ChartsForm ChartsForm;
        private TableForm TableForm;

        private List<HeaderTypeSelector> HeaderTypes;
        private Dictionary<string, string> Col2Type;
        private List<string> ColsInToolTip;

        /// <summary>
        /// Round corners
        /// </summary>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
         );

        public MainForm()
        {
            InitializeComponent();
            
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            
            this.Controller = new AppController();

            this.MapForm = new MapForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.ChartsForm = new ChartsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.TableForm = new TableForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HeaderTypes = new List<HeaderTypeSelector>();
            Col2Type = new Dictionary<string, string>();
            ColsInToolTip = new List<string>();
            ConfigureInitialState();
        }

        public void ConfigureInitialState()
        {
            PnlDropDownSections.Visible = false;
            PnlDropdownFilters.Visible = false;
            BtnCharts.Enabled = false;
            BtnMap.Enabled = false;
            BtnTable.Enabled = false;
        }

        public void ReadingDataOKControls()
        {
            ShowSubMenu(PnlDropDownSections);
            BtnCharts.Enabled = true;
            BtnMap.Enabled = true;
            BtnTable.Enabled = true;
        }

        public void HideSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible)
                SubMenu.Visible = false;
        }

        public void ShowSubMenu(Panel SubMenu)
        {
            if (!SubMenu.Visible)
            {
                HideSubMenu(SubMenu);
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        /// <summary>
        /// Events
        /// </summary>
        private void BtnSections_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlDropDownSections);
        }

        private void BtnFlters_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlDropdownFilters);
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
                string[] Columns = Controller.ReadAndGetColumns(openFileDialog.FileName);
                ShowHeaders(Columns);
                BtnReadTable.Visible = true;
            }
        }

        public void ShowHeaders(string[] Columns)
        {
            // TODO: Show columns on UI in order to make the user specify the type of each one
            foreach(string col in Columns)
            {
                HeaderTypeSelector objForm = new HeaderTypeSelector(col) {  TopLevel = false};
                this.PnlHeaderType.Controls.Add(objForm);
                objForm.BringToFront();
                Console.WriteLine(col);
                objForm.Show();
                HeaderTypes.Add(objForm);
            }
        }

        public void BkgWorkerDataReader_DoWork(object sender, DoWorkEventArgs e)  
        {
            Controller.ReadAndGetReport(BkgWorkerDataReader, Col2Type);
        }

        private void BkgWorkerDataReader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar.Value = e.ProgressPercentage;

            // Change the value of the ProgressBar to the BackgroundWorker progress.
            LblPercentage.Text = e.ProgressPercentage.ToString()+"%";
        }

        private void BkgWorkerDataReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            ReadingDataOKControls();
            progressBar.Visible = false;
            LblPercentage.Visible = false;
            DataTable dt = Controller.GetDataTable();
            MapForm.SetDabatase(dt);
            MapForm.SetColsInToolTips(ColsInToolTip);
            TableForm.SetDataSource(dt);
        }

        private void BtnReadTable_Click(object sender, EventArgs e)
        {
            foreach(HeaderTypeSelector headerTypeForm in HeaderTypes)
            {
                if(headerTypeForm.IsUsedInToolTip())
                    ColsInToolTip.Add(headerTypeForm.GetName());
                Col2Type.Add(headerTypeForm.GetName(), headerTypeForm.GetTypeSelected());
            }
            this.progressBar.Visible = true;
            this.LblPercentage.Visible = true;
            BkgWorkerDataReader.RunWorkerAsync();
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            LoadForm(MapForm);
        }

        private void BtnCharts_Click(object sender, EventArgs e)
        {
            LoadForm(ChartsForm);
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            LoadForm(TableForm);
        }
    }
}
