namespace waifu2x_mass_upscaler
{
    partial class MainWindow
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
            this.UpscaleButton = new System.Windows.Forms.Button();
            this.UpscaleProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // UpscaleButton
            // 
            this.UpscaleButton.Location = new System.Drawing.Point(12, 12);
            this.UpscaleButton.Name = "UpscaleButton";
            this.UpscaleButton.Size = new System.Drawing.Size(255, 27);
            this.UpscaleButton.TabIndex = 0;
            this.UpscaleButton.Text = "Upscale!";
            this.UpscaleButton.UseVisualStyleBackColor = true;
            this.UpscaleButton.Click += new System.EventHandler(this.UpscaleButton_Click);
            // 
            // UpscaleProgressBar
            // 
            this.UpscaleProgressBar.Location = new System.Drawing.Point(12, 45);
            this.UpscaleProgressBar.Name = "UpscaleProgressBar";
            this.UpscaleProgressBar.Size = new System.Drawing.Size(255, 23);
            this.UpscaleProgressBar.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 80);
            this.Controls.Add(this.UpscaleProgressBar);
            this.Controls.Add(this.UpscaleButton);
            this.Name = "MainWindow";
            this.Text = "Waifu2x mass upscaler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpscaleButton;
        private System.Windows.Forms.ProgressBar UpscaleProgressBar;
    }
}

