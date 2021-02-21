
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
            this.CBoxChangePanel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanelFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBoxChangePanel
            // 
            this.CBoxChangePanel.FormattingEnabled = true;
            this.CBoxChangePanel.Location = new System.Drawing.Point(12, 12);
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
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(364, 172);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(75, 23);
            this.loadDataBtn.TabIndex = 2;
            this.loadDataBtn.Text = "Load Data";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "csv";
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // PanelFormLoader
            // 
            this.PanelFormLoader.Controls.Add(this.loadDataBtn);
            this.PanelFormLoader.Location = new System.Drawing.Point(229, 3);
            this.PanelFormLoader.Name = "PanelFormLoader";
            this.PanelFormLoader.Size = new System.Drawing.Size(911, 607);
            this.PanelFormLoader.TabIndex = 2;
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
            this.PanelFormLoader.ResumeLayout(false);
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
    }
}

