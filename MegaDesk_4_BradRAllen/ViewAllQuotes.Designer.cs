namespace MegaDesk_3_BradRAllen
{
    partial class ViewAllQuotes
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
            this.closeForm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeForm_btn
            // 
            this.closeForm_btn.Location = new System.Drawing.Point(647, 402);
            this.closeForm_btn.Name = "closeForm_btn";
            this.closeForm_btn.Size = new System.Drawing.Size(141, 36);
            this.closeForm_btn.TabIndex = 5;
            this.closeForm_btn.Text = "&Close";
            this.closeForm_btn.UseVisualStyleBackColor = true;
            this.closeForm_btn.Click += new System.EventHandler(this.closeForm_btn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeForm_btn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeForm_btn;
    }
}