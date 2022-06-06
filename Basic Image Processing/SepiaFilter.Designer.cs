
namespace Basic_Image_Processing
{
    partial class SepiaFilter
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
            this.btnSepiaFilter = new System.Windows.Forms.Button();
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBox_SepiaFilter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_SepiaFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSepiaFilter
            // 
            this.btnSepiaFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSepiaFilter.Location = new System.Drawing.Point(574, 18);
            this.btnSepiaFilter.Name = "btnSepiaFilter";
            this.btnSepiaFilter.Size = new System.Drawing.Size(169, 75);
            this.btnSepiaFilter.TabIndex = 23;
            this.btnSepiaFilter.Text = "Sepia Filter";
            this.btnSepiaFilter.UseVisualStyleBackColor = true;
            this.btnSepiaFilter.Click += new System.EventHandler(this.btnSepiaFilter_Click);
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(40, 434);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 22;
            this.tBox_path.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(574, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(574, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pBox_SepiaFilter
            // 
            this.pBox_SepiaFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_SepiaFilter.Location = new System.Drawing.Point(40, 18);
            this.pBox_SepiaFilter.Name = "pBox_SepiaFilter";
            this.pBox_SepiaFilter.Size = new System.Drawing.Size(450, 450);
            this.pBox_SepiaFilter.TabIndex = 19;
            this.pBox_SepiaFilter.TabStop = false;
            // 
            // SepiaFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 487);
            this.Controls.Add(this.btnSepiaFilter);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBox_SepiaFilter);
            this.Name = "SepiaFilter";
            this.Text = "SepiaFilter";
            this.Load += new System.EventHandler(this.SepiaFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_SepiaFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSepiaFilter;
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBox_SepiaFilter;
    }
}