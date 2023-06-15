
namespace AlzheimerSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtPss = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblPWD = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(101, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "早期預防偵測系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(135, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "帳號:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(133, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "密碼:";
            // 
            // txtAcc
            // 
            this.txtAcc.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAcc.Location = new System.Drawing.Point(257, 254);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(420, 47);
            this.txtAcc.TabIndex = 3;
            this.txtAcc.Text = "123@gmail.com";
            this.txtAcc.TextChanged += new System.EventHandler(this.txtAcc_TextChanged);
            this.txtAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_KeyDown);
            // 
            // txtPss
            // 
            this.txtPss.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPss.Location = new System.Drawing.Point(260, 350);
            this.txtPss.Margin = new System.Windows.Forms.Padding(4);
            this.txtPss.Name = "txtPss";
            this.txtPss.Size = new System.Drawing.Size(420, 47);
            this.txtPss.TabIndex = 4;
            this.txtPss.Text = "!a123";
            this.txtPss.UseSystemPasswordChar = true;
            this.txtPss.TextChanged += new System.EventHandler(this.txtPss_TextChanged);
            this.txtPss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPss_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.Color.Beige;
            this.btnLogin.Location = new System.Drawing.Point(335, 439);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 65);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAcc.ForeColor = System.Drawing.Color.Brown;
            this.lblAcc.Location = new System.Drawing.Point(692, 265);
            this.lblAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(0, 30);
            this.lblAcc.TabIndex = 6;
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPWD.ForeColor = System.Drawing.Color.Brown;
            this.lblPWD.Location = new System.Drawing.Point(760, 360);
            this.lblPWD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(0, 30);
            this.lblPWD.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.lblLogin.ForeColor = System.Drawing.Color.Brown;
            this.lblLogin.Location = new System.Drawing.Point(575, 459);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 30);
            this.lblLogin.TabIndex = 8;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.Transparent;
            this.btnHide.Location = new System.Drawing.Point(689, 346);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(56, 52);
            this.btnHide.TabIndex = 9;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Visible = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnShow.Location = new System.Drawing.Point(689, 348);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(56, 51);
            this.btnShow.TabIndex = 10;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CaptionBackColorBottom = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionBackColorTop = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionFont = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClientSize = new System.Drawing.Size(933, 528);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(5, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Radius = 15;
            this.Text = "早期預防，你我安心";
            this.TitleOffset = new System.Drawing.Point(20, 2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtPss;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
    }
}