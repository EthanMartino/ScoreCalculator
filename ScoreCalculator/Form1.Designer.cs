namespace ScoreCalculator
{
    partial class scoreCalculatorFrm
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
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scoreTotalLbl = new System.Windows.Forms.Label();
            this.scoreCountLbl = new System.Windows.Forms.Label();
            this.averageLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.displayScoresBtn = new System.Windows.Forms.Button();
            this.clearScoresBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.scoreTxt = new System.Windows.Forms.TextBox();
            this.scoreTotalResultLbl = new System.Windows.Forms.Label();
            this.scoreCountResultLbl = new System.Windows.Forms.Label();
            this.averageResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(46, 33);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score:";
            // 
            // scoreTotalLbl
            // 
            this.scoreTotalLbl.AutoSize = true;
            this.scoreTotalLbl.Location = new System.Drawing.Point(19, 62);
            this.scoreTotalLbl.Name = "scoreTotalLbl";
            this.scoreTotalLbl.Size = new System.Drawing.Size(65, 13);
            this.scoreTotalLbl.TabIndex = 1;
            this.scoreTotalLbl.Text = "Score Total:";
            // 
            // scoreCountLbl
            // 
            this.scoreCountLbl.AutoSize = true;
            this.scoreCountLbl.Location = new System.Drawing.Point(19, 91);
            this.scoreCountLbl.Name = "scoreCountLbl";
            this.scoreCountLbl.Size = new System.Drawing.Size(69, 13);
            this.scoreCountLbl.TabIndex = 2;
            this.scoreCountLbl.Text = "Score Count:";
            // 
            // averageLbl
            // 
            this.averageLbl.AutoSize = true;
            this.averageLbl.Location = new System.Drawing.Point(34, 121);
            this.averageLbl.Name = "averageLbl";
            this.averageLbl.Size = new System.Drawing.Size(50, 13);
            this.averageLbl.TabIndex = 3;
            this.averageLbl.Text = "Average:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(177, 28);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // displayScoresBtn
            // 
            this.displayScoresBtn.Location = new System.Drawing.Point(37, 159);
            this.displayScoresBtn.Name = "displayScoresBtn";
            this.displayScoresBtn.Size = new System.Drawing.Size(97, 30);
            this.displayScoresBtn.TabIndex = 5;
            this.displayScoresBtn.Text = "Display Scores";
            this.displayScoresBtn.UseVisualStyleBackColor = true;
            this.displayScoresBtn.Click += new System.EventHandler(this.DisplayScoresBtn_Click);
            // 
            // clearScoresBtn
            // 
            this.clearScoresBtn.Location = new System.Drawing.Point(165, 159);
            this.clearScoresBtn.Name = "clearScoresBtn";
            this.clearScoresBtn.Size = new System.Drawing.Size(87, 30);
            this.clearScoresBtn.TabIndex = 6;
            this.clearScoresBtn.Text = "Clear Scores";
            this.clearScoresBtn.UseVisualStyleBackColor = true;
            this.clearScoresBtn.Click += new System.EventHandler(this.ClearScoresBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(177, 209);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // scoreTxt
            // 
            this.scoreTxt.Location = new System.Drawing.Point(104, 30);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(57, 20);
            this.scoreTxt.TabIndex = 8;
            // 
            // scoreTotalResultLbl
            // 
            this.scoreTotalResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreTotalResultLbl.Location = new System.Drawing.Point(104, 61);
            this.scoreTotalResultLbl.Name = "scoreTotalResultLbl";
            this.scoreTotalResultLbl.Size = new System.Drawing.Size(57, 21);
            this.scoreTotalResultLbl.TabIndex = 9;
            // 
            // scoreCountResultLbl
            // 
            this.scoreCountResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreCountResultLbl.Location = new System.Drawing.Point(104, 90);
            this.scoreCountResultLbl.Name = "scoreCountResultLbl";
            this.scoreCountResultLbl.Size = new System.Drawing.Size(57, 23);
            this.scoreCountResultLbl.TabIndex = 10;
            // 
            // averageResultLbl
            // 
            this.averageResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageResultLbl.Location = new System.Drawing.Point(104, 120);
            this.averageResultLbl.Name = "averageResultLbl";
            this.averageResultLbl.Size = new System.Drawing.Size(57, 23);
            this.averageResultLbl.TabIndex = 11;
            // 
            // scoreCalculatorFrm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(288, 255);
            this.Controls.Add(this.averageResultLbl);
            this.Controls.Add(this.scoreCountResultLbl);
            this.Controls.Add(this.scoreTotalResultLbl);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearScoresBtn);
            this.Controls.Add(this.displayScoresBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.averageLbl);
            this.Controls.Add(this.scoreCountLbl);
            this.Controls.Add(this.scoreTotalLbl);
            this.Controls.Add(this.scoreLbl);
            this.Name = "scoreCalculatorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoreTotalLbl;
        private System.Windows.Forms.Label scoreCountLbl;
        private System.Windows.Forms.Label averageLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button displayScoresBtn;
        private System.Windows.Forms.Button clearScoresBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox scoreTxt;
        private System.Windows.Forms.Label scoreTotalResultLbl;
        private System.Windows.Forms.Label scoreCountResultLbl;
        private System.Windows.Forms.Label averageResultLbl;
    }
}

