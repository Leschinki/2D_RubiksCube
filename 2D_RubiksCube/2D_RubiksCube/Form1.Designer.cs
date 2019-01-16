namespace _2D_RubiksCube
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnRow1Right = new System.Windows.Forms.Button();
            this._btnRow3Right = new System.Windows.Forms.Button();
            this._btnRow2Right = new System.Windows.Forms.Button();
            this._btnRow1Left = new System.Windows.Forms.Button();
            this._btnRow3Left = new System.Windows.Forms.Button();
            this._btnRow2Left = new System.Windows.Forms.Button();
            this._btnColumn3Up = new System.Windows.Forms.Button();
            this._btnColumn1Up = new System.Windows.Forms.Button();
            this._btnColumn2Up = new System.Windows.Forms.Button();
            this._btnColumn2DOwn = new System.Windows.Forms.Button();
            this._btnColumn1Down = new System.Windows.Forms.Button();
            this._btnColumn3Down = new System.Windows.Forms.Button();
            this._panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _btnRow1Right
            // 
            this._btnRow1Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRow1Right.Location = new System.Drawing.Point(407, 109);
            this._btnRow1Right.Name = "_btnRow1Right";
            this._btnRow1Right.Size = new System.Drawing.Size(75, 75);
            this._btnRow1Right.TabIndex = 0;
            this._btnRow1Right.Text = ">";
            this._btnRow1Right.UseVisualStyleBackColor = true;
            this._btnRow1Right.Click += new System.EventHandler(this.MoveRight);
            // 
            // _btnRow3Right
            // 
            this._btnRow3Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRow3Right.Location = new System.Drawing.Point(407, 334);
            this._btnRow3Right.Name = "_btnRow3Right";
            this._btnRow3Right.Size = new System.Drawing.Size(75, 75);
            this._btnRow3Right.TabIndex = 1;
            this._btnRow3Right.Text = ">";
            this._btnRow3Right.UseVisualStyleBackColor = true;
            this._btnRow3Right.Click += new System.EventHandler(this.MoveRight);
            // 
            // _btnRow2Right
            // 
            this._btnRow2Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRow2Right.Location = new System.Drawing.Point(407, 222);
            this._btnRow2Right.Name = "_btnRow2Right";
            this._btnRow2Right.Size = new System.Drawing.Size(75, 75);
            this._btnRow2Right.TabIndex = 2;
            this._btnRow2Right.Text = ">";
            this._btnRow2Right.UseVisualStyleBackColor = true;
            this._btnRow2Right.Click += new System.EventHandler(this.MoveRight);
            // 
            // _btnRow1Left
            // 
            this._btnRow1Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRow1Left.Location = new System.Drawing.Point(20, 109);
            this._btnRow1Left.Name = "_btnRow1Left";
            this._btnRow1Left.Size = new System.Drawing.Size(75, 75);
            this._btnRow1Left.TabIndex = 3;
            this._btnRow1Left.Text = "<";
            this._btnRow1Left.UseVisualStyleBackColor = true;
            this._btnRow1Left.Click += new System.EventHandler(this.MoveLeft);
            // 
            // _btnRow3Left
            // 
            this._btnRow3Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRow3Left.Location = new System.Drawing.Point(20, 334);
            this._btnRow3Left.Name = "_btnRow3Left";
            this._btnRow3Left.Size = new System.Drawing.Size(75, 75);
            this._btnRow3Left.TabIndex = 4;
            this._btnRow3Left.Text = "<";
            this._btnRow3Left.UseVisualStyleBackColor = true;
            this._btnRow3Left.Click += new System.EventHandler(this.MoveLeft);
            // 
            // _btnRow2Left
            // 
            this._btnRow2Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRow2Left.Location = new System.Drawing.Point(20, 222);
            this._btnRow2Left.Name = "_btnRow2Left";
            this._btnRow2Left.Size = new System.Drawing.Size(75, 75);
            this._btnRow2Left.TabIndex = 5;
            this._btnRow2Left.Text = "<";
            this._btnRow2Left.UseVisualStyleBackColor = true;
            this._btnRow2Left.Click += new System.EventHandler(this.MoveLeft);
            // 
            // _btnColumn3Up
            // 
            this._btnColumn3Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnColumn3Up.Location = new System.Drawing.Point(326, 28);
            this._btnColumn3Up.Name = "_btnColumn3Up";
            this._btnColumn3Up.Size = new System.Drawing.Size(75, 75);
            this._btnColumn3Up.TabIndex = 6;
            this._btnColumn3Up.Text = "+";
            this._btnColumn3Up.UseVisualStyleBackColor = true;
            this._btnColumn3Up.Click += new System.EventHandler(this.MoveUp);
            // 
            // _btnColumn1Up
            // 
            this._btnColumn1Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnColumn1Up.Location = new System.Drawing.Point(101, 28);
            this._btnColumn1Up.Name = "_btnColumn1Up";
            this._btnColumn1Up.Size = new System.Drawing.Size(75, 75);
            this._btnColumn1Up.TabIndex = 7;
            this._btnColumn1Up.Text = "+";
            this._btnColumn1Up.UseVisualStyleBackColor = true;
            this._btnColumn1Up.Click += new System.EventHandler(this.MoveUp);
            // 
            // _btnColumn2Up
            // 
            this._btnColumn2Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnColumn2Up.Location = new System.Drawing.Point(220, 28);
            this._btnColumn2Up.Name = "_btnColumn2Up";
            this._btnColumn2Up.Size = new System.Drawing.Size(75, 75);
            this._btnColumn2Up.TabIndex = 8;
            this._btnColumn2Up.Text = "+";
            this._btnColumn2Up.UseVisualStyleBackColor = true;
            this._btnColumn2Up.Click += new System.EventHandler(this.MoveUp);
            // 
            // _btnColumn2DOwn
            // 
            this._btnColumn2DOwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnColumn2DOwn.Location = new System.Drawing.Point(220, 415);
            this._btnColumn2DOwn.Name = "_btnColumn2DOwn";
            this._btnColumn2DOwn.Size = new System.Drawing.Size(75, 75);
            this._btnColumn2DOwn.TabIndex = 11;
            this._btnColumn2DOwn.Text = "-";
            this._btnColumn2DOwn.UseVisualStyleBackColor = true;
            this._btnColumn2DOwn.Click += new System.EventHandler(this.MoveDown);
            // 
            // _btnColumn1Down
            // 
            this._btnColumn1Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnColumn1Down.Location = new System.Drawing.Point(101, 415);
            this._btnColumn1Down.Name = "_btnColumn1Down";
            this._btnColumn1Down.Size = new System.Drawing.Size(75, 75);
            this._btnColumn1Down.TabIndex = 10;
            this._btnColumn1Down.Text = "-";
            this._btnColumn1Down.UseVisualStyleBackColor = true;
            this._btnColumn1Down.Click += new System.EventHandler(this.MoveDown);
            // 
            // _btnColumn3Down
            // 
            this._btnColumn3Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnColumn3Down.Location = new System.Drawing.Point(326, 415);
            this._btnColumn3Down.Name = "_btnColumn3Down";
            this._btnColumn3Down.Size = new System.Drawing.Size(75, 75);
            this._btnColumn3Down.TabIndex = 9;
            this._btnColumn3Down.Text = "-";
            this._btnColumn3Down.UseVisualStyleBackColor = true;
            this._btnColumn3Down.Click += new System.EventHandler(this.MoveDown);
            // 
            // panel1
            // 
            this._panel.Location = new System.Drawing.Point(101, 109);
            this._panel.Name = "panel1";
            this._panel.Size = new System.Drawing.Size(300, 300);
            this._panel.TabIndex = 12;
            this._panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 515);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._btnColumn2DOwn);
            this.Controls.Add(this._btnColumn1Down);
            this.Controls.Add(this._btnColumn3Down);
            this.Controls.Add(this._btnColumn2Up);
            this.Controls.Add(this._btnColumn1Up);
            this.Controls.Add(this._btnColumn3Up);
            this.Controls.Add(this._btnRow2Left);
            this.Controls.Add(this._btnRow3Left);
            this.Controls.Add(this._btnRow1Left);
            this.Controls.Add(this._btnRow2Right);
            this.Controls.Add(this._btnRow3Right);
            this.Controls.Add(this._btnRow1Right);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnRow1Right;
        private System.Windows.Forms.Button _btnRow3Right;
        private System.Windows.Forms.Button _btnRow2Right;
        private System.Windows.Forms.Button _btnRow1Left;
        private System.Windows.Forms.Button _btnRow3Left;
        private System.Windows.Forms.Button _btnRow2Left;
        private System.Windows.Forms.Button _btnColumn3Up;
        private System.Windows.Forms.Button _btnColumn1Up;
        private System.Windows.Forms.Button _btnColumn2Up;
        private System.Windows.Forms.Button _btnColumn2DOwn;
        private System.Windows.Forms.Button _btnColumn1Down;
        private System.Windows.Forms.Button _btnColumn3Down;
        private System.Windows.Forms.Panel _panel;
    }
}

