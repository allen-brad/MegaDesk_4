namespace MegaDesk_3_BradRAllen
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.closeForm_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName_tb = new System.Windows.Forms.TextBox();
            this.DeskWidth_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeskDepth_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeskDrawers_tb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SurfaceMaterial_tb = new System.Windows.Forms.ComboBox();
            this.generateQuote_btn = new System.Windows.Forms.Button();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7Day = new System.Windows.Forms.RadioButton();
            this.radioButton5Day = new System.Windows.Forms.RadioButton();
            this.radioButton3Day = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDrawers_tb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeForm_btn
            // 
            this.closeForm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.closeForm_btn.Location = new System.Drawing.Point(331, 288);
            this.closeForm_btn.Name = "closeForm_btn";
            this.closeForm_btn.Size = new System.Drawing.Size(141, 36);
            this.closeForm_btn.TabIndex = 4;
            this.closeForm_btn.Text = "&Close";
            this.closeForm_btn.UseVisualStyleBackColor = true;
            this.closeForm_btn.Click += new System.EventHandler(this.closeForm_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create a New Qoute";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerName_tb
            // 
            this.CustomerName_tb.Location = new System.Drawing.Point(18, 58);
            this.CustomerName_tb.Name = "CustomerName_tb";
            this.CustomerName_tb.Size = new System.Drawing.Size(348, 20);
            this.CustomerName_tb.TabIndex = 7;
            // 
            // DeskWidth_tb
            // 
            this.DeskWidth_tb.Location = new System.Drawing.Point(18, 110);
            this.DeskWidth_tb.Name = "DeskWidth_tb";
            this.DeskWidth_tb.Size = new System.Drawing.Size(111, 20);
            this.DeskWidth_tb.TabIndex = 9;
            this.DeskWidth_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsWholeNumber_KeyPress);
            this.DeskWidth_tb.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidth_tb_Validating);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width (inches)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeskDepth_tb
            // 
            this.DeskDepth_tb.Location = new System.Drawing.Point(147, 111);
            this.DeskDepth_tb.Name = "DeskDepth_tb";
            this.DeskDepth_tb.Size = new System.Drawing.Size(111, 20);
            this.DeskDepth_tb.TabIndex = 11;
            this.DeskDepth_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsWholeNumber_KeyPress);
            this.DeskDepth_tb.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepth_tb_Validating);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(146, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Depth (inches)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Drawers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeskDrawers_tb
            // 
            this.DeskDrawers_tb.Location = new System.Drawing.Point(19, 155);
            this.DeskDrawers_tb.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DeskDrawers_tb.Name = "DeskDrawers_tb";
            this.DeskDrawers_tb.Size = new System.Drawing.Size(84, 20);
            this.DeskDrawers_tb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(16, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Surface Material";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SurfaceMaterial_tb
            // 
            this.SurfaceMaterial_tb.FormattingEnabled = true;
            this.SurfaceMaterial_tb.Location = new System.Drawing.Point(18, 200);
            this.SurfaceMaterial_tb.Name = "SurfaceMaterial_tb";
            this.SurfaceMaterial_tb.Size = new System.Drawing.Size(111, 21);
            this.SurfaceMaterial_tb.TabIndex = 15;
            // 
            // generateQuote_btn
            // 
            this.generateQuote_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateQuote_btn.ForeColor = System.Drawing.Color.SteelBlue;
            this.generateQuote_btn.Location = new System.Drawing.Point(15, 277);
            this.generateQuote_btn.Name = "generateQuote_btn";
            this.generateQuote_btn.Size = new System.Drawing.Size(160, 36);
            this.generateQuote_btn.TabIndex = 18;
            this.generateQuote_btn.Text = "Generate Quote";
            this.generateQuote_btn.UseVisualStyleBackColor = true;
            this.generateQuote_btn.Click += new System.EventHandler(this.generateQuote_btn_Click);
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Checked = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(12, 23);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(153, 22);
            this.radioButtonStandard.TabIndex = 19;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard (14 Days)";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton3Day);
            this.groupBox1.Controls.Add(this.radioButton5Day);
            this.groupBox1.Controls.Add(this.radioButton7Day);
            this.groupBox1.Controls.Add(this.radioButtonStandard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(274, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 145);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production Time";
            // 
            // radioButton7Day
            // 
            this.radioButton7Day.AutoSize = true;
            this.radioButton7Day.Location = new System.Drawing.Point(12, 51);
            this.radioButton7Day.Name = "radioButton7Day";
            this.radioButton7Day.Size = new System.Drawing.Size(104, 22);
            this.radioButton7Day.TabIndex = 20;
            this.radioButton7Day.Text = "7-Day Rush";
            this.radioButton7Day.UseVisualStyleBackColor = true;
            // 
            // radioButton5Day
            // 
            this.radioButton5Day.AutoSize = true;
            this.radioButton5Day.Location = new System.Drawing.Point(12, 79);
            this.radioButton5Day.Name = "radioButton5Day";
            this.radioButton5Day.Size = new System.Drawing.Size(104, 22);
            this.radioButton5Day.TabIndex = 21;
            this.radioButton5Day.Text = "5-Day Rush";
            this.radioButton5Day.UseVisualStyleBackColor = true;
            // 
            // radioButton3Day
            // 
            this.radioButton3Day.AutoSize = true;
            this.radioButton3Day.Location = new System.Drawing.Point(12, 107);
            this.radioButton3Day.Name = "radioButton3Day";
            this.radioButton3Day.Size = new System.Drawing.Size(104, 22);
            this.radioButton3Day.TabIndex = 22;
            this.radioButton3Day.Text = "3-Day Rush";
            this.radioButton3Day.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateQuote_btn);
            this.Controls.Add(this.SurfaceMaterial_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeskDrawers_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeskDepth_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeskWidth_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerName_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeForm_btn);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeskDrawers_tb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeForm_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerName_tb;
        private System.Windows.Forms.TextBox DeskWidth_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeskDepth_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DeskDrawers_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SurfaceMaterial_tb;
        private System.Windows.Forms.Button generateQuote_btn;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3Day;
        private System.Windows.Forms.RadioButton radioButton5Day;
        private System.Windows.Forms.RadioButton radioButton7Day;
    }
}