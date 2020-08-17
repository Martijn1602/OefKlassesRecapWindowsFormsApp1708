namespace OefKlassesRecapWindowsFormsApp1708
{
    partial class Oef3
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
            this.btnOef4Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOef4Show
            // 
            this.btnOef4Show.Location = new System.Drawing.Point(634, 398);
            this.btnOef4Show.Name = "btnOef4Show";
            this.btnOef4Show.Size = new System.Drawing.Size(141, 27);
            this.btnOef4Show.TabIndex = 0;
            this.btnOef4Show.Text = "Oefening 4";
            this.btnOef4Show.UseVisualStyleBackColor = true;
            this.btnOef4Show.Click += new System.EventHandler(this.btnOef4Show_Click);
            // 
            // Oef3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOef4Show);
            this.Name = "Oef3";
            this.Text = "Oef3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOef4Show;
    }
}