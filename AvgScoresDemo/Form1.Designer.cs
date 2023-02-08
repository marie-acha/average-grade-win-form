namespace AvgScoresDemo
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
            this.LoadScoresListBox = new System.Windows.Forms.ListBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.MinTextLabel = new System.Windows.Forms.Label();
            this.MaxTextLabel = new System.Windows.Forms.Label();
            this.AvgTextLabel = new System.Windows.Forms.Label();
            this.MinGradeLabel = new System.Windows.Forms.Label();
            this.MaxGradeLabel = new System.Windows.Forms.Label();
            this.AvgGradeLabel = new System.Windows.Forms.Label();
            this.LoadScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadScoresListBox
            // 
            this.LoadScoresListBox.FormattingEnabled = true;
            this.LoadScoresListBox.ItemHeight = 16;
            this.LoadScoresListBox.Location = new System.Drawing.Point(264, 65);
            this.LoadScoresListBox.Name = "LoadScoresListBox";
            this.LoadScoresListBox.Size = new System.Drawing.Size(274, 84);
            this.LoadScoresListBox.TabIndex = 0;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(294, 9);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(219, 23);
            this.HeadingLabel.TabIndex = 1;
            this.HeadingLabel.Text = "Average Scores Demo";
            // 
            // ComputeButton
            // 
            this.ComputeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ComputeButton.Location = new System.Drawing.Point(369, 285);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(192, 51);
            this.ComputeButton.TabIndex = 2;
            this.ComputeButton.Text = "Perform Computations";
            this.ComputeButton.UseVisualStyleBackColor = false;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // MinTextLabel
            // 
            this.MinTextLabel.AutoSize = true;
            this.MinTextLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTextLabel.Location = new System.Drawing.Point(120, 175);
            this.MinTextLabel.Name = "MinTextLabel";
            this.MinTextLabel.Size = new System.Drawing.Size(128, 18);
            this.MinTextLabel.TabIndex = 3;
            this.MinTextLabel.Text = "Minimum Grade: ";
            // 
            // MaxTextLabel
            // 
            this.MaxTextLabel.AutoSize = true;
            this.MaxTextLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTextLabel.Location = new System.Drawing.Point(342, 175);
            this.MaxTextLabel.Name = "MaxTextLabel";
            this.MaxTextLabel.Size = new System.Drawing.Size(128, 18);
            this.MaxTextLabel.TabIndex = 4;
            this.MaxTextLabel.Text = "Maximum Grade: ";
            // 
            // AvgTextLabel
            // 
            this.AvgTextLabel.AutoSize = true;
            this.AvgTextLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgTextLabel.Location = new System.Drawing.Point(548, 175);
            this.AvgTextLabel.Name = "AvgTextLabel";
            this.AvgTextLabel.Size = new System.Drawing.Size(128, 18);
            this.AvgTextLabel.TabIndex = 5;
            this.AvgTextLabel.Text = "Average Grade: ";
            // 
            // MinGradeLabel
            // 
            this.MinGradeLabel.AutoSize = true;
            this.MinGradeLabel.Location = new System.Drawing.Point(151, 202);
            this.MinGradeLabel.Name = "MinGradeLabel";
            this.MinGradeLabel.Size = new System.Drawing.Size(0, 20);
            this.MinGradeLabel.TabIndex = 6;
            // 
            // MaxGradeLabel
            // 
            this.MaxGradeLabel.AutoSize = true;
            this.MaxGradeLabel.Location = new System.Drawing.Point(375, 202);
            this.MaxGradeLabel.Name = "MaxGradeLabel";
            this.MaxGradeLabel.Size = new System.Drawing.Size(0, 20);
            this.MaxGradeLabel.TabIndex = 7;
            // 
            // AvgGradeLabel
            // 
            this.AvgGradeLabel.AutoSize = true;
            this.AvgGradeLabel.Location = new System.Drawing.Point(581, 202);
            this.AvgGradeLabel.Name = "AvgGradeLabel";
            this.AvgGradeLabel.Size = new System.Drawing.Size(0, 20);
            this.AvgGradeLabel.TabIndex = 8;
            // 
            // LoadScoreButton
            // 
            this.LoadScoreButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadScoreButton.Location = new System.Drawing.Point(224, 285);
            this.LoadScoreButton.Name = "LoadScoreButton";
            this.LoadScoreButton.Size = new System.Drawing.Size(130, 51);
            this.LoadScoreButton.TabIndex = 9;
            this.LoadScoreButton.Text = "Load Scores";
            this.LoadScoreButton.UseVisualStyleBackColor = false;
            this.LoadScoreButton.Click += new System.EventHandler(this.LoadScoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadScoreButton);
            this.Controls.Add(this.AvgGradeLabel);
            this.Controls.Add(this.MaxGradeLabel);
            this.Controls.Add(this.MinGradeLabel);
            this.Controls.Add(this.AvgTextLabel);
            this.Controls.Add(this.MaxTextLabel);
            this.Controls.Add(this.MinTextLabel);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.LoadScoresListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LoadScoresListBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Label MinTextLabel;
        private System.Windows.Forms.Label MaxTextLabel;
        private System.Windows.Forms.Label AvgTextLabel;
        private System.Windows.Forms.Label MinGradeLabel;
        private System.Windows.Forms.Label MaxGradeLabel;
        private System.Windows.Forms.Label AvgGradeLabel;
        private System.Windows.Forms.Button LoadScoreButton;
    }
}

