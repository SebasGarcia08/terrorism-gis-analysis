
namespace terrorism_gis_analysis.UI
{
    partial class FilterMakerForm
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
            this.GBoxColType = new System.Windows.Forms.GroupBox();
            this.RBtnCategorical = new System.Windows.Forms.RadioButton();
            this.RBtnString = new System.Windows.Forms.RadioButton();
            this.RBtnNumerical = new System.Windows.Forms.RadioButton();
            this.CBoxVariables = new System.Windows.Forms.ComboBox();
            this.PnlOptionFilterer = new System.Windows.Forms.Panel();
            this.BtnAddFilter = new System.Windows.Forms.Button();
            this.GBoxColType.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxColType
            // 
            this.GBoxColType.Controls.Add(this.RBtnCategorical);
            this.GBoxColType.Controls.Add(this.RBtnString);
            this.GBoxColType.Controls.Add(this.RBtnNumerical);
            this.GBoxColType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBoxColType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxColType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.GBoxColType.Location = new System.Drawing.Point(12, 12);
            this.GBoxColType.Name = "GBoxColType";
            this.GBoxColType.Size = new System.Drawing.Size(199, 64);
            this.GBoxColType.TabIndex = 7;
            this.GBoxColType.TabStop = false;
            this.GBoxColType.Text = "Variable Type";
            // 
            // RBtnCategorical
            // 
            this.RBtnCategorical.AutoSize = true;
            this.RBtnCategorical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBtnCategorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCategorical.ForeColor = System.Drawing.Color.White;
            this.RBtnCategorical.Location = new System.Drawing.Point(6, 14);
            this.RBtnCategorical.Name = "RBtnCategorical";
            this.RBtnCategorical.Size = new System.Drawing.Size(77, 17);
            this.RBtnCategorical.TabIndex = 3;
            this.RBtnCategorical.TabStop = true;
            this.RBtnCategorical.Text = "Categorical";
            this.RBtnCategorical.UseVisualStyleBackColor = true;
            this.RBtnCategorical.CheckedChanged += new System.EventHandler(this.RBtnCategorical_CheckedChanged);
            // 
            // RBtnString
            // 
            this.RBtnString.AutoSize = true;
            this.RBtnString.Checked = true;
            this.RBtnString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBtnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnString.ForeColor = System.Drawing.Color.White;
            this.RBtnString.Location = new System.Drawing.Point(72, 37);
            this.RBtnString.Name = "RBtnString";
            this.RBtnString.Size = new System.Drawing.Size(51, 17);
            this.RBtnString.TabIndex = 5;
            this.RBtnString.TabStop = true;
            this.RBtnString.Text = "String";
            this.RBtnString.UseVisualStyleBackColor = true;
            this.RBtnString.CheckedChanged += new System.EventHandler(this.RBtnString_CheckedChanged);
            // 
            // RBtnNumerical
            // 
            this.RBtnNumerical.AutoSize = true;
            this.RBtnNumerical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBtnNumerical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnNumerical.ForeColor = System.Drawing.Color.White;
            this.RBtnNumerical.Location = new System.Drawing.Point(113, 14);
            this.RBtnNumerical.Name = "RBtnNumerical";
            this.RBtnNumerical.Size = new System.Drawing.Size(71, 17);
            this.RBtnNumerical.TabIndex = 4;
            this.RBtnNumerical.TabStop = true;
            this.RBtnNumerical.Text = "Numerical";
            this.RBtnNumerical.UseVisualStyleBackColor = true;
            this.RBtnNumerical.CheckedChanged += new System.EventHandler(this.RBtnNumerical_CheckedChanged);
            // 
            // CBoxVariables
            // 
            this.CBoxVariables.FormattingEnabled = true;
            this.CBoxVariables.Location = new System.Drawing.Point(12, 82);
            this.CBoxVariables.Name = "CBoxVariables";
            this.CBoxVariables.Size = new System.Drawing.Size(199, 21);
            this.CBoxVariables.TabIndex = 8;
            // 
            // PnlOptionFilterer
            // 
            this.PnlOptionFilterer.Location = new System.Drawing.Point(12, 109);
            this.PnlOptionFilterer.Name = "PnlOptionFilterer";
            this.PnlOptionFilterer.Size = new System.Drawing.Size(199, 46);
            this.PnlOptionFilterer.TabIndex = 9;
            // 
            // BtnAddFilter
            // 
            this.BtnAddFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddFilter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAddFilter.Location = new System.Drawing.Point(64, 167);
            this.BtnAddFilter.Name = "BtnAddFilter";
            this.BtnAddFilter.Size = new System.Drawing.Size(86, 30);
            this.BtnAddFilter.TabIndex = 10;
            this.BtnAddFilter.Text = "Add Filter";
            this.BtnAddFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAddFilter.UseVisualStyleBackColor = true;
            this.BtnAddFilter.Click += new System.EventHandler(this.BtnAddFilter_Click);
            // 
            // FilterMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(223, 209);
            this.Controls.Add(this.BtnAddFilter);
            this.Controls.Add(this.PnlOptionFilterer);
            this.Controls.Add(this.CBoxVariables);
            this.Controls.Add(this.GBoxColType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterMakerForm";
            this.Text = "Form1";
            this.GBoxColType.ResumeLayout(false);
            this.GBoxColType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBoxColType;
        private System.Windows.Forms.RadioButton RBtnCategorical;
        private System.Windows.Forms.RadioButton RBtnString;
        private System.Windows.Forms.RadioButton RBtnNumerical;
        private System.Windows.Forms.ComboBox CBoxVariables;
        private System.Windows.Forms.Panel PnlOptionFilterer;
        private System.Windows.Forms.Button BtnAddFilter;
    }
}