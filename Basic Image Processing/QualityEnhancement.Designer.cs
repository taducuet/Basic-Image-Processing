
namespace Basic_Image_Processing
{
    partial class QualityEnhancement
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
            this.lb_alpha = new System.Windows.Forms.Label();
            this.lb_beta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBar_beta = new System.Windows.Forms.TrackBar();
            this.tBar_alpha = new System.Windows.Forms.TrackBar();
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBox_Enhance = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBar_gamma = new System.Windows.Forms.TrackBar();
            this.lb_gamma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_beta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Enhance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_gamma)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_alpha
            // 
            this.lb_alpha.AutoSize = true;
            this.lb_alpha.Location = new System.Drawing.Point(888, 44);
            this.lb_alpha.Name = "lb_alpha";
            this.lb_alpha.Size = new System.Drawing.Size(16, 17);
            this.lb_alpha.TabIndex = 34;
            this.lb_alpha.Text = "1";
            // 
            // lb_beta
            // 
            this.lb_beta.AutoSize = true;
            this.lb_beta.Location = new System.Drawing.Point(888, 124);
            this.lb_beta.Name = "lb_beta";
            this.lb_beta.Size = new System.Drawing.Size(16, 17);
            this.lb_beta.TabIndex = 35;
            this.lb_beta.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(517, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Constrast(β)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(517, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Brightness(α)";
            // 
            // tBar_beta
            // 
            this.tBar_beta.Location = new System.Drawing.Point(507, 124);
            this.tBar_beta.Maximum = 50;
            this.tBar_beta.Name = "tBar_beta";
            this.tBar_beta.Size = new System.Drawing.Size(362, 56);
            this.tBar_beta.TabIndex = 31;
            this.tBar_beta.Value = 1;
            this.tBar_beta.Scroll += new System.EventHandler(this.tBar_beta_Scroll);
            // 
            // tBar_alpha
            // 
            this.tBar_alpha.Location = new System.Drawing.Point(507, 44);
            this.tBar_alpha.Maximum = 20;
            this.tBar_alpha.Name = "tBar_alpha";
            this.tBar_alpha.Size = new System.Drawing.Size(362, 56);
            this.tBar_alpha.TabIndex = 30;
            this.tBar_alpha.Value = 1;
            this.tBar_alpha.Scroll += new System.EventHandler(this.tBar_alpha_Scroll);
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(41, 436);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 29;
            this.tBox_path.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(744, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(516, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pBox_Enhance
            // 
            this.pBox_Enhance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Enhance.Location = new System.Drawing.Point(41, 20);
            this.pBox_Enhance.Name = "pBox_Enhance";
            this.pBox_Enhance.Size = new System.Drawing.Size(450, 450);
            this.pBox_Enhance.TabIndex = 26;
            this.pBox_Enhance.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(517, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Gamma(γ)";
            // 
            // tBar_gamma
            // 
            this.tBar_gamma.LargeChange = 50;
            this.tBar_gamma.Location = new System.Drawing.Point(507, 206);
            this.tBar_gamma.Maximum = 200;
            this.tBar_gamma.Minimum = 1;
            this.tBar_gamma.Name = "tBar_gamma";
            this.tBar_gamma.Size = new System.Drawing.Size(362, 56);
            this.tBar_gamma.SmallChange = 10;
            this.tBar_gamma.TabIndex = 36;
            this.tBar_gamma.Value = 1;
            this.tBar_gamma.Scroll += new System.EventHandler(this.tBar_gamma_Scroll);
            // 
            // lb_gamma
            // 
            this.lb_gamma.AutoSize = true;
            this.lb_gamma.Location = new System.Drawing.Point(888, 206);
            this.lb_gamma.Name = "lb_gamma";
            this.lb_gamma.Size = new System.Drawing.Size(16, 17);
            this.lb_gamma.TabIndex = 38;
            this.lb_gamma.Text = "1";
            // 
            // QualityEnhancement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 490);
            this.Controls.Add(this.lb_gamma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBar_gamma);
            this.Controls.Add(this.lb_alpha);
            this.Controls.Add(this.lb_beta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBar_beta);
            this.Controls.Add(this.tBar_alpha);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pBox_Enhance);
            this.Name = "QualityEnhancement";
            this.Text = "QualityEnhancement";
            ((System.ComponentModel.ISupportInitialize)(this.tBar_beta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Enhance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_gamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_alpha;
        private System.Windows.Forms.Label lb_beta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tBar_beta;
        private System.Windows.Forms.TrackBar tBar_alpha;
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pBox_Enhance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tBar_gamma;
        private System.Windows.Forms.Label lb_gamma;
    }
}