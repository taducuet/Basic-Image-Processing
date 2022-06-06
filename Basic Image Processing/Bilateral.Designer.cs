
namespace Basic_Image_Processing
{
    partial class Bilateral
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
            this.lB_Bilateral = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBar_Bilateral = new System.Windows.Forms.TrackBar();
            this.pBox_Bilateral = new System.Windows.Forms.PictureBox();
            this.numSigmaColor = new System.Windows.Forms.NumericUpDown();
            this.numSigmaSpace = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Bilateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Bilateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaSpace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(38, 428);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 37;
            this.tBox_path.Visible = false;
            // 
            // lB_Bilateral
            // 
            this.lB_Bilateral.AutoSize = true;
            this.lB_Bilateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lB_Bilateral.Location = new System.Drawing.Point(405, 65);
            this.lB_Bilateral.Name = "lB_Bilateral";
            this.lB_Bilateral.Size = new System.Drawing.Size(18, 20);
            this.lB_Bilateral.TabIndex = 36;
            this.lB_Bilateral.Text = "1";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(784, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(518, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBar_Bilateral
            // 
            this.tBar_Bilateral.Location = new System.Drawing.Point(6, 65);
            this.tBar_Bilateral.Maximum = 30;
            this.tBar_Bilateral.Name = "tBar_Bilateral";
            this.tBar_Bilateral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tBar_Bilateral.Size = new System.Drawing.Size(393, 56);
            this.tBar_Bilateral.TabIndex = 33;
            this.tBar_Bilateral.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBar_Bilateral.Scroll += new System.EventHandler(this.tBar_gaussBlur_Scroll);
            // 
            // pBox_Bilateral
            // 
            this.pBox_Bilateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Bilateral.Location = new System.Drawing.Point(38, 12);
            this.pBox_Bilateral.Name = "pBox_Bilateral";
            this.pBox_Bilateral.Size = new System.Drawing.Size(450, 450);
            this.pBox_Bilateral.TabIndex = 32;
            this.pBox_Bilateral.TabStop = false;
            // 
            // numSigmaColor
            // 
            this.numSigmaColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numSigmaColor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSigmaColor.Location = new System.Drawing.Point(20, 179);
            this.numSigmaColor.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSigmaColor.Name = "numSigmaColor";
            this.numSigmaColor.Size = new System.Drawing.Size(208, 26);
            this.numSigmaColor.TabIndex = 39;
            this.numSigmaColor.ValueChanged += new System.EventHandler(this.numSigmaColor_ValueChanged);
            // 
            // numSigmaSpace
            // 
            this.numSigmaSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numSigmaSpace.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSigmaSpace.Location = new System.Drawing.Point(20, 289);
            this.numSigmaSpace.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSigmaSpace.Name = "numSigmaSpace";
            this.numSigmaSpace.Size = new System.Drawing.Size(208, 26);
            this.numSigmaSpace.TabIndex = 40;
            this.numSigmaSpace.ValueChanged += new System.EventHandler(this.numSigmaSpace_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Sigma Space";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Sigma Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBar_Bilateral);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numSigmaSpace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lB_Bilateral);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numSigmaColor);
            this.groupBox1.Location = new System.Drawing.Point(518, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 343);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // Bilateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBox_Bilateral);
            this.Name = "Bilateral";
            this.Text = "Bilateral";
            this.Load += new System.EventHandler(this.Bilateral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Bilateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Bilateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaSpace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Label lB_Bilateral;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar tBar_Bilateral;
        private System.Windows.Forms.PictureBox pBox_Bilateral;
        private System.Windows.Forms.NumericUpDown numSigmaColor;
        private System.Windows.Forms.NumericUpDown numSigmaSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}