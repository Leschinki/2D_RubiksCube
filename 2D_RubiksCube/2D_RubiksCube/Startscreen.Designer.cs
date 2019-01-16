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
            this.SuspendLayout();
            // 
            // _btnChoosePicture
            // 
            this._btnChoosePicture.Location = new System.Drawing.Point(92, 41);
            this._btnChoosePicture.Name = "_btnChoosePicture";
            this._btnChoosePicture.Size = new System.Drawing.Size(152, 74);
            this._btnChoosePicture.TabIndex = 0;
            this._btnChoosePicture.Text = "Choose Picture";
            this._btnChoosePicture.UseVisualStyleBackColor = true;
            this._btnChoosePicture.Click += new System.EventHandler(this.OnChoosePicture);
            // 
            // Startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 152);
            this.Controls.Add(this._btnChoosePicture);
            this.Name = "Startscreen";
            this.Text = "Startscreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnChoosePicture;
    }
}