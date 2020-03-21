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
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.ScaleTextbox = new System.Windows.Forms.TextBox();
            this.NoiseReductionTextbox = new System.Windows.Forms.TextBox();
            this.NoiseReductionLabel = new System.Windows.Forms.Label();
            this.UpscaleProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // UpscaleButton
            // 
            this.UpscaleButton.Location = new System.Drawing.Point(12, 70);
            this.UpscaleButton.Name = "UpscaleButton";
            this.UpscaleButton.Size = new System.Drawing.Size(255, 27);
            this.UpscaleButton.TabIndex = 0;
            this.UpscaleButton.Text = "Upscale!";
            this.UpscaleButton.UseVisualStyleBackColor = true;
            this.UpscaleButton.Click += new System.EventHandler(this.UpscaleButton_Click);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(12, 15);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(37, 15);
            this.ScaleLabel.TabIndex = 2;
            this.ScaleLabel.Text = "Scale:";
            // 
            // ScaleTextbox
            // 
            this.ScaleTextbox.Location = new System.Drawing.Point(115, 12);
            this.ScaleTextbox.Name = "ScaleTextbox";
            this.ScaleTextbox.Size = new System.Drawing.Size(152, 23);
            this.ScaleTextbox.TabIndex = 3;
            // 
            // NoiseReductionTextbox
            // 
            this.NoiseReductionTextbox.Location = new System.Drawing.Point(115, 41);
            this.NoiseReductionTextbox.Name = "NoiseReductionTextbox";
            this.NoiseReductionTextbox.Size = new System.Drawing.Size(152, 23);
            this.NoiseReductionTextbox.TabIndex = 3;
            // 
            // NoiseReductionLabel
            // 
            this.NoiseReductionLabel.AutoSize = true;
            this.NoiseReductionLabel.Location = new System.Drawing.Point(12, 44);
            this.NoiseReductionLabel.Name = "NoiseReductionLabel";
            this.NoiseReductionLabel.Size = new System.Drawing.Size(97, 15);
            this.NoiseReductionLabel.TabIndex = 2;
            this.NoiseReductionLabel.Text = "Noise Reduction:";
            // 
            // UpscaleProgressBar
            // 
            this.UpscaleProgressBar.Location = new System.Drawing.Point(12, 103);
            this.UpscaleProgressBar.Name = "UpscaleProgressBar";
            this.UpscaleProgressBar.Size = new System.Drawing.Size(255, 25);
            this.UpscaleProgressBar.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 140);
            this.Controls.Add(this.UpscaleProgressBar);
            this.Controls.Add(this.UpscaleButton);
            this.Controls.Add(this.NoiseReductionLabel);
            this.Controls.Add(this.NoiseReductionTextbox);
            this.Controls.Add(this.ScaleTextbox);
            this.Controls.Add(this.ScaleLabel);
            this.Name = "MainWindow";
            this.Text = "Waifu2x mass upscaler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpscaleButton;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.TextBox ScaleTextbox;
        private System.Windows.Forms.TextBox NoiseReductionTextbox;
        private System.Windows.Forms.Label NoiseReductionLabel;
        private System.Windows.Forms.ProgressBar UpscaleProgressBar;
    }
}

