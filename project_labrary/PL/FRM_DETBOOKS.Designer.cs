namespace project_labrary.PL
{
    partial class FRM_DETBOOKS
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cover = new System.Windows.Forms.PictureBox();
            this.txt_rate = new Bunifu.Framework.UI.BunifuRating();
            this.txt_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.Label();
            this.txt_cat = new System.Windows.Forms.Label();
            this.txt_auther = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::project_labrary.Properties.Resources.delete_sign_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(11, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cover);
            this.groupBox2.Controls.Add(this.txt_rate);
            this.groupBox2.Controls.Add(this.txt_date);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(59, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(335, 463);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات الثانوية";
            // 
            // cover
            // 
            this.cover.Image = global::project_labrary.Properties.Resources.borrow_book_40px;
            this.cover.Location = new System.Drawing.Point(79, 273);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(217, 168);
            this.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover.TabIndex = 10;
            this.cover.TabStop = false;
            // 
            // txt_rate
            // 
            this.txt_rate.BackColor = System.Drawing.Color.Transparent;
            this.txt_rate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_rate.Location = new System.Drawing.Point(22, 183);
            this.txt_rate.Margin = new System.Windows.Forms.Padding(6);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(303, 37);
            this.txt_rate.TabIndex = 9;
            this.txt_rate.Value = 0;
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.SeaGreen;
            this.txt_date.BorderRadius = 0;
            this.txt_date.ForeColor = System.Drawing.Color.White;
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date.FormatCustom = null;
            this.txt_date.Location = new System.Drawing.Point(14, 82);
            this.txt_date.Margin = new System.Windows.Forms.Padding(6);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(311, 36);
            this.txt_date.TabIndex = 8;
            this.txt_date.Value = new System.DateTime(2020, 7, 14, 16, 21, 21, 61);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "غلاف الكتاب";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "تقيم الكتاب";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "تاريخ النشر";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_cat);
            this.groupBox1.Controls.Add(this.txt_auther);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lb_Title);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(429, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(335, 463);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الأساسية";
            // 
            // txt_price
            // 
            this.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_price.AutoSize = true;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(57, 409);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(0, 24);
            this.txt_price.TabIndex = 13;
            this.txt_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cat
            // 
            this.txt_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cat.AutoSize = true;
            this.txt_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat.Location = new System.Drawing.Point(57, 307);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(0, 24);
            this.txt_cat.TabIndex = 12;
            this.txt_cat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_auther
            // 
            this.txt_auther.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_auther.AutoSize = true;
            this.txt_auther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auther.Location = new System.Drawing.Point(57, 199);
            this.txt_auther.Name = "txt_auther";
            this.txt_auther.Size = new System.Drawing.Size(0, 24);
            this.txt_auther.TabIndex = 11;
            this.txt_auther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_title
            // 
            this.txt_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(57, 103);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(0, 24);
            this.txt_title.TabIndex = 10;
            this.txt_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "سعر الكتاب";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "صنف الكتاب";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المؤلف";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(234, 51);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(73, 24);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "اسم الكتاب";
            // 
            // FRM_DETBOOKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(802, 553);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_DETBOOKS";
            this.Opacity = 0.85D;
            this.Text = "FRM_DETBOOKS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox cover;
        public Bunifu.Framework.UI.BunifuRating txt_rate;
        public Bunifu.Framework.UI.BunifuDatepicker txt_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Title;
        public System.Windows.Forms.Label txt_title;
        public System.Windows.Forms.Label txt_price;
        public System.Windows.Forms.Label txt_cat;
        public System.Windows.Forms.Label txt_auther;
    }
}