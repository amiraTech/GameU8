
namespace GameU8
{
    partial class optionPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAudio = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameU8.Properties.Resources.option_menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.pbAudio);
            this.panel1.Controls.Add(this.trackBarVolume);
            this.panel1.Location = new System.Drawing.Point(57, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 421);
            this.panel1.TabIndex = 0;
            // 
            // pbAudio
            // 
            this.pbAudio.BackgroundImage = global::GameU8.Properties.Resources.sound_on;
            this.pbAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAudio.Location = new System.Drawing.Point(153, 212);
            this.pbAudio.Name = "pbAudio";
            this.pbAudio.Size = new System.Drawing.Size(67, 54);
            this.pbAudio.TabIndex = 1;
            this.pbAudio.TabStop = false;
            this.pbAudio.Click += new System.EventHandler(this.pbAudio_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(90, 146);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(197, 45);
            this.trackBarVolume.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(105, 297);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 52);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // optionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(506, 502);
            this.Controls.Add(this.panel1);
            this.Name = "optionPage";
            this.Text = "optionPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.PictureBox pbAudio;
        private System.Windows.Forms.Button btnBack;
    }
}