namespace igsit
{
    partial class RegPenalty
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.txtpenaltycode = new System.Windows.Forms.TextBox();
            this.txtpenaltycost = new System.Windows.Forms.TextBox();
            this.txtpenaltydescription = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvregpenalty = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cbosearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregpenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(826, 324);
            this.btnnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(87, 36);
            this.btnnew.TabIndex = 38;
            this.btnnew.Text = "جدید";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(734, 324);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 36);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(642, 324);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(87, 36);
            this.btnedit.TabIndex = 36;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(550, 324);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(87, 36);
            this.btndel.TabIndex = 35;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(826, 365);
            this.btnfirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(87, 36);
            this.btnfirst.TabIndex = 34;
            this.btnfirst.Text = "اولین";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(734, 365);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(87, 36);
            this.btnprevious.TabIndex = 33;
            this.btnprevious.Text = "قبلی";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(642, 365);
            this.btnnext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(87, 36);
            this.btnnext.TabIndex = 32;
            this.btnnext.Text = "بعدی";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(550, 365);
            this.btnlast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(87, 36);
            this.btnlast.TabIndex = 31;
            this.btnlast.Text = "آخرین";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // txtpenaltycode
            // 
            this.txtpenaltycode.Location = new System.Drawing.Point(557, 13);
            this.txtpenaltycode.Margin = new System.Windows.Forms.Padding(4);
            this.txtpenaltycode.Name = "txtpenaltycode";
            this.txtpenaltycode.ReadOnly = true;
            this.txtpenaltycode.Size = new System.Drawing.Size(231, 22);
            this.txtpenaltycode.TabIndex = 39;
            // 
            // txtpenaltycost
            // 
            this.txtpenaltycost.Location = new System.Drawing.Point(557, 45);
            this.txtpenaltycost.Margin = new System.Windows.Forms.Padding(4);
            this.txtpenaltycost.Name = "txtpenaltycost";
            this.txtpenaltycost.ReadOnly = true;
            this.txtpenaltycost.Size = new System.Drawing.Size(231, 22);
            this.txtpenaltycost.TabIndex = 40;
            // 
            // txtpenaltydescription
            // 
            this.txtpenaltydescription.Location = new System.Drawing.Point(557, 77);
            this.txtpenaltydescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtpenaltydescription.Name = "txtpenaltydescription";
            this.txtpenaltydescription.ReadOnly = true;
            this.txtpenaltydescription.Size = new System.Drawing.Size(231, 22);
            this.txtpenaltydescription.TabIndex = 41;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(807, 17);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(52, 16);
            this.lbl.TabIndex = 42;
            this.lbl.Text = "کد جریمه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "مبلغ جریمه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "شرح جریمه";
            // 
            // dgvregpenalty
            // 
            this.dgvregpenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregpenalty.Location = new System.Drawing.Point(13, 13);
            this.dgvregpenalty.Margin = new System.Windows.Forms.Padding(4);
            this.dgvregpenalty.Name = "dgvregpenalty";
            this.dgvregpenalty.RowHeadersWidth = 51;
            this.dgvregpenalty.Size = new System.Drawing.Size(523, 396);
            this.dgvregpenalty.TabIndex = 45;
            this.dgvregpenalty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvregpenalty_CellClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(676, 231);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 37);
            this.btnsearch.TabIndex = 50;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // cbosearch
            // 
            this.cbosearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosearch.FormattingEnabled = true;
            this.cbosearch.Items.AddRange(new object[] {
            "نام",
            "نام خانوادگی",
            "کد ملی",
            "سریال کارت"});
            this.cbosearch.Location = new System.Drawing.Point(631, 174);
            this.cbosearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbosearch.Name = "cbosearch";
            this.cbosearch.Size = new System.Drawing.Size(157, 24);
            this.cbosearch.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "متن جستجو";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "جستجو بر اساس";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(631, 203);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(157, 22);
            this.txtsearch.TabIndex = 46;
            // 
            // RegPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 422);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cbosearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvregpenalty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtpenaltydescription);
            this.Controls.Add(this.txtpenaltycost);
            this.Controls.Add(this.txtpenaltycode);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegPenalty";
            this.Text = "RegPenalty";
            this.Load += new System.EventHandler(this.RegPenalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregpenalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.TextBox txtpenaltycode;
        private System.Windows.Forms.TextBox txtpenaltycost;
        private System.Windows.Forms.TextBox txtpenaltydescription;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvregpenalty;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cbosearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
    }
}