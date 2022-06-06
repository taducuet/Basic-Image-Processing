
namespace Basic_Image_Processing
{
    partial class GaussianFilter
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
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBox_GaussianFilter = new System.Windows.Forms.PictureBox();
            this.btnGaussFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_GaussianFilter)).BeginInit();
            this.SuspendLayout();
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
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(572, 237);
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
            this.btnSave.Location = new System.Drawing.Point(572, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pBox_GaussianFilter
            // 
            this.pBox_GaussianFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_GaussianFilter.Location = new System.Drawing.Point(38, 12);
            this.pBox_GaussianFilter.Name = "pBox_GaussianFilter";
            this.pBox_GaussianFilter.Size = new System.Drawing.Size(450, 450);
            this.pBox_GaussianFilter.TabIndex = 12;
            this.pBox_GaussianFilter.TabStop = false;
            // 
            // btnGaussFilter
            // 
            this.btnGaussFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGaussFilter.Location = new System.Drawing.Point(572, 12);
            this.btnGaussFilter.Name = "btnGaussFilter";
            this.btnGaussFilter.Size = new System.Drawing.Size(169, 75);
            this.btnGaussFilter.TabIndex = 18;
            this.btnGaussFilter.Text = "Gaussian Filter";
            this.btnGaussFilter.UseVisualStyleBackColor = true;
            this.btnGaussFilter.Click += new System.EventHandler(this.btnGaussFilter_Click);
            // 
            // GaussianFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 487);
            this.Controls.Add(this.btnGaussFilter);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBox_GaussianFilter);
            this.Name = "GaussianFilter";
            this.Text = "GaussianFilter";
            this.Load += new System.EventHandler(this.GaussianFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_GaussianFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBox_GaussianFilter;
        private System.Windows.Forms.Button btnGaussFilter;
    }
}