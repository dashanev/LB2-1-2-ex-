namespace LB2__1__2_ex_
{
    partial class Form1
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.btnFillRect = new System.Windows.Forms.Button();
            this.btnDrawEllipse = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnDrawSector = new System.Windows.Forms.Button();
            this.btnDrawStar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(31, 36);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(470, 382);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(560, 79);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(178, 26);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Лінія";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Location = new System.Drawing.Point(560, 111);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(178, 26);
            this.btnDrawRect.TabIndex = 2;
            this.btnDrawRect.Text = "Прямокутник";
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.btnDrawRect_Click);
            // 
            // btnFillRect
            // 
            this.btnFillRect.Location = new System.Drawing.Point(560, 143);
            this.btnFillRect.Name = "btnFillRect";
            this.btnFillRect.Size = new System.Drawing.Size(178, 26);
            this.btnFillRect.TabIndex = 3;
            this.btnFillRect.Text = "Зафарбований прямокутник";
            this.btnFillRect.UseVisualStyleBackColor = true;
            this.btnFillRect.Click += new System.EventHandler(this.btnFillRect_Click);
            // 
            // btnDrawEllipse
            // 
            this.btnDrawEllipse.Location = new System.Drawing.Point(560, 175);
            this.btnDrawEllipse.Name = "btnDrawEllipse";
            this.btnDrawEllipse.Size = new System.Drawing.Size(178, 26);
            this.btnDrawEllipse.TabIndex = 4;
            this.btnDrawEllipse.Text = "Еліпс";
            this.btnDrawEllipse.UseVisualStyleBackColor = true;
            this.btnDrawEllipse.Click += new System.EventHandler(this.btnDrawEllipse_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.Location = new System.Drawing.Point(560, 207);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(178, 26);
            this.btnFillEllipse.TabIndex = 5;
            this.btnFillEllipse.Text = "Зафарбований еліпс";
            this.btnFillEllipse.UseVisualStyleBackColor = true;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            // 
            // btnDrawSector
            // 
            this.btnDrawSector.Location = new System.Drawing.Point(560, 239);
            this.btnDrawSector.Name = "btnDrawSector";
            this.btnDrawSector.Size = new System.Drawing.Size(178, 26);
            this.btnDrawSector.TabIndex = 6;
            this.btnDrawSector.Text = "Сектор";
            this.btnDrawSector.UseVisualStyleBackColor = true;
            this.btnDrawSector.Click += new System.EventHandler(this.btnDrawSector_Click);
            // 
            // btnDrawStar
            // 
            this.btnDrawStar.Location = new System.Drawing.Point(560, 271);
            this.btnDrawStar.Name = "btnDrawStar";
            this.btnDrawStar.Size = new System.Drawing.Size(178, 26);
            this.btnDrawStar.TabIndex = 7;
            this.btnDrawStar.Text = "Зірка";
            this.btnDrawStar.UseVisualStyleBackColor = true;
            this.btnDrawStar.Click += new System.EventHandler(this.btnDrawStar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(560, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 26);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDrawStar);
            this.Controls.Add(this.btnDrawSector);
            this.Controls.Add(this.btnFillEllipse);
            this.Controls.Add(this.btnDrawEllipse);
            this.Controls.Add(this.btnFillRect);
            this.Controls.Add(this.btnDrawRect);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDrawRect;
        private System.Windows.Forms.Button btnFillRect;
        private System.Windows.Forms.Button btnDrawEllipse;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnDrawSector;
        private System.Windows.Forms.Button btnDrawStar;
        private System.Windows.Forms.Button btnClear;
    }
}

