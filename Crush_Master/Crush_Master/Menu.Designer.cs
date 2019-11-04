namespace Crush_Master
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
            this.buttonMulty = new System.Windows.Forms.Button();
            this.buttonSolo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMulty
            // 
            this.buttonMulty.Image = global::Crush_Master.Properties.Resources.Setevay;
            this.buttonMulty.Location = new System.Drawing.Point(326, 677);
            this.buttonMulty.Name = "buttonMulty";
            this.buttonMulty.Size = new System.Drawing.Size(302, 100);
            this.buttonMulty.TabIndex = 1;
            this.buttonMulty.UseVisualStyleBackColor = true;
            this.buttonMulty.Click += new System.EventHandler(this.buttonMulty_Click);
            // 
            // buttonSolo
            // 
            this.buttonSolo.Image = global::Crush_Master.Properties.Resources.Odinochka;
            this.buttonSolo.Location = new System.Drawing.Point(326, 550);
            this.buttonSolo.Name = "buttonSolo";
            this.buttonSolo.Size = new System.Drawing.Size(302, 102);
            this.buttonSolo.TabIndex = 0;
            this.buttonSolo.UseVisualStyleBackColor = true;
            this.buttonSolo.Click += new System.EventHandler(this.buttonSolo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Crush_Master.Properties.Resources.image__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 516);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Crush_Master.Properties.Resources.kartinki_zakryit4_копия;
            this.button2.Location = new System.Drawing.Point(970, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Crush_Master.Properties.Resources.Zadnik_menu;
            this.ClientSize = new System.Drawing.Size(1031, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMulty);
            this.Controls.Add(this.buttonSolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSolo;
        private System.Windows.Forms.Button buttonMulty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}