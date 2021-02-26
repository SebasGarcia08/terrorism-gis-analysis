using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace terrorism_gis_analysis
{
    public partial class ChartsForm : Form
    {
        private DataTable db;
        private bool LoadedBar;
        private bool LoadedPie;
        private bool LoadedLine;
        
        public ChartsForm()
        {
            InitializeComponent();
            LoadedBar = false;
            LoadedPie = false;
            LoadedLine = false;
        }

        private void ChartsForm_load(object sender, EventArgs e)
        {
            loadBarChart();
            loadLineChart();
            loadPieChart();
        }

        private void loadBarChart()
        {
            string[] x;
            int[] y;

            CountAttacks("attacktype1_txt", out x, out y);

            //Series style
            barChart.Series[0].LegendText = "Terrorist\nattacks";
            barChart.Series[0].ChartType = SeriesChartType.Bar;
            barChart.Series[0].IsValueShownAsLabel = true;
            barChart.Series[0].Points.DataBindXY(x, y);

            //Areas style
            barChart.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            barChart.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;

            //Title
            if (!LoadedBar)
            {
                barChart.Titles.Add("Terrorist attacks per Type");
                LoadedBar = true;
            }
        }

        private void loadLineChart()
        {
            string[] x;
            int[] y;

            CountAttacks("iyear", out x, out y);

            //Series style
            lineChart.Series[0].LegendText = "Terrorist\nattacks";
            lineChart.Series[0].IsValueShownAsLabel = true;
            lineChart.Series[0].BorderWidth = 2;
            lineChart.Series[0].ChartType = SeriesChartType.Line;
            lineChart.Series[0].Points.DataBindXY(x, y);
            lineChart.Legends[0].Enabled = true;

            //Areas style
            lineChart.ChartAreas[0].AxisX.Interval = 1;

            //Title
            if (!LoadedLine)
            {
                lineChart.Titles.Add("Terrorist attacks through Years");
                LoadedLine = true;
            }
                
        }

        private void loadPieChart()
        {
            string[] x;
            int[] y;

            CountAttacks("region_txt", out x, out y);

            //Series style
            pieChart.Series[0].ChartType = SeriesChartType.Pie;
            pieChart.Series[0].Points.DataBindXY(x, y);
            pieChart.Legends[0].Enabled = true;
            pieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            pieChart.Series[0]["PieLabelStyle"] = "Disabled";

            //Title
            if (!LoadedPie)
            {
                pieChart.Titles.Add("Terrorist attacks per World Region");
                LoadedPie = true;
            }
                
        }

        private void CountAttacks(string field, out string[] x, out int[] y)
        {
            Dictionary<string, int> attacksCount = new Dictionary<string, int>();
            foreach (DataRow row in db.Rows)
            {   
                var value = row[field].ToString();
                if (attacksCount.ContainsKey(value))
                    attacksCount[value] += 1;
                else
                    attacksCount.Add(value, 1);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add(field, typeof(string));
            dt.Columns.Add("Count", typeof(int));

            foreach (KeyValuePair<string, int> kvp in attacksCount)
            {
                dt.Rows.Add(new Object[] { kvp.Key, kvp.Value });
            }

            //Get the Field values
            x = (from p in dt.AsEnumerable()
                 orderby p.Field<string>(field) ascending
                 select p.Field<string>(field)).ToArray();

            //Get the Count of attacks for each Field value
            y = (from p in dt.AsEnumerable()
                 orderby p.Field<string>(field) ascending
                 select p.Field<int>("Count")).ToArray();
        }

        public void setDataBase(DataTable dt)
        {
            db = dt;
            // barChart.DataSource = dt;
            // lineChart.DataSource = dt;
            // pieChart.DataSource = dt;
            
            loadBarChart();
            loadLineChart();
            loadPieChart();
            
        }
    }
}
