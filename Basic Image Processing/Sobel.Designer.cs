
namespace Basic_Image_Processing
{
    partial class Sobel
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
            this.pBox_Sobel = new System.Windows.Forms.PictureBox();
            this.btn_Sobel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Sobel)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(38, 428);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 24;
            this.tBox_path.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(575, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(575, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pBox_Sobel
            // 
            this.pBox_Sobel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Sobel.Location = new System.Drawing.Point(38, 12);
            this.pBox_Sobel.Name = "pBox_Sobel";
            this.pBox_Sobel.Size = new System.Drawing.Size(450, 450);
            this.pBox_Sobel.TabIndex = 19;
            this.pBox_Sobel.TabStop = false;
            // 
            // btn_Sobel
            // 
            this.btn_Sobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Sobel.Location = new System.Drawing.Point(575, 12);
            this.btn_Sobel.Name = "btn_Sobel";
            this.btn_Sobel.Size = new System.Drawing.Size(169, 75);
            this.btn_Sobel.TabIndex = 25;
            this.btn_Sobel.Text = "Edge Detect";
            this.btn_Sobel.UseVisualStyleBackColor = true;
            this.btn_Sobel.Click += new System.EventHandler(this.btn_Sobel_Click);
            // 
            // Sobel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 487);
            this.Controls.Add(this.btn_Sobel);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBox_Sobel);
            this.Name = "Sobel";
            this.Text = "Sobel";
            this.Load += new System.EventHandler(this.Sobel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Sobel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBox_Sobel;
        private System.Windows.Forms.Button btn_Sobel;
    }
}