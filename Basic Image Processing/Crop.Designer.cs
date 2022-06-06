
namespace Basic_Image_Processing
{
    partial class Crop
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
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pBox_notCrop = new System.Windows.Forms.PictureBox();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnSelectArea = new System.Windows.Forms.Button();
            this.pBox_cropped = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_notCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cropped)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(12, 428);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 20;
            this.tBox_path.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pBox_notCrop
            // 
            this.pBox_notCrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_notCrop.Location = new System.Drawing.Point(12, 12);
            this.pBox_notCrop.Name = "pBox_notCrop";
            this.pBox_notCrop.Size = new System.Drawing.Size(450, 450);
            this.pBox_notCrop.TabIndex = 19;
            this.pBox_notCrop.TabStop = false;
            // 
            // btnCrop
            // 
            this.btnCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrop.Location = new System.Drawing.Point(293, 468);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(169, 75);
            this.btnCrop.TabIndex = 22;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelectArea.Location = new System.Drawing.Point(12, 468);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(169, 75);
            this.btnSelectArea.TabIndex = 23;
            this.btnSelectArea.Text = "Select Area";
            this.btnSelectArea.UseVisualStyleBackColor = true;
            this.btnSelectArea.Click += new System.EventHandler(this.btnSelectArea_Click);
            // 
            // pBox_cropped
            // 
            this.pBox_cropped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_cropped.Location = new System.Drawing.Point(511, 12);
            this.pBox_cropped.Name = "pBox_cropped";
            this.pBox_cropped.Size = new System.Drawing.Size(450, 450);
            this.pBox_cropped.TabIndex = 19;
            this.pBox_cropped.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(792, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(511, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Crop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 566);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectArea);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.pBox_cropped);
            this.Controls.Add(this.pBox_notCrop);
            this.Name = "Crop";
            this.Text = "Crop";
            this.Load += new System.EventHandler(this.Crop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_notCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cropped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.PictureBox pBox_notCrop;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnSelectArea;
        private System.Windows.Forms.PictureBox pBox_cropped;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}