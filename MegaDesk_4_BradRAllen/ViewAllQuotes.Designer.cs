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
            this.allQuotesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // closeForm_btn
            // 
            this.closeForm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.closeForm_btn.Location = new System.Drawing.Point(621, 453);
            this.closeForm_btn.Name = "closeForm_btn";
            this.closeForm_btn.Size = new System.Drawing.Size(141, 36);
            this.closeForm_btn.TabIndex = 5;
            this.closeForm_btn.Text = "&Close";
            this.closeForm_btn.UseVisualStyleBackColor = true;
            this.closeForm_btn.Click += new System.EventHandler(this.closeForm_btn_Click);
            // 
            // allQuotesListView
            // 
            this.allQuotesListView.Location = new System.Drawing.Point(13, 12);
            this.allQuotesListView.Name = "allQuotesListView";
            this.allQuotesListView.Size = new System.Drawing.Size(749, 424);
            this.allQuotesListView.TabIndex = 6;
            this.allQuotesListView.UseCompatibleStateImageBehavior = false;
            this.allQuotesListView.View = System.Windows.Forms.View.Details;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_4_BradRAllen.Properties.Resources.megadesk_plain_bg;
            this.ClientSize = new System.Drawing.Size(774, 501);
            this.Controls.Add(this.allQuotesListView);
            this.Controls.Add(this.closeForm_btn);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeForm_btn;
        private System.Windows.Forms.ListView allQuotesListView;
    }
}