
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
            this.label1 = new System.Windows.Forms.Label();
            this.GBoxColType = new System.Windows.Forms.GroupBox();
            this.RBtnCategorical = new System.Windows.Forms.RadioButton();
            this.RBtnString = new System.Windows.Forms.RadioButton();
            this.RBtnNumerical = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBoxColType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(79, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add filter";
            // 
            // GBoxColType
            // 
            this.GBoxColType.Controls.Add(this.RBtnCategorical);
            this.GBoxColType.Controls.Add(this.RBtnString);
            this.GBoxColType.Controls.Add(this.RBtnNumerical);
            this.GBoxColType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBoxColType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxColType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.GBoxColType.Location = new System.Drawing.Point(12, 29);
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 46);
            this.panel1.TabIndex = 9;
            // 
            // FilterMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(223, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GBoxColType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterMakerForm";
            this.Text = "Form1";
            this.GBoxColType.ResumeLayout(false);
            this.GBoxColType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBoxColType;
        private System.Windows.Forms.RadioButton RBtnCategorical;
        private System.Windows.Forms.RadioButton RBtnString;
        private System.Windows.Forms.RadioButton RBtnNumerical;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}