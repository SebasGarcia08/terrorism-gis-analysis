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

        public ChartsForm()
        {
            InitializeComponent();
        }

        private void ChartsForm_load(object sender, EventArgs e)
        {
            loadBarChart();
            loadLineChart();
            loadPieChart();
        }

        private void loadBarChart()
        {
            Dictionary<string, int> attackTypesCount = new Dictionary<string, int>();
            foreach (DataRow row in db.Rows)
            {
                if (attackTypesCount.ContainsKey((string)row["attacktype1_txt"]))
                {
                    attackTypesCount[(string)row["attacktype1_txt"]] += 1;
                }
                else
                {
                    attackTypesCount.Add((string)row["attacktype1_txt"], 1);
                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Attack types", typeof(string));
            dt.Columns.Add("Count", typeof(int));

            foreach (KeyValuePair<string, int> kvp in attackTypesCount)
            {
                dt.Rows.Add(new Object[] { kvp.Key, kvp.Value });
            }

            //Get the names of Attack types
            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("Attack types") ascending
                          select p.Field<string>("Attack types")).ToArray();

            //Get the Count of each Attack type
            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("Attack types") ascending
                       select p.Field<int>("Count")).ToArray();

            //Series style
            barChart.Series[0].LegendText = "Terrorist\nattacks";
            barChart.Series[0].ChartType = SeriesChartType.Bar;
            barChart.Series[0].IsValueShownAsLabel = true;
            barChart.Series[0].Points.DataBindXY(x, y);

            //Areas style
            barChart.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            barChart.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;

            barChart.Titles.Add("Terrorist attacks per Type");
        }

        private void loadLineChart()
        {
            Dictionary<string, int> yearsAttacksCount = new Dictionary<string, int>();
            foreach (DataRow row in db.Rows)
            {
                if (yearsAttacksCount.ContainsKey((string)row["iyear"]))
                {
                    yearsAttacksCount[(string)row["iyear"]] += 1;
                }
                else
                {
                    yearsAttacksCount.Add((string)row["iyear"], 1);
                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Year", typeof(string));
            dt.Columns.Add("Count", typeof(int));

            foreach (KeyValuePair<string, int> kvp in yearsAttacksCount)
            {
                dt.Rows.Add(new Object[] { kvp.Key, kvp.Value });
            }

            //Get the Year
            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("Year") ascending
                          select p.Field<string>("Year")).ToArray();

            //Get the Count of attacks for each Year
            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("Year") ascending
                       select p.Field<int>("Count")).ToArray();

            //Series style
            lineChart.Series[0].LegendText = "Terrorist\nattacks";
            lineChart.Series[0].IsValueShownAsLabel = true;
            lineChart.Series[0].BorderWidth = 2;
            lineChart.Series[0].ChartType = SeriesChartType.Line;
            lineChart.Series[0].Points.DataBindXY(x, y);
            lineChart.Legends[0].Enabled = true;

            //Areas style
            lineChart.ChartAreas[0].AxisX.Interval = 1;

            lineChart.Titles.Add("Terrorist attacks through Years");
        }

        private void loadPieChart()
        {
            Dictionary<string, int> regionsAttacksCount = new Dictionary<string, int>();
            foreach (DataRow row in db.Rows)
            {
                if (regionsAttacksCount.ContainsKey((string)row["region_txt"]))
                {
                    regionsAttacksCount[(string)row["region_txt"]] += 1;
                }
                else
                {
                    regionsAttacksCount.Add((string)row["region_txt"], 1);
                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Region", typeof(string));
            dt.Columns.Add("Count", typeof(int));

            foreach (KeyValuePair<string, int> kvp in regionsAttacksCount)
            {
                dt.Rows.Add(new Object[] { kvp.Key, kvp.Value });
            }

            //Get the Region
            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("Region") ascending
                          select p.Field<string>("Region")).ToArray();

            //Get the Count of attacks for each Region
            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("Region") ascending
                       select p.Field<int>("Count")).ToArray();

            //Series style
            pieChart.Series[0].ChartType = SeriesChartType.Pie;
            pieChart.Series[0].Points.DataBindXY(x, y);
            pieChart.Legends[0].Enabled = true;
            pieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            pieChart.Series[0]["PieLabelStyle"] = "Disabled";

            pieChart.Titles.Add("Terrorist attacks per World Region");
        }

        public void setDataBase(DataTable dt)
        {
            db = dt;
        }
    }
}
