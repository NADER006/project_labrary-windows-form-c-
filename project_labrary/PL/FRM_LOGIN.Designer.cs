namespace project_labrary.PL
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txt_user
            // 
            this.txt_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user.HintText = "IS@2";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_user.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_user.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_user.LineThickness = 6;
            this.txt_user.Location = new System.Drawing.Point(3, 125);
            this.txt_user.Margin = new System.Windows.Forms.Padding(8);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(389, 55);
            this.txt_user.TabIndex = 14;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "اسم المستخدم ";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = false;
            this.txt_password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_password.LineThickness = 6;
            this.txt_password.Location = new System.Drawing.Point(3, 241);
            this.txt_password.Margin = new System.Windows.Forms.Padding(8);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(389, 63);
            this.txt_password.TabIndex = 16;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "كلمة السر";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(229, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "تسجيل الدخول";
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.BackColor = System.Drawing.SystemColors.Control;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "تسجبل الدخول";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.White;
            this.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(141, 370);
            this.btnadd.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(363, 52);
            this.btnadd.TabIndex = 20;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 432);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_LOGIN";
            this.Text = "FRM_LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FRM_LOGIN_Activated);
            this.Load += new System.EventHandler(this.FRM_LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuThinButton2 btnadd;
    }
}