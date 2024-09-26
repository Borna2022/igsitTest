namespace igsit
{
    partial class PenaltyRegisterForm
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
            this.lsbshowperson = new System.Windows.Forms.ListBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtpenaltycode = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(959, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "جستجوی اشخاص";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "کد جریمه";
            // 
            // lsbshowperson
            // 
            this.lsbshowperson.FormattingEnabled = true;
            this.lsbshowperson.ItemHeight = 16;
            this.lsbshowperson.Location = new System.Drawing.Point(57, 29);
            this.lsbshowperson.Name = "lsbshowperson";
            this.lsbshowperson.Size = new System.Drawing.Size(568, 340);
            this.lsbshowperson.TabIndex = 5;
            this.lsbshowperson.TabStop = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(778, 15);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(174, 22);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // txtpenaltycode
            // 
            this.txtpenaltycode.Location = new System.Drawing.Point(778, 41);
            this.txtpenaltycode.Name = "txtpenaltycode";
            this.txtpenaltycode.Size = new System.Drawing.Size(174, 22);
            this.txtpenaltycode.TabIndex = 2;
            this.txtpenaltycode.Enter += new System.EventHandler(this.txtpenaltycode_Enter);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(778, 69);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(82, 34);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "ثبت جریمه";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // PenaltyRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpenaltycode);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lsbshowperson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PenaltyRegisterForm";
            this.Text = "PenaltyRegister";
            this.Load += new System.EventHandler(this.PenaltyRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbshowperson;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtpenaltycode;
        private System.Windows.Forms.Button btnregister;
    }
}