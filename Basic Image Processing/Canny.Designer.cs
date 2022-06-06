
namespace Basic_Image_Processing
{
    partial class Canny
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
            this.tBar_Gx = new System.Windows.Forms.TrackBar();
            this.tBar_Gy = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Gy = new System.Windows.Forms.Label();
            this.lb_Gx = new System.Windows.Forms.Label();
            this.pBox_Canny = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Gx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Gy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Canny)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(47, 432);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 21;
            this.tBox_path.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(750, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(522, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBar_Gx
            // 
            this.tBar_Gx.LargeChange = 50;
            this.tBar_Gx.Location = new System.Drawing.Point(522, 99);
            this.tBar_Gx.Maximum = 200;
            this.tBar_Gx.Minimum = 1;
            this.tBar_Gx.Name = "tBar_Gx";
            this.tBar_Gx.Size = new System.Drawing.Size(362, 56);
            this.tBar_Gx.SmallChange = 10;
            this.tBar_Gx.TabIndex = 22;
            this.tBar_Gx.Value = 1;
            this.tBar_Gx.Scroll += new System.EventHandler(this.tBar_Gx_Scroll);
            // 
            // tBar_Gy
            // 
            this.tBar_Gy.LargeChange = 50;
            this.tBar_Gy.Location = new System.Drawing.Point(522, 231);
            this.tBar_Gy.Maximum = 200;
            this.tBar_Gy.Minimum = 1;
            this.tBar_Gy.Name = "tBar_Gy";
            this.tBar_Gy.Size = new System.Drawing.Size(362, 56);
            this.tBar_Gy.SmallChange = 10;
            this.tBar_Gy.TabIndex = 23;
            this.tBar_Gy.Value = 1;
            this.tBar_Gy.Scroll += new System.EventHandler(this.tB_Gy_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(566, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gx Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(566, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Gy Value";
            // 
            // lb_Gy
            // 
            this.lb_Gy.AutoSize = true;
            this.lb_Gy.Location = new System.Drawing.Point(903, 231);
            this.lb_Gy.Name = "lb_Gy";
            this.lb_Gy.Size = new System.Drawing.Size(16, 17);
            this.lb_Gy.TabIndex = 25;
            this.lb_Gy.Text = "1";
            // 
            // lb_Gx
            // 
            this.lb_Gx.AutoSize = true;
            this.lb_Gx.Location = new System.Drawing.Point(903, 99);
            this.lb_Gx.Name = "lb_Gx";
            this.lb_Gx.Size = new System.Drawing.Size(16, 17);
            this.lb_Gx.TabIndex = 25;
            this.lb_Gx.Text = "1";
            // 
            // pBox_Canny
            // 
            this.pBox_Canny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Canny.Location = new System.Drawing.Point(47, 16);
            this.pBox_Canny.Name = "pBox_Canny";
            this.pBox_Canny.Size = new System.Drawing.Size(450, 450);
            this.pBox_Canny.TabIndex = 18;
            this.pBox_Canny.TabStop = false;
            // 
            // Canny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 490);
            this.Controls.Add(this.lb_Gx);
            this.Controls.Add(this.lb_Gy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBar_Gy);
            this.Controls.Add(this.tBar_Gx);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBox_Canny);
            this.Name = "Canny";
            this.Text = "Canny";
            this.Load += new System.EventHandler(this.Canny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Gx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Gy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Canny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBox_Canny;
        private System.Windows.Forms.TrackBar tBar_Gx;
        private System.Windows.Forms.TrackBar tBar_Gy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Gy;
        private System.Windows.Forms.Label lb_Gx;
    }
}