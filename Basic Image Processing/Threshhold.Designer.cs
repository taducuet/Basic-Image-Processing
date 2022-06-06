
namespace Basic_Image_Processing
{
    partial class Threshhold
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
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.lB_threshold = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBar_threshold = new System.Windows.Forms.TrackBar();
            this.pBox_threshold = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(241, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Threshold";
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(38, 428);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 17;
            this.tBox_path.Visible = false;
            // 
            // lB_threshold
            // 
            this.lB_threshold.AutoSize = true;
            this.lB_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lB_threshold.Location = new System.Drawing.Point(526, 511);
            this.lB_threshold.Name = "lB_threshold";
            this.lB_threshold.Size = new System.Drawing.Size(18, 20);
            this.lB_threshold.TabIndex = 16;
            this.lB_threshold.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(575, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(575, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBar_threshold
            // 
            this.tBar_threshold.Location = new System.Drawing.Point(38, 511);
            this.tBar_threshold.Maximum = 255;
            this.tBar_threshold.Name = "tBar_threshold";
            this.tBar_threshold.Size = new System.Drawing.Size(459, 56);
            this.tBar_threshold.TabIndex = 7;
            this.tBar_threshold.Scroll += new System.EventHandler(this.tBar_threshold_Scroll);
            // 
            // pBox_threshold
            // 
            this.pBox_threshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_threshold.Location = new System.Drawing.Point(38, 12);
            this.pBox_threshold.Name = "pBox_threshold";
            this.pBox_threshold.Size = new System.Drawing.Size(450, 450);
            this.pBox_threshold.TabIndex = 12;
            this.pBox_threshold.TabStop = false;
            // 
            // Threshhold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.lB_threshold);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBar_threshold);
            this.Controls.Add(this.pBox_threshold);
            this.Name = "Threshhold";
            this.Text = "Threshhold";
            this.Load += new System.EventHandler(this.Threshhold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBar_threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Label lB_threshold;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar tBar_threshold;
        private System.Windows.Forms.PictureBox pBox_threshold;
    }
}