
namespace Senin_Valon
{
    partial class pencere
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pencere));
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.spike = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.spike)).BeginInit();
            this.SuspendLayout();
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 585);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 127);
            this.label1.TabIndex = 1;
            this.label1.Text = "45";
            // 
            // spike
            // 
            this.spike.Image = ((System.Drawing.Image)(resources.GetObject("spike.Image")));
            this.spike.Location = new System.Drawing.Point(37, 12);
            this.spike.Name = "spike";
            this.spike.Size = new System.Drawing.Size(306, 535);
            this.spike.TabIndex = 3;
            this.spike.TabStop = false;
            this.spike.Click += new System.EventHandler(this.spike_Click);
            this.spike.DoubleClick += new System.EventHandler(this.spike_DoubleClick);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(37, 706);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Maximum = 46;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // pencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 761);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.spike);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senin Valon";
            this.Load += new System.EventHandler(this.pencere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox spike;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

