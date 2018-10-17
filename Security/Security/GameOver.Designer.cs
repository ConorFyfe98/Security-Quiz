namespace Security
{
    partial class GameOver
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
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.failMessageLabel = new System.Windows.Forms.Label();
            this.failPicture = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.failPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.Location = new System.Drawing.Point(227, 66);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(381, 73);
            this.gameoverLabel.TabIndex = 0;
            this.gameoverLabel.Text = "Game Over!";
            this.gameoverLabel.Click += new System.EventHandler(this.gameoverLabel_Click);
            // 
            // failMessageLabel
            // 
            this.failMessageLabel.AutoSize = true;
            this.failMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failMessageLabel.Location = new System.Drawing.Point(116, 139);
            this.failMessageLabel.Name = "failMessageLabel";
            this.failMessageLabel.Size = new System.Drawing.Size(196, 31);
            this.failMessageLabel.TabIndex = 1;
            this.failMessageLabel.Text = "You were fired!";
            this.failMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // failPicture
            // 
            this.failPicture.BackgroundImage = global::Security.Properties.Resources.sadman;
            this.failPicture.Location = new System.Drawing.Point(324, 247);
            this.failPicture.Name = "failPicture";
            this.failPicture.Size = new System.Drawing.Size(154, 202);
            this.failPicture.TabIndex = 2;
            this.failPicture.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.Black;
            this.restartButton.Location = new System.Drawing.Point(677, 391);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(107, 58);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.failPicture);
            this.Controls.Add(this.failMessageLabel);
            this.Controls.Add(this.gameoverLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameOver";
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.failPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label failMessageLabel;
        private System.Windows.Forms.PictureBox failPicture;
        private System.Windows.Forms.Button restartButton;
    }
}