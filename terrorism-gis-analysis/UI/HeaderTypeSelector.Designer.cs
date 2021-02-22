
namespace terrorism_gis_analysis.UI
{
    partial class HeaderTypeSelector
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
            this.HeaderName = new System.Windows.Forms.Label();
            this.ChBoxToolTip = new System.Windows.Forms.CheckBox();
            this.RBtnCategorical = new System.Windows.Forms.RadioButton();
            this.RBtnNumerical = new System.Windows.Forms.RadioButton();
            this.RBtnString = new System.Windows.Forms.RadioButton();
            this.GBoxColType = new System.Windows.Forms.GroupBox();
            this.GBoxColType.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSize = true;
            this.HeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.HeaderName.Location = new System.Drawing.Point(26, 14);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new System.Drawing.Size(51, 20);
            this.HeaderName.TabIndex = 0;
            this.HeaderName.Text = "label1";
            // 
            // ChBoxToolTip
            // 
            this.ChBoxToolTip.AutoSize = true;
            this.ChBoxToolTip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChBoxToolTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBoxToolTip.ForeColor = System.Drawing.Color.White;
            this.ChBoxToolTip.Location = new System.Drawing.Point(576, 11);
            this.ChBoxToolTip.Name = "ChBoxToolTip";
            this.ChBoxToolTip.Size = new System.Drawing.Size(117, 21);
            this.ChBoxToolTip.TabIndex = 2;
            this.ChBoxToolTip.Text = "Use in ToolTip";
            this.ChBoxToolTip.UseVisualStyleBackColor = true;
            // 
            // RBtnCategorical
            // 
            this.RBtnCategorical.AutoSize = true;
            this.RBtnCategorical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBtnCategorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCategorical.ForeColor = System.Drawing.Color.White;
            this.RBtnCategorical.Location = new System.Drawing.Point(6, 14);
            this.RBtnCategorical.Name = "RBtnCategorical";
            this.RBtnCategorical.Size = new System.Drawing.Size(96, 21);
            this.RBtnCategorical.TabIndex = 3;
            this.RBtnCategorical.TabStop = true;
            this.RBtnCategorical.Text = "Categorical";
            this.RBtnCategorical.UseVisualStyleBackColor = true;
            // 
            // RBtnNumerical
            // 
            this.RBtnNumerical.AutoSize = true;
            this.RBtnNumerical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBtnNumerical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnNumerical.ForeColor = System.Drawing.Color.White;
            this.RBtnNumerical.Location = new System.Drawing.Point(110, 15);
            this.RBtnNumerical.Name = "RBtnNumerical";
            this.RBtnNumerical.Size = new System.Drawing.Size(88, 21);
            this.RBtnNumerical.TabIndex = 4;
            this.RBtnNumerical.TabStop = true;
            this.RBtnNumerical.Text = "Numerical";
            this.RBtnNumerical.UseVisualStyleBackColor = true;
            // 
            // RBtnString
            // 
            this.RBtnString.AutoSize = true;
            this.RBtnString.Checked = true;
            this.RBtnString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBtnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnString.ForeColor = System.Drawing.Color.White;
            this.RBtnString.Location = new System.Drawing.Point(215, 14);
            this.RBtnString.Name = "RBtnString";
            this.RBtnString.Size = new System.Drawing.Size(62, 21);
            this.RBtnString.TabIndex = 5;
            this.RBtnString.TabStop = true;
            this.RBtnString.Text = "String";
            this.RBtnString.UseVisualStyleBackColor = true;
            // 
            // GBoxColType
            // 
            this.GBoxColType.Controls.Add(this.RBtnCategorical);
            this.GBoxColType.Controls.Add(this.RBtnString);
            this.GBoxColType.Controls.Add(this.RBtnNumerical);
            this.GBoxColType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBoxColType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxColType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.GBoxColType.Location = new System.Drawing.Point(243, -3);
            this.GBoxColType.Name = "GBoxColType";
            this.GBoxColType.Size = new System.Drawing.Size(303, 39);
            this.GBoxColType.TabIndex = 6;
            this.GBoxColType.TabStop = false;
            this.GBoxColType.Text = "Variable Type";
            // 
            // HeaderTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(706, 48);
            this.Controls.Add(this.GBoxColType);
            this.Controls.Add(this.ChBoxToolTip);
            this.Controls.Add(this.HeaderName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HeaderTypeSelector";
            this.GBoxColType.ResumeLayout(false);
            this.GBoxColType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderName;
        private System.Windows.Forms.CheckBox ChBoxToolTip;
        private System.Windows.Forms.RadioButton RBtnCategorical;
        private System.Windows.Forms.RadioButton RBtnNumerical;
        private System.Windows.Forms.RadioButton RBtnString;
        private System.Windows.Forms.GroupBox GBoxColType;
    }
}