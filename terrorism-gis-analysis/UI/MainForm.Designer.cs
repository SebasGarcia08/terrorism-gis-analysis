
namespace terrorism_gis_analysis
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlDropDownSections = new System.Windows.Forms.Panel();
            this.BtnTable = new System.Windows.Forms.Button();
            this.BtnCharts = new System.Windows.Forms.Button();
            this.BtnMap = new System.Windows.Forms.Button();
            this.BtnSections = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MiniLogo = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanelFormLoader = new System.Windows.Forms.Panel();
            this.LblPercentage = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BkgWorkerDataReader = new System.ComponentModel.BackgroundWorker();
            this.PnlHeaderType = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.PnlDropDownSections.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnlDropDownSections);
            this.panel1.Controls.Add(this.BtnSections);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 613);
            this.panel1.TabIndex = 1;
            // 
            // PnlDropDownSections
            // 
            this.PnlDropDownSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlDropDownSections.Controls.Add(this.BtnTable);
            this.PnlDropDownSections.Controls.Add(this.BtnCharts);
            this.PnlDropDownSections.Controls.Add(this.BtnMap);
            this.PnlDropDownSections.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDropDownSections.Location = new System.Drawing.Point(0, 140);
            this.PnlDropDownSections.Name = "PnlDropDownSections";
            this.PnlDropDownSections.Size = new System.Drawing.Size(223, 95);
            this.PnlDropDownSections.TabIndex = 5;
            // 
            // BtnTable
            // 
            this.BtnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTable.FlatAppearance.BorderSize = 0;
            this.BtnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnTable.Location = new System.Drawing.Point(0, 60);
            this.BtnTable.Name = "BtnTable";
            this.BtnTable.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnTable.Size = new System.Drawing.Size(223, 30);
            this.BtnTable.TabIndex = 8;
            this.BtnTable.Text = "Table";
            this.BtnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTable.UseVisualStyleBackColor = true;
            // 
            // BtnCharts
            // 
            this.BtnCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCharts.FlatAppearance.BorderSize = 0;
            this.BtnCharts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCharts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnCharts.Location = new System.Drawing.Point(0, 30);
            this.BtnCharts.Name = "BtnCharts";
            this.BtnCharts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCharts.Size = new System.Drawing.Size(223, 30);
            this.BtnCharts.TabIndex = 7;
            this.BtnCharts.Text = "Charts";
            this.BtnCharts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCharts.UseVisualStyleBackColor = true;
            // 
            // BtnMap
            // 
            this.BtnMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMap.FlatAppearance.BorderSize = 0;
            this.BtnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnMap.Location = new System.Drawing.Point(0, 0);
            this.BtnMap.Name = "BtnMap";
            this.BtnMap.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnMap.Size = new System.Drawing.Size(223, 30);
            this.BtnMap.TabIndex = 6;
            this.BtnMap.Text = "Map";
            this.BtnMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMap.UseVisualStyleBackColor = true;
            // 
            // BtnSections
            // 
            this.BtnSections.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.BtnSections.Location = new System.Drawing.Point(0, 100);
            this.BtnSections.Name = "BtnSections";
            this.BtnSections.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSections.Size = new System.Drawing.Size(223, 40);
            this.BtnSections.TabIndex = 4;
            this.BtnSections.Text = "Sections";
            this.BtnSections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSections.UseVisualStyleBackColor = true;
            this.BtnSections.Click += new System.EventHandler(this.BtnSections_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MiniLogo);
            this.panel2.Controls.Add(this.PnlFormLoader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 2;
            // 
            // MiniLogo
            // 
            this.MiniLogo.AutoSize = true;
            this.MiniLogo.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.MiniLogo.Location = new System.Drawing.Point(-2, 24);
            this.MiniLogo.Name = "MiniLogo";
            this.MiniLogo.Size = new System.Drawing.Size(225, 43);
            this.MiniLogo.TabIndex = 8;
            this.MiniLogo.Text = "GeoAnalyser";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(229, 0);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(914, 613);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDataBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.loadDataBtn.Location = new System.Drawing.Point(407, 204);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(86, 30);
            this.loadDataBtn.TabIndex = 2;
            this.loadDataBtn.Text = "Load Data";
            this.loadDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV files (*.csv)|*.csv|TSV files (*.tsv*)|*.tsv*";
            // 
            // PanelFormLoader
            // 
            this.PanelFormLoader.AutoScroll = true;
            this.PanelFormLoader.Controls.Add(this.PnlHeaderType);
            this.PanelFormLoader.Controls.Add(this.LblPercentage);
            this.PanelFormLoader.Controls.Add(this.progressBar);
            this.PanelFormLoader.Controls.Add(this.loadDataBtn);
            this.PanelFormLoader.Controls.Add(this.richTextBox1);
            this.PanelFormLoader.Controls.Add(this.label2);
            this.PanelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormLoader.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.PanelFormLoader.Location = new System.Drawing.Point(223, 0);
            this.PanelFormLoader.Name = "PanelFormLoader";
            this.PanelFormLoader.Size = new System.Drawing.Size(918, 613);
            this.PanelFormLoader.TabIndex = 2;
            // 
            // LblPercentage
            // 
            this.LblPercentage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblPercentage.Location = new System.Drawing.Point(851, 582);
            this.LblPercentage.Name = "LblPercentage";
            this.LblPercentage.Size = new System.Drawing.Size(35, 20);
            this.LblPercentage.TabIndex = 7;
            this.LblPercentage.Text = "0%";
            this.LblPercentage.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.progressBar.Location = new System.Drawing.Point(13, 582);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(831, 23);
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.richTextBox1.Location = new System.Drawing.Point(13, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(852, 83);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(260, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 81);
            this.label2.TabIndex = 4;
            this.label2.Text = "GeoAnalyser";
            // 
            // BkgWorkerDataReader
            // 
            this.BkgWorkerDataReader.WorkerReportsProgress = true;
            this.BkgWorkerDataReader.WorkerSupportsCancellation = true;
            this.BkgWorkerDataReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BkgWorkerDataReader_DoWork);
            this.BkgWorkerDataReader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BkgWorkerDataReader_ProgressChanged);
            this.BkgWorkerDataReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BkgWorkerDataReader_RunWorkerCompleted);
            // 
            // PnlHeaderType
            // 
            this.PnlHeaderType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlHeaderType.AutoScroll = true;
            this.PnlHeaderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlHeaderType.Location = new System.Drawing.Point(13, 251);
            this.PnlHeaderType.Name = "PnlHeaderType";
            this.PnlHeaderType.Size = new System.Drawing.Size(893, 252);
            this.PnlHeaderType.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1141, 613);
            this.Controls.Add(this.PanelFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalForm";
            this.panel1.ResumeLayout(false);
            this.PnlDropDownSections.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelFormLoader.ResumeLayout(false);
            this.PanelFormLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button loadDataBtn;
        protected System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel PanelFormLoader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker BkgWorkerDataReader;
        private System.Windows.Forms.Label LblPercentage;
        private System.Windows.Forms.Button BtnSections;
        private System.Windows.Forms.Label MiniLogo;
        private System.Windows.Forms.Panel PnlDropDownSections;
        private System.Windows.Forms.Button BtnTable;
        private System.Windows.Forms.Button BtnCharts;
        private System.Windows.Forms.Button BtnMap;
        private System.Windows.Forms.FlowLayoutPanel PnlHeaderType;
    }
}

