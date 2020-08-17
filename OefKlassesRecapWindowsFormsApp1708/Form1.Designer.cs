namespace OefKlassesRecapWindowsFormsApp1708
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnKanaalMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblKanaal = new System.Windows.Forms.Label();
            this.lblKanaalShow = new System.Windows.Forms.Label();
            this.lblVolumeShow = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnKanaalPlus = new System.Windows.Forms.Button();
            this.btnVolumePlus = new System.Windows.Forms.Button();
            this.btnVolumeMin = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnOef3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 346);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnKanaalMin
            // 
            this.BtnKanaalMin.Location = new System.Drawing.Point(13, 377);
            this.BtnKanaalMin.Name = "BtnKanaalMin";
            this.BtnKanaalMin.Size = new System.Drawing.Size(91, 61);
            this.BtnKanaalMin.TabIndex = 1;
            this.BtnKanaalMin.Text = "---";
            this.BtnKanaalMin.UseVisualStyleBackColor = true;
            this.BtnKanaalMin.Click += new System.EventHandler(this.BtnKanaalMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(595, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 61);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Afsluiten";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblKanaal
            // 
            this.lblKanaal.AutoSize = true;
            this.lblKanaal.Location = new System.Drawing.Point(87, 361);
            this.lblKanaal.Name = "lblKanaal";
            this.lblKanaal.Size = new System.Drawing.Size(40, 13);
            this.lblKanaal.TabIndex = 4;
            this.lblKanaal.Text = "Kanaal";
            // 
            // lblKanaalShow
            // 
            this.lblKanaalShow.AutoSize = true;
            this.lblKanaalShow.Location = new System.Drawing.Point(215, 377);
            this.lblKanaalShow.Name = "lblKanaalShow";
            this.lblKanaalShow.Size = new System.Drawing.Size(73, 13);
            this.lblKanaalShow.TabIndex = 5;
            this.lblKanaalShow.Text = "Huidig Kanaal";
            this.lblKanaalShow.Click += new System.EventHandler(this.lblKanaalShow_Click);
            // 
            // lblVolumeShow
            // 
            this.lblVolumeShow.AutoSize = true;
            this.lblVolumeShow.Location = new System.Drawing.Point(502, 377);
            this.lblVolumeShow.Name = "lblVolumeShow";
            this.lblVolumeShow.Size = new System.Drawing.Size(75, 13);
            this.lblVolumeShow.TabIndex = 7;
            this.lblVolumeShow.Text = "Huidig Volume";
            this.lblVolumeShow.Click += new System.EventHandler(this.lblVolumeShow_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(368, 361);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume";
            // 
            // btnKanaalPlus
            // 
            this.btnKanaalPlus.Location = new System.Drawing.Point(110, 377);
            this.btnKanaalPlus.Name = "btnKanaalPlus";
            this.btnKanaalPlus.Size = new System.Drawing.Size(91, 61);
            this.btnKanaalPlus.TabIndex = 8;
            this.btnKanaalPlus.Text = "+++";
            this.btnKanaalPlus.UseVisualStyleBackColor = true;
            this.btnKanaalPlus.Click += new System.EventHandler(this.btnKanaalPlus_Click);
            // 
            // btnVolumePlus
            // 
            this.btnVolumePlus.Location = new System.Drawing.Point(391, 377);
            this.btnVolumePlus.Name = "btnVolumePlus";
            this.btnVolumePlus.Size = new System.Drawing.Size(91, 61);
            this.btnVolumePlus.TabIndex = 10;
            this.btnVolumePlus.Text = "+++";
            this.btnVolumePlus.UseVisualStyleBackColor = true;
            this.btnVolumePlus.Click += new System.EventHandler(this.btnVolumePlus_Click);
            // 
            // btnVolumeMin
            // 
            this.btnVolumeMin.Location = new System.Drawing.Point(294, 377);
            this.btnVolumeMin.Name = "btnVolumeMin";
            this.btnVolumeMin.Size = new System.Drawing.Size(91, 61);
            this.btnVolumeMin.TabIndex = 9;
            this.btnVolumeMin.Text = "---";
            this.btnVolumeMin.UseVisualStyleBackColor = true;
            this.btnVolumeMin.Click += new System.EventHandler(this.btnVolumeMin_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(505, 414);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 11;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnOef3
            // 
            this.btnOef3.Location = new System.Drawing.Point(595, 445);
            this.btnOef3.Name = "btnOef3";
            this.btnOef3.Size = new System.Drawing.Size(193, 23);
            this.btnOef3.TabIndex = 12;
            this.btnOef3.Text = "Oefening 3";
            this.btnOef3.UseVisualStyleBackColor = true;
            this.btnOef3.Click += new System.EventHandler(this.btnOef3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnOef3);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnVolumePlus);
            this.Controls.Add(this.btnVolumeMin);
            this.Controls.Add(this.btnKanaalPlus);
            this.Controls.Add(this.lblVolumeShow);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblKanaalShow);
            this.Controls.Add(this.lblKanaal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnKanaalMin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Televisie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnKanaalMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblKanaal;
        private System.Windows.Forms.Label lblKanaalShow;
        private System.Windows.Forms.Label lblVolumeShow;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnKanaalPlus;
        private System.Windows.Forms.Button btnVolumePlus;
        private System.Windows.Forms.Button btnVolumeMin;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnOef3;
    }
}

