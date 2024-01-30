namespace KitalaloGUI
{
    partial class Kitalalo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitalalo));
            this.label_elet = new System.Windows.Forms.Label();
            this.label_randomszo = new System.Windows.Forms.Label();
            this.label_teszt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_elet
            // 
            this.label_elet.AutoSize = true;
            this.label_elet.Location = new System.Drawing.Point(12, 9);
            this.label_elet.Name = "label_elet";
            this.label_elet.Size = new System.Drawing.Size(73, 13);
            this.label_elet.TabIndex = 0;
            this.label_elet.Text = "Életek száma:";
            // 
            // label_randomszo
            // 
            this.label_randomszo.AutoSize = true;
            this.label_randomszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_randomszo.Location = new System.Drawing.Point(260, 168);
            this.label_randomszo.Name = "label_randomszo";
            this.label_randomszo.Size = new System.Drawing.Size(272, 42);
            this.label_randomszo.TabIndex = 1;
            this.label_randomszo.Text = "Kitalálandó szó";
            // 
            // label_teszt
            // 
            this.label_teszt.AutoSize = true;
            this.label_teszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_teszt.Location = new System.Drawing.Point(260, 280);
            this.label_teszt.Name = "label_teszt";
            this.label_teszt.Size = new System.Drawing.Size(97, 42);
            this.label_teszt.TabIndex = 2;
            this.label_teszt.Text = "teszt";
            // 
            // Kitalalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_teszt);
            this.Controls.Add(this.label_randomszo);
            this.Controls.Add(this.label_elet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kitalalo";
            this.Text = "Kitaláló";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kitalalo_FormClosed);
            this.Load += new System.EventHandler(this.Kitalalo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_elet;
        private System.Windows.Forms.Label label_randomszo;
        private System.Windows.Forms.Label label_teszt;
    }
}

