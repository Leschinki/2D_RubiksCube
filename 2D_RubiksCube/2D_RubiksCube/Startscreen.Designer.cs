namespace _2D_RubiksCube
{
    partial class Startscreen
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
            this._btnChoosePicture = new System.Windows.Forms.Button();
            this.upDownBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnChoosePicture
            // 
            this._btnChoosePicture.Location = new System.Drawing.Point(126, 42);
            this._btnChoosePicture.Name = "_btnChoosePicture";
            this._btnChoosePicture.Size = new System.Drawing.Size(152, 74);
            this._btnChoosePicture.TabIndex = 0;
            this._btnChoosePicture.Text = "Choose Picture";
            this._btnChoosePicture.UseVisualStyleBackColor = true;
            this._btnChoosePicture.Click += new System.EventHandler(this.OnChoosePicture);
            // 
            // upDownBox
            // 
            this.upDownBox.Location = new System.Drawing.Point(15, 100);
            this.upDownBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upDownBox.Name = "upDownBox";
            this.upDownBox.Size = new System.Drawing.Size(41, 20);
            this.upDownBox.TabIndex = 1;
            this.upDownBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upDownBox.ValueChanged += new System.EventHandler(this.OnGridSizeChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRIDSIZE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMAGESIZE:";
            // 
            // SizeUpDown
            // 
            this.SizeUpDown.Location = new System.Drawing.Point(15, 43);
            this.SizeUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SizeUpDown.Name = "SizeUpDown";
            this.SizeUpDown.Size = new System.Drawing.Size(41, 20);
            this.SizeUpDown.TabIndex = 3;
            this.SizeUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SizeUpDown.ValueChanged += new System.EventHandler(this.SizeValueChanged);
            // 
            // Startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDownBox);
            this.Controls.Add(this._btnChoosePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Startscreen";
            this.Text = "Startscreen";
            ((System.ComponentModel.ISupportInitialize)(this.upDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnChoosePicture;
        private System.Windows.Forms.NumericUpDown upDownBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SizeUpDown;
    }
}