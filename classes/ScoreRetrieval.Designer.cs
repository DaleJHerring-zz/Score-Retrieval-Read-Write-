namespace ScoreRetrievalApp
{
    partial class ScoreRetrievalForm
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
            this.InstLbl = new System.Windows.Forms.Label();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.DispNewWriteBox = new System.Windows.Forms.ListBox();
            this.RewriteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstLbl
            // 
            this.InstLbl.AutoSize = true;
            this.InstLbl.Location = new System.Drawing.Point(20, 20);
            this.InstLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstLbl.Name = "InstLbl";
            this.InstLbl.Size = new System.Drawing.Size(303, 20);
            this.InstLbl.TabIndex = 0;
            this.InstLbl.Text = "Click the button to write scores to the box.";
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Location = new System.Drawing.Point(20, 317);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.ErrorLbl.TabIndex = 0;
            this.ErrorLbl.Visible = false;
            // 
            // DispNewWriteBox
            // 
            this.DispNewWriteBox.Enabled = false;
            this.DispNewWriteBox.FormattingEnabled = true;
            this.DispNewWriteBox.ItemHeight = 20;
            this.DispNewWriteBox.Location = new System.Drawing.Point(24, 71);
            this.DispNewWriteBox.Name = "DispNewWriteBox";
            this.DispNewWriteBox.Size = new System.Drawing.Size(299, 164);
            this.DispNewWriteBox.TabIndex = 1;
            // 
            // RewriteBtn
            // 
            this.RewriteBtn.Location = new System.Drawing.Point(24, 262);
            this.RewriteBtn.Name = "RewriteBtn";
            this.RewriteBtn.Size = new System.Drawing.Size(75, 46);
            this.RewriteBtn.TabIndex = 1;
            this.RewriteBtn.Text = "&Rewrite";
            this.RewriteBtn.UseVisualStyleBackColor = true;
            this.RewriteBtn.Click += new System.EventHandler(this.RewriteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(235, 262);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 46);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "&Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(449, 262);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 46);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ScoreRetrievalForm
            // 
            this.AcceptButton = this.RewriteBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(549, 346);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RewriteBtn);
            this.Controls.Add(this.DispNewWriteBox);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.InstLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreRetrievalForm";
            this.Text = "Score Averages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScoreRetrievalForm_FormClosing);
            this.Load += new System.EventHandler(this.ScoreRetrievalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstLbl;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.ListBox DispNewWriteBox;
        private System.Windows.Forms.Button RewriteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

