namespace igsit
{
    partial class RegPersonForm
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
            this.txtpersoncode = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtvin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbosearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvtpersons = new System.Windows.Forms.DataGridView();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtpersons)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpersoncode
            // 
            this.txtpersoncode.Location = new System.Drawing.Point(585, 113);
            this.txtpersoncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpersoncode.Name = "txtpersoncode";
            this.txtpersoncode.ReadOnly = true;
            this.txtpersoncode.Size = new System.Drawing.Size(157, 22);
            this.txtpersoncode.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(585, 142);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(157, 22);
            this.txtname.TabIndex = 2;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(585, 169);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.Size = new System.Drawing.Size(157, 22);
            this.txtlastname.TabIndex = 3;
            this.txtlastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlastname.Enter += new System.EventHandler(this.txtlastname_Enter);
            this.txtlastname.Leave += new System.EventHandler(this.txtlastname_Leave);
            // 
            // txtvin
            // 
            this.txtvin.Location = new System.Drawing.Point(585, 197);
            this.txtvin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvin.Name = "txtvin";
            this.txtvin.ReadOnly = true;
            this.txtvin.Size = new System.Drawing.Size(157, 22);
            this.txtvin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "نام خانوادگی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vin Serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "متن جستجو";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "جستجو بر اساس";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(191, 43);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(157, 22);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
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
            this.cbosearch.Location = new System.Drawing.Point(191, 14);
            this.cbosearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbosearch.Name = "cbosearch";
            this.cbosearch.Size = new System.Drawing.Size(157, 24);
            this.cbosearch.TabIndex = 14;
            this.cbosearch.SelectedIndexChanged += new System.EventHandler(this.cbosearch_SelectedIndexChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(236, 71);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 37);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "جستجو";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgvtpersons
            // 
            this.dgvtpersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtpersons.Location = new System.Drawing.Point(19, 113);
            this.dgvtpersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtpersons.Name = "dgvtpersons";
            this.dgvtpersons.RowHeadersWidth = 51;
            this.dgvtpersons.RowTemplate.Height = 24;
            this.dgvtpersons.Size = new System.Drawing.Size(489, 325);
            this.dgvtpersons.TabIndex = 16;
            this.dgvtpersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtpersons_CellClick);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(525, 391);
            this.btnlast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(69, 32);
            this.btnlast.TabIndex = 23;
            this.btnlast.Text = "آخرین";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(601, 391);
            this.btnnext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(69, 32);
            this.btnnext.TabIndex = 24;
            this.btnnext.Text = "بعدی";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(753, 391);
            this.btnfirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(69, 32);
            this.btnfirst.TabIndex = 26;
            this.btnfirst.Text = "اولین";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(677, 391);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(69, 32);
            this.btnprevious.TabIndex = 25;
            this.btnprevious.Text = "قبلی";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(716, 238);
            this.btnnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(84, 32);
            this.btnnew.TabIndex = 30;
            this.btnnew.Text = "جدید";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(626, 238);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 32);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(536, 238);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(84, 32);
            this.btnedit.TabIndex = 28;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(536, 274);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(84, 32);
            this.btndel.TabIndex = 27;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // RegPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.dgvtpersons);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cbosearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvin);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpersoncode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegPersonForm";
            this.Text = "RegPersonForm";
            this.Load += new System.EventHandler(this.RegPersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtpersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpersoncode;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtvin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbosearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvtpersons;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
    }
}