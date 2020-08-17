namespace OefKlassesRecapWindowsFormsApp1708
{
    partial class Oef4
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
            this.numericUpDownLengte = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBreedte = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiepte = new System.Windows.Forms.NumericUpDown();
            this.lbLengte = new System.Windows.Forms.Label();
            this.lbBreedte = new System.Windows.Forms.Label();
            this.lbDiep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHoeveelWater = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreedte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiepte)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownLengte
            // 
            this.numericUpDownLengte.Location = new System.Drawing.Point(139, 33);
            this.numericUpDownLengte.Name = "numericUpDownLengte";
            this.numericUpDownLengte.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLengte.TabIndex = 0;
            this.numericUpDownLengte.ValueChanged += new System.EventHandler(this.numericUpDownLengte_ValueChanged);
            // 
            // numericUpDownBreedte
            // 
            this.numericUpDownBreedte.Location = new System.Drawing.Point(139, 71);
            this.numericUpDownBreedte.Name = "numericUpDownBreedte";
            this.numericUpDownBreedte.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBreedte.TabIndex = 1;
            this.numericUpDownBreedte.ValueChanged += new System.EventHandler(this.numericUpDownBreedte_ValueChanged);
            // 
            // numericUpDownDiepte
            // 
            this.numericUpDownDiepte.Location = new System.Drawing.Point(139, 113);
            this.numericUpDownDiepte.Name = "numericUpDownDiepte";
            this.numericUpDownDiepte.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDiepte.TabIndex = 2;
            this.numericUpDownDiepte.ValueChanged += new System.EventHandler(this.numericUpDownDiepte_ValueChanged);
            // 
            // lbLengte
            // 
            this.lbLengte.AutoSize = true;
            this.lbLengte.Location = new System.Drawing.Point(13, 33);
            this.lbLengte.Name = "lbLengte";
            this.lbLengte.Size = new System.Drawing.Size(40, 13);
            this.lbLengte.TabIndex = 3;
            this.lbLengte.Text = "Lengte";
            // 
            // lbBreedte
            // 
            this.lbBreedte.AutoSize = true;
            this.lbBreedte.Location = new System.Drawing.Point(13, 78);
            this.lbBreedte.Name = "lbBreedte";
            this.lbBreedte.Size = new System.Drawing.Size(44, 13);
            this.lbBreedte.TabIndex = 4;
            this.lbBreedte.Text = "Breedte";
            // 
            // lbDiep
            // 
            this.lbDiep.AutoSize = true;
            this.lbDiep.Location = new System.Drawing.Point(13, 120);
            this.lbDiep.Name = "lbDiep";
            this.lbDiep.Size = new System.Drawing.Size(38, 13);
            this.lbDiep.TabIndex = 5;
            this.lbDiep.Text = "Diepte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hoeveelheid Water:";
            // 
            // lbHoeveelWater
            // 
            this.lbHoeveelWater.AutoSize = true;
            this.lbHoeveelWater.Location = new System.Drawing.Point(171, 173);
            this.lbHoeveelWater.Name = "lbHoeveelWater";
            this.lbHoeveelWater.Size = new System.Drawing.Size(48, 13);
            this.lbHoeveelWater.TabIndex = 7;
            this.lbHoeveelWater.Text = "Uitkomst";
            this.lbHoeveelWater.Click += new System.EventHandler(this.lbHoeveelWater_Click);
            // 
            // Oef4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHoeveelWater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDiep);
            this.Controls.Add(this.lbBreedte);
            this.Controls.Add(this.lbLengte);
            this.Controls.Add(this.numericUpDownDiepte);
            this.Controls.Add(this.numericUpDownBreedte);
            this.Controls.Add(this.numericUpDownLengte);
            this.Name = "Oef4";
            this.Text = "Oef4";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreedte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiepte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownLengte;
        private System.Windows.Forms.NumericUpDown numericUpDownBreedte;
        private System.Windows.Forms.NumericUpDown numericUpDownDiepte;
        private System.Windows.Forms.Label lbLengte;
        private System.Windows.Forms.Label lbBreedte;
        private System.Windows.Forms.Label lbDiep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoeveelWater;
    }
}