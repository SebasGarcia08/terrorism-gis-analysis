
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
            this.CBoxChangePanel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanelFormLoader = new System.Windows.Forms.Panel();
            this.LblPercentage = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BkgWorkerDataReader = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBoxChangePanel
            // 
            this.CBoxChangePanel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CBoxChangePanel.FormattingEnabled = true;
            this.CBoxChangePanel.Location = new System.Drawing.Point(12, 32);
            this.CBoxChangePanel.Name = "CBoxChangePanel";
            this.CBoxChangePanel.Size = new System.Drawing.Size(195, 21);
            this.CBoxChangePanel.TabIndex = 0;
            this.CBoxChangePanel.SelectedIndexChanged += new System.EventHandler(this.CBoxChangePanel_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 613);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PnlFormLoader);
            this.panel2.Controls.Add(this.CBoxChangePanel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 100);
            this.panel2.TabIndex = 2;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(229, 0);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(914, 613);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sections";
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDataBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.loadDataBtn.Location = new System.Drawing.Point(426, 219);
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
            this.openFileDialog.DefaultExt = "csv";
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // PanelFormLoader
            // 
            this.PanelFormLoader.Controls.Add(this.LblPercentage);
            this.PanelFormLoader.Controls.Add(this.progressBar);
            this.PanelFormLoader.Controls.Add(this.loadDataBtn);
            this.PanelFormLoader.Controls.Add(this.richTextBox1);
            this.PanelFormLoader.Controls.Add(this.label2);
            this.PanelFormLoader.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.PanelFormLoader.Location = new System.Drawing.Point(229, 3);
            this.PanelFormLoader.Name = "PanelFormLoader";
            this.PanelFormLoader.Size = new System.Drawing.Size(911, 607);
            this.PanelFormLoader.TabIndex = 2;
            // 
            // LblPercentage
            // 
            this.LblPercentage.AutoSize = true;
            this.LblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblPercentage.Location = new System.Drawing.Point(857, 565);
            this.LblPercentage.Name = "LblPercentage";
            this.LblPercentage.Size = new System.Drawing.Size(34, 20);
            this.LblPercentage.TabIndex = 7;
            this.LblPercentage.Text = "0%";
            this.LblPercentage.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.progressBar.Location = new System.Drawing.Point(14, 565);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(837, 23);
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.richTextBox1.Location = new System.Drawing.Point(33, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(852, 83);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(280, 21);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelFormLoader.ResumeLayout(false);
            this.PanelFormLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxChangePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button loadDataBtn;
        protected System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel PanelFormLoader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker BkgWorkerDataReader;
        private System.Windows.Forms.Label LblPercentage;
    }
}

