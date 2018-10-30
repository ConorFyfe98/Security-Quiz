namespace Security
{
    partial class GameComplete
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
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.AutoSize = true;
            this.congratulationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratulationsLabel.Location = new System.Drawing.Point(154, 76);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.Size = new System.Drawing.Size(501, 73);
            this.congratulationsLabel.TabIndex = 0;
            this.congratulationsLabel.Text = "Congratulations!";
            // 
            // Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.congratulationsLabel);
            this.Name = "Complete";
            this.Text = "Complete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label congratulationsLabel;
    }
}