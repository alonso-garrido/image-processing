namespace image_processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(22, 63);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(358, 246);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.picResult.Location = new System.Drawing.Point(591, 63);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(358, 246);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(22, 325);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(159, 34);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Elegir Imagen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(431, 63);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(112, 34);
            this.btnGray.TabIndex = 1;
            this.btnGray.Text = "Gris";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1039, 637);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento de imagenes - UPC";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGray;
    }
}

