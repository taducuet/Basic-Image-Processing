
namespace Basic_Image_Processing
{
    partial class GaussianBlur
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
            this.lB_blur = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBar_gaussBlur = new System.Windows.Forms.TrackBar();
            this.pBox_gaussBlur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_gaussBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_gaussBlur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(241, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Value";
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
            // lB_blur
            // 
            this.lB_blur.AutoSize = true;
            this.lB_blur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lB_blur.Location = new System.Drawing.Point(526, 511);
            this.lB_blur.Name = "lB_blur";
            this.lB_blur.Size = new System.Drawing.Size(18, 20);
            this.lB_blur.TabIndex = 16;
            this.lB_blur.Text = "1";
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
            // tBar_gaussBlur
            // 
            this.tBar_gaussBlur.Location = new System.Drawing.Point(38, 511);
            this.tBar_gaussBlur.Maximum = 50;
            this.tBar_gaussBlur.Minimum = 1;
            this.tBar_gaussBlur.Name = "tBar_gaussBlur";
            this.tBar_gaussBlur.Size = new System.Drawing.Size(459, 56);
            this.tBar_gaussBlur.TabIndex = 13;
            this.tBar_gaussBlur.Value = 1;
            this.tBar_gaussBlur.Scroll += new System.EventHandler(this.tBar_gaussBlur_Scroll);
            // 
            // pBox_gaussBlur
            // 
            this.pBox_gaussBlur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_gaussBlur.Location = new System.Drawing.Point(38, 12);
            this.pBox_gaussBlur.Name = "pBox_gaussBlur";
            this.pBox_gaussBlur.Size = new System.Drawing.Size(450, 450);
            this.pBox_gaussBlur.TabIndex = 12;
            this.pBox_gaussBlur.TabStop = false;
            // 
            // GaussianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.lB_blur);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBar_gaussBlur);
            this.Controls.Add(this.pBox_gaussBlur);
            this.Name = "GaussianBlur";
            this.Text = "Gaussian Blur";
            this.Load += new System.EventHandler(this.GaussianBlur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBar_gaussBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_gaussBlur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Label lB_blur;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar tBar_gaussBlur;
        private System.Windows.Forms.PictureBox pBox_gaussBlur;
    }
}