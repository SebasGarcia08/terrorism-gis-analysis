using System.ComponentModel;

namespace terrorism_gis_analysis.UI
{
    partial class FilterItemsPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.PnlFilters = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlFilters
            // 
            this.PnlFilters.AutoScroll = true;
            this.PnlFilters.AutoSize = true;
            this.PnlFilters.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (24)))), ((int) (((byte) (30)))), ((int) (((byte) (54)))));
            this.PnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFilters.Location = new System.Drawing.Point(0, 0);
            this.PnlFilters.Name = "PnlFilters";
            this.PnlFilters.Size = new System.Drawing.Size(223, 189);
            this.PnlFilters.TabIndex = 0;
            // 
            // FilterItemsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(223, 189);
            this.Controls.Add(this.PnlFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterItemsPanel";
            this.Text = "FilterItemsPanel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel PnlFilters;

        #endregion
    }
}