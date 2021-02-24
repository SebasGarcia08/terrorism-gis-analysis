﻿using System;
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
        // Make title bar of same color as form 
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }
        
        // Make form Draggable 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {     
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        public const string TABLE = "Table";
        public const string MAP = "Map";
        public const string CHARTS = "Charts";

        private readonly AppController Controller;

        private readonly MapForm MapForm;
        private readonly ChartsForm ChartsForm;
        private readonly TableForm TableForm;
        
        private  FilterMakerForm Filterer;

        private List<HeaderTypeSelector> HeaderTypes;
        private Dictionary<string, string> Col2Type;
        private List<string> ColsInToolTip;

        public MainForm()
        {
            InitializeComponent();

            this.Controller = new AppController(this);
            
            this.MapForm = new MapForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.ChartsForm = new ChartsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.TableForm = new TableForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            
            HeaderTypes = new List<HeaderTypeSelector>();
            Col2Type = new Dictionary<string, string>();
            ColsInToolTip = new List<string>();
            
            ConfigureInitialState();
        }

        #region GUIMethods
        private void ConfigureInitialState()
        {
            PnlDropDownSections.Visible = false;
            PnlDropdownFilters.Visible = false;
            BtnCharts.Enabled = false;
            BtnMap.Enabled = false;
            BtnTable.Enabled = false;
        }

        private void ReadDataSuccess()
        {
            LoadFilterMaker();
            ShowSubMenu(PnlDropDownSections);
            ShowSubMenu(PnlDropdownFilters);
            BtnCharts.Enabled = true;
            BtnMap.Enabled = true;
            BtnTable.Enabled = true;
        }

        private void LoadFilterMaker()
        {
            Filterer = Controller.CreateFiltererMaker();
            PnlDropdownFilters.Controls.Add(Filterer);
            Filterer.BringToFront();
            Filterer.Show();
        }
        
        private void HideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible) subMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void LoadForm(Form form)
        {
            PanelFormLoader.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            PanelFormLoader.Controls.Add(form);
            form.Show();
        }

        public void AppendControlToFiltersSidebar(Control control)
        {
            PnlDropdownFilters.Controls.Add(control);
            control.BringToFront();
            control.Show();
        }

        private void ShowHeaders(string[] columns)
        {
            foreach(string col in columns)
            {
                HeaderTypeSelector objForm = new HeaderTypeSelector(col) {  TopLevel = false};
                PnlHeaderType.Controls.Add(objForm);
                objForm.BringToFront();
                objForm.Show();
                HeaderTypes.Add(objForm);
            }
        }
        #endregion

        #region Events
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
        
        private void LoadDataBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var columns = Controller.ReadAndGetColumns(openFileDialog.FileName);
                ShowHeaders(columns);
                BtnReadTable.Visible = true;
            }
        }

        private void BkgWorkerDataReader_DoWork(object sender, DoWorkEventArgs e)  
        {
            Controller.ReadAndGetReport(BkgWorkerDataReader, Col2Type);
        }

        private void BkgWorkerDataReader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            LblPercentage.Text = e.ProgressPercentage + "%";
        }

        private void BkgWorkerDataReader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            ReadDataSuccess();
            progressBar.Visible = false;
            LblPercentage.Visible = false;
            DataTable dt = Controller.GetDataTable();
            MapForm.SetDabatase(dt);
            MapForm.SetColsInToolTips(ColsInToolTip);
            TableForm.SetDataSource(dt);
            ChartsForm.setDataBase(dt);
        }

        private void BtnReadTable_Click(object sender, EventArgs e)
        {
            Col2Type = new Dictionary<string, string>();
            foreach (HeaderTypeSelector headerTypeForm in HeaderTypes)
            {
                if(headerTypeForm.IsUsedInToolTip())
                    ColsInToolTip.Add(headerTypeForm.GetName());
                Col2Type.Add(headerTypeForm.GetName(), headerTypeForm.GetTypeSelected());
            }
            progressBar.Visible = true;
            LblPercentage.Visible = true;
            BtnReadTable.Enabled = false;
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
        #endregion 
    }
}
