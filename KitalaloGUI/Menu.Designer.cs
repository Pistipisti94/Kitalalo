namespace KitalaloGUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_jatek = new System.Windows.Forms.Button();
            this.button_nehezseg = new System.Windows.Forms.Button();
            this.button_kilepes = new System.Windows.Forms.Button();
            this.groupBox_nehezseg = new System.Windows.Forms.GroupBox();
            this.radioButton_konnyu = new System.Windows.Forms.RadioButton();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_nehez = new System.Windows.Forms.RadioButton();
            this.button_vissza = new System.Windows.Forms.Button();
            this.button_kivalaszt = new System.Windows.Forms.Button();
            this.label_nehezseg = new System.Windows.Forms.Label();
            this.groupBox_nehezseg.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_jatek
            // 
            this.button_jatek.Location = new System.Drawing.Point(66, 52);
            this.button_jatek.Name = "button_jatek";
            this.button_jatek.Size = new System.Drawing.Size(160, 43);
            this.button_jatek.TabIndex = 0;
            this.button_jatek.Text = "Játék";
            this.button_jatek.UseVisualStyleBackColor = true;
            this.button_jatek.Click += new System.EventHandler(this.button_jatek_Click);
            // 
            // button_nehezseg
            // 
            this.button_nehezseg.Location = new System.Drawing.Point(66, 117);
            this.button_nehezseg.Name = "button_nehezseg";
            this.button_nehezseg.Size = new System.Drawing.Size(160, 43);
            this.button_nehezseg.TabIndex = 1;
            this.button_nehezseg.Text = "Nehézség";
            this.button_nehezseg.UseVisualStyleBackColor = true;
            this.button_nehezseg.Click += new System.EventHandler(this.button_nehezseg_Click);
            // 
            // button_kilepes
            // 
            this.button_kilepes.Location = new System.Drawing.Point(66, 188);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(160, 43);
            this.button_kilepes.TabIndex = 2;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = true;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // groupBox_nehezseg
            // 
            this.groupBox_nehezseg.Controls.Add(this.radioButton_nehez);
            this.groupBox_nehezseg.Controls.Add(this.radioButton_normal);
            this.groupBox_nehezseg.Controls.Add(this.radioButton_konnyu);
            this.groupBox_nehezseg.Location = new System.Drawing.Point(43, 29);
            this.groupBox_nehezseg.Name = "groupBox_nehezseg";
            this.groupBox_nehezseg.Size = new System.Drawing.Size(200, 100);
            this.groupBox_nehezseg.TabIndex = 3;
            this.groupBox_nehezseg.TabStop = false;
            this.groupBox_nehezseg.Text = "Nehézség:";
            // 
            // radioButton_konnyu
            // 
            this.radioButton_konnyu.AutoSize = true;
            this.radioButton_konnyu.Checked = true;
            this.radioButton_konnyu.Location = new System.Drawing.Point(23, 23);
            this.radioButton_konnyu.Name = "radioButton_konnyu";
            this.radioButton_konnyu.Size = new System.Drawing.Size(61, 17);
            this.radioButton_konnyu.TabIndex = 0;
            this.radioButton_konnyu.TabStop = true;
            this.radioButton_konnyu.Text = "Könnyű";
            this.radioButton_konnyu.UseVisualStyleBackColor = true;
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Location = new System.Drawing.Point(23, 46);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_normal.TabIndex = 1;
            this.radioButton_normal.Text = "Normál";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            // 
            // radioButton_nehez
            // 
            this.radioButton_nehez.AutoSize = true;
            this.radioButton_nehez.Location = new System.Drawing.Point(23, 69);
            this.radioButton_nehez.Name = "radioButton_nehez";
            this.radioButton_nehez.Size = new System.Drawing.Size(56, 17);
            this.radioButton_nehez.TabIndex = 2;
            this.radioButton_nehez.Text = "Nehéz";
            this.radioButton_nehez.UseVisualStyleBackColor = true;
            // 
            // button_vissza
            // 
            this.button_vissza.Location = new System.Drawing.Point(66, 251);
            this.button_vissza.Name = "button_vissza";
            this.button_vissza.Size = new System.Drawing.Size(160, 34);
            this.button_vissza.TabIndex = 4;
            this.button_vissza.Text = "Vissza";
            this.button_vissza.UseVisualStyleBackColor = true;
            this.button_vissza.Click += new System.EventHandler(this.button_vissza_Click);
            // 
            // button_kivalaszt
            // 
            this.button_kivalaszt.Location = new System.Drawing.Point(66, 166);
            this.button_kivalaszt.Name = "button_kivalaszt";
            this.button_kivalaszt.Size = new System.Drawing.Size(160, 43);
            this.button_kivalaszt.TabIndex = 5;
            this.button_kivalaszt.Text = "Kiválasztás";
            this.button_kivalaszt.UseVisualStyleBackColor = true;
            this.button_kivalaszt.Click += new System.EventHandler(this.button_kivalaszt_Click);
            // 
            // label_nehezseg
            // 
            this.label_nehezseg.AutoSize = true;
            this.label_nehezseg.Location = new System.Drawing.Point(40, 9);
            this.label_nehezseg.Name = "label_nehezseg";
            this.label_nehezseg.Size = new System.Drawing.Size(161, 13);
            this.label_nehezseg.TabIndex = 6;
            this.label_nehezseg.Text = "A kiválasztott nehézség: Könnyű";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 297);
            this.Controls.Add(this.label_nehezseg);
            this.Controls.Add(this.button_kivalaszt);
            this.Controls.Add(this.button_vissza);
            this.Controls.Add(this.groupBox_nehezseg);
            this.Controls.Add(this.button_kilepes);
            this.Controls.Add(this.button_nehezseg);
            this.Controls.Add(this.button_jatek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox_nehezseg.ResumeLayout(false);
            this.groupBox_nehezseg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_jatek;
        private System.Windows.Forms.Button button_nehezseg;
        private System.Windows.Forms.Button button_kilepes;
        private System.Windows.Forms.GroupBox groupBox_nehezseg;
        private System.Windows.Forms.RadioButton radioButton_nehez;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButton_konnyu;
        private System.Windows.Forms.Button button_vissza;
        private System.Windows.Forms.Button button_kivalaszt;
        private System.Windows.Forms.Label label_nehezseg;
    }
}