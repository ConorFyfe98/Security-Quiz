namespace Security
{
    partial class Main
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.threatBar = new System.Windows.Forms.ProgressBar();
            this.reputationBar = new System.Windows.Forms.ProgressBar();
            this.reputationLabel = new System.Windows.Forms.Label();
            this.threatLabel = new System.Windows.Forms.Label();
            this.beltPicture = new System.Windows.Forms.PictureBox();
            this.machinePicture = new System.Windows.Forms.PictureBox();
            this.optBButton = new System.Windows.Forms.Button();
            this.optAButton = new System.Windows.Forms.Button();
            this.floorPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.beltPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(282, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 26);
            this.questionLabel.TabIndex = 3;
            // 
            // threatBar
            // 
            this.threatBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.threatBar.ForeColor = System.Drawing.Color.Red;
            this.threatBar.Location = new System.Drawing.Point(515, 423);
            this.threatBar.MarqueeAnimationSpeed = 10;
            this.threatBar.Maximum = 5;
            this.threatBar.Name = "threatBar";
            this.threatBar.Size = new System.Drawing.Size(287, 27);
            this.threatBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.threatBar.TabIndex = 4;
            this.threatBar.Click += new System.EventHandler(this.threatBar_Click);
            // 
            // reputationBar
            // 
            this.reputationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reputationBar.ForeColor = System.Drawing.Color.Red;
            this.reputationBar.Location = new System.Drawing.Point(28, 422);
            this.reputationBar.MarqueeAnimationSpeed = 10;
            this.reputationBar.Maximum = 6;
            this.reputationBar.Name = "reputationBar";
            this.reputationBar.Size = new System.Drawing.Size(287, 27);
            this.reputationBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.reputationBar.TabIndex = 5;
            this.reputationBar.Value = 6;
            // 
            // reputationLabel
            // 
            this.reputationLabel.AutoSize = true;
            this.reputationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reputationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reputationLabel.Location = new System.Drawing.Point(29, 398);
            this.reputationLabel.Name = "reputationLabel";
            this.reputationLabel.Size = new System.Drawing.Size(102, 26);
            this.reputationLabel.TabIndex = 6;
            this.reputationLabel.Text = "Reputation";
            // 
            // threatLabel
            // 
            this.threatLabel.AutoSize = true;
            this.threatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threatLabel.Location = new System.Drawing.Point(516, 398);
            this.threatLabel.Name = "threatLabel";
            this.threatLabel.Size = new System.Drawing.Size(66, 26);
            this.threatLabel.TabIndex = 7;
            this.threatLabel.Text = "Threat";
            // 
            // beltPicture
            // 
            this.beltPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.beltPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beltPicture.Location = new System.Drawing.Point(109, 310);
            this.beltPicture.Name = "beltPicture";
            this.beltPicture.Size = new System.Drawing.Size(731, 62);
            this.beltPicture.TabIndex = 9;
            this.beltPicture.TabStop = false;
            // 
            // machinePicture
            // 
            this.machinePicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.machinePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machinePicture.Location = new System.Drawing.Point(1, 65);
            this.machinePicture.Name = "machinePicture";
            this.machinePicture.Size = new System.Drawing.Size(108, 307);
            this.machinePicture.TabIndex = 8;
            this.machinePicture.TabStop = false;
            // 
            // optBButton
            // 
            this.optBButton.BackgroundImage = global::Security.Properties.Resources.AnswerCrate;
            this.optBButton.Location = new System.Drawing.Point(500, 114);
            this.optBButton.Name = "optBButton";
            this.optBButton.Size = new System.Drawing.Size(200, 200);
            this.optBButton.TabIndex = 1;
            this.optBButton.UseVisualStyleBackColor = true;
            this.optBButton.Click += new System.EventHandler(this.optBButton_Click);
            // 
            // optAButton
            // 
            this.optAButton.BackColor = System.Drawing.Color.Red;
            this.optAButton.BackgroundImage = global::Security.Properties.Resources.AnswerCrate;
            this.optAButton.Location = new System.Drawing.Point(183, 114);
            this.optAButton.Name = "optAButton";
            this.optAButton.Size = new System.Drawing.Size(200, 200);
            this.optAButton.TabIndex = 0;
            this.optAButton.UseVisualStyleBackColor = false;
            this.optAButton.Click += new System.EventHandler(this.optAButton_Click);
            // 
            // floorPicture
            // 
            this.floorPicture.BackgroundImage = global::Security.Properties.Resources.floor;
            this.floorPicture.Location = new System.Drawing.Point(1, 329);
            this.floorPicture.Name = "floorPicture";
            this.floorPicture.Size = new System.Drawing.Size(839, 136);
            this.floorPicture.TabIndex = 10;
            this.floorPicture.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.beltPicture);
            this.Controls.Add(this.machinePicture);
            this.Controls.Add(this.threatLabel);
            this.Controls.Add(this.reputationLabel);
            this.Controls.Add(this.reputationBar);
            this.Controls.Add(this.threatBar);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.optBButton);
            this.Controls.Add(this.optAButton);
            this.Controls.Add(this.floorPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.beltPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optAButton;
        private System.Windows.Forms.Button optBButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ProgressBar threatBar;
        private System.Windows.Forms.ProgressBar reputationBar;
        private System.Windows.Forms.Label reputationLabel;
        private System.Windows.Forms.Label threatLabel;
        private System.Windows.Forms.PictureBox machinePicture;
        private System.Windows.Forms.PictureBox beltPicture;
        private System.Windows.Forms.PictureBox floorPicture;
    }
}