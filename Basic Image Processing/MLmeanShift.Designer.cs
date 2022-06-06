
namespace Basic_Image_Processing
{
    partial class MLmeanShift
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
            this.pBox_mshift = new System.Windows.Forms.PictureBox();
            this.numBandwitdh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_mshift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBandwitdh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(37, 435);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 46;
            this.tBox_path.Visible = false;
            // 
            // pBox_mshift
            // 
            this.pBox_mshift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_mshift.Location = new System.Drawing.Point(37, 19);
            this.pBox_mshift.Name = "pBox_mshift";
            this.pBox_mshift.Size = new System.Drawing.Size(450, 450);
            this.pBox_mshift.TabIndex = 43;
            this.pBox_mshift.TabStop = false;
            // 
            // numBandwitdh
            // 
            this.numBandwitdh.DecimalPlaces = 2;
            this.numBandwitdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numBandwitdh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBandwitdh.Location = new System.Drawing.Point(100, 40);
            this.numBandwitdh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBandwitdh.Name = "numBandwitdh";
            this.numBandwitdh.Size = new System.Drawing.Size(120, 26);
            this.numBandwitdh.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Bandwidth";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numBandwitdh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(521, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRun.Location = new System.Drawing.Point(554, 162);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(169, 75);
            this.btnRun.TabIndex = 47;
            this.btnRun.Text = "Run MeanShift";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(554, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(554, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MeanShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 489);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.pBox_mshift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Name = "MeanShift";
            this.Text = "MeanShift";
            this.Load += new System.EventHandler(this.MeanShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_mshift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBandwitdh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.PictureBox pBox_mshift;
        private System.Windows.Forms.NumericUpDown numBandwitdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}