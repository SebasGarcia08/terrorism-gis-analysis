
namespace terrorism_gis_analysis
{
    partial class ChartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // barChart
            // 
            chartArea4.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.barChart.Legends.Add(legend4);
            this.barChart.Location = new System.Drawing.Point(12, 12);
            this.barChart.Name = "barChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.barChart.Series.Add(series4);
            this.barChart.Size = new System.Drawing.Size(577, 270);
            this.barChart.TabIndex = 0;
            this.barChart.Text = "chart1";
            // 
            // lineChart
            // 
            chartArea5.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.lineChart.Legends.Add(legend5);
            this.lineChart.Location = new System.Drawing.Point(12, 288);
            this.lineChart.Name = "lineChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.lineChart.Series.Add(series5);
            this.lineChart.Size = new System.Drawing.Size(1182, 454);
            this.lineChart.TabIndex = 1;
            this.lineChart.Text = "chart1";
            // 
            // pieChart
            // 
            chartArea6.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.pieChart.Legends.Add(legend6);
            this.pieChart.Location = new System.Drawing.Point(595, 12);
            this.pieChart.Name = "pieChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.pieChart.Series.Add(series6);
            this.pieChart.Size = new System.Drawing.Size(599, 270);
            this.pieChart.TabIndex = 2;
            this.pieChart.Text = "chart1";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1219, 754);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.barChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            this.Load += new System.EventHandler(this.ChartsForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}