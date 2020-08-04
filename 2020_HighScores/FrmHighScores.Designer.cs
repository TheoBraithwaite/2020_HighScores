namespace _2020_HighScores
{
    partial class FrmHighScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.ListBoxScore = new System.Windows.Forms.ListBox();
            this.ListBoxName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player\'s Name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(117, 190);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player\'s Score";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(117, 241);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerScore.TabIndex = 5;
            this.lblPlayerScore.Text = "Score";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(16, 280);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(39, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "(blank)";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(197, 236);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return to Game Form";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // ListBoxScore
            // 
            this.ListBoxScore.FormattingEnabled = true;
            this.ListBoxScore.Location = new System.Drawing.Point(114, 67);
            this.ListBoxScore.Name = "ListBoxScore";
            this.ListBoxScore.Size = new System.Drawing.Size(108, 121);
            this.ListBoxScore.TabIndex = 9;
            // 
            // ListBoxName
            // 
            this.ListBoxName.FormattingEnabled = true;
            this.ListBoxName.Location = new System.Drawing.Point(19, 67);
            this.ListBoxName.Name = "ListBoxName";
            this.ListBoxName.Size = new System.Drawing.Size(96, 121);
            this.ListBoxName.TabIndex = 10;
            // 
            // FrmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ListBoxName);
            this.Controls.Add(this.ListBoxScore);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHighScores";
            this.Text = "FrmHighScores";
            this.Load += new System.EventHandler(this.FrmHighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox ListBoxScore;
        private System.Windows.Forms.ListBox ListBoxName;
    }
}