using System.ComponentModel;

namespace terrorism_gis_analysis.UI
{
    partial class FilterItem
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilterInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilterInfo
            // 
            this.FilterInfo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterInfo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (156)))), ((int) (((byte) (149)))));
            this.FilterInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FilterInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterInfo.Location = new System.Drawing.Point(0, 5);
            this.FilterInfo.Name = "FilterInfo";
            this.FilterInfo.Size = new System.Drawing.Size(197, 31);
            this.FilterInfo.TabIndex = 0;
            this.FilterInfo.Text = "label1";
            this.FilterInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (24)))), ((int) (((byte) (30)))), ((int) (((byte) (54)))));
            this.Controls.Add(this.FilterInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FilterItem";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(197, 41);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label FilterInfo;

        #endregion
    }
}