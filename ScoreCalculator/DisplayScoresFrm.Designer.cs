namespace ScoreCalculator
{
    partial class DisplayScoresFrm
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
            this.resultLst = new System.Windows.Forms.ListBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLst
            // 
            this.resultLst.FormattingEnabled = true;
            this.resultLst.ItemHeight = 20;
            this.resultLst.Location = new System.Drawing.Point(23, 31);
            this.resultLst.Name = "resultLst";
            this.resultLst.Size = new System.Drawing.Size(222, 224);
            this.resultLst.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(81, 286);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 38);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "OK";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DisplayScoresFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 361);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resultLst);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayScoresFrm";
            this.Text = "Display Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultLst;
        private System.Windows.Forms.Button exitBtn;
    }
}