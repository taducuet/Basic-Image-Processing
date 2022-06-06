
namespace Basic_Image_Processing
{
    partial class ColorConvert
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
            this.cBoxColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.pBox_cvtColor = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cvtColor)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxColor
            // 
            this.cBoxColor.FormattingEnabled = true;
            this.cBoxColor.Items.AddRange(new object[] {
            "Red Channel",
            "Green Channel",
            "Blue Channel",
            "Gray Image"});
            this.cBoxColor.Location = new System.Drawing.Point(495, 91);
            this.cBoxColor.Name = "cBoxColor";
            this.cBoxColor.Size = new System.Drawing.Size(261, 24);
            this.cBoxColor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(568, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Convert Color";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(546, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(546, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(12, 475);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 18;
            this.tBox_path.Visible = false;
            // 
            // pBox_cvtColor
            // 
            this.pBox_cvtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_cvtColor.Location = new System.Drawing.Point(12, 59);
            this.pBox_cvtColor.Name = "pBox_cvtColor";
            this.pBox_cvtColor.Size = new System.Drawing.Size(450, 450);
            this.pBox_cvtColor.TabIndex = 13;
            this.pBox_cvtColor.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConvert.Location = new System.Drawing.Point(546, 211);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(169, 75);
            this.btnConvert.TabIndex = 16;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ColorConvert
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 579);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxColor);
            this.Controls.Add(this.pBox_cvtColor);
            this.Name = "ColorConvert";
            this.Text = "ColorConvert";
            this.Load += new System.EventHandler(this.ColorConvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cvtColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_cvtColor;
        private System.Windows.Forms.ComboBox cBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Button btnConvert;
    }
}