namespace MegaDesk_3_BradRAllen
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuote_btn = new System.Windows.Forms.Button();
            this.viewQuotes_btn = new System.Windows.Forms.Button();
            this.searchQuotes_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuote_btn
            // 
            this.addNewQuote_btn.Location = new System.Drawing.Point(30, 66);
            this.addNewQuote_btn.Name = "addNewQuote_btn";
            this.addNewQuote_btn.Size = new System.Drawing.Size(141, 36);
            this.addNewQuote_btn.TabIndex = 0;
            this.addNewQuote_btn.Text = "&Add New Quote";
            this.addNewQuote_btn.UseVisualStyleBackColor = true;
            this.addNewQuote_btn.Click += new System.EventHandler(this.addNewQuote_btn_Click);
            // 
            // viewQuotes_btn
            // 
            this.viewQuotes_btn.Location = new System.Drawing.Point(30, 120);
            this.viewQuotes_btn.Name = "viewQuotes_btn";
            this.viewQuotes_btn.Size = new System.Drawing.Size(141, 36);
            this.viewQuotes_btn.TabIndex = 1;
            this.viewQuotes_btn.Text = "&View Quotes";
            this.viewQuotes_btn.UseVisualStyleBackColor = true;
            this.viewQuotes_btn.Click += new System.EventHandler(this.viewQuotes_btn_Click);
            // 
            // searchQuotes_btn
            // 
            this.searchQuotes_btn.Location = new System.Drawing.Point(30, 174);
            this.searchQuotes_btn.Name = "searchQuotes_btn";
            this.searchQuotes_btn.Size = new System.Drawing.Size(141, 36);
            this.searchQuotes_btn.TabIndex = 2;
            this.searchQuotes_btn.Text = "&Search Quotes";
            this.searchQuotes_btn.UseVisualStyleBackColor = true;
            this.searchQuotes_btn.Click += new System.EventHandler(this.searchQuotes_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(30, 229);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(141, 36);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "&Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.searchQuotes_btn);
            this.Controls.Add(this.viewQuotes_btn);
            this.Controls.Add(this.addNewQuote_btn);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote_btn;
        private System.Windows.Forms.Button viewQuotes_btn;
        private System.Windows.Forms.Button searchQuotes_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

