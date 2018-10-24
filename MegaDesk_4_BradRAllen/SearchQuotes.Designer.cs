namespace MegaDesk_3_BradRAllen
{
    partial class SearchQuotes
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
            this.SurfaceMaterial_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchResultsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // closeForm_btn
            // 
            this.closeForm_btn.Location = new System.Drawing.Point(621, 453);
            this.closeForm_btn.Name = "closeForm_btn";
            this.closeForm_btn.Size = new System.Drawing.Size(141, 36);
            this.closeForm_btn.TabIndex = 6;
            this.closeForm_btn.Text = "&Close";
            this.closeForm_btn.UseVisualStyleBackColor = true;
            this.closeForm_btn.Click += new System.EventHandler(this.closeForm_btn_Click);
            // 
            // SurfaceMaterial_cb
            // 
            this.SurfaceMaterial_cb.FormattingEnabled = true;
            this.SurfaceMaterial_cb.Location = new System.Drawing.Point(13, 29);
            this.SurfaceMaterial_cb.Name = "SurfaceMaterial_cb";
            this.SurfaceMaterial_cb.Size = new System.Drawing.Size(111, 21);
            this.SurfaceMaterial_cb.TabIndex = 17;
            this.SurfaceMaterial_cb.SelectedIndexChanged += new System.EventHandler(this.SurfaceMaterial_cb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(11, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Surface Material";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchResultsListView
            // 
            this.SearchResultsListView.Location = new System.Drawing.Point(14, 71);
            this.SearchResultsListView.Name = "SearchResultsListView";
            this.SearchResultsListView.Size = new System.Drawing.Size(748, 364);
            this.SearchResultsListView.TabIndex = 18;
            this.SearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.SearchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_4_BradRAllen.Properties.Resources.megadesk_plain_bg;
            this.ClientSize = new System.Drawing.Size(774, 501);
            this.Controls.Add(this.SearchResultsListView);
            this.Controls.Add(this.SurfaceMaterial_cb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeForm_btn);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeForm_btn;
        private System.Windows.Forms.ComboBox SurfaceMaterial_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView SearchResultsListView;
    }
}