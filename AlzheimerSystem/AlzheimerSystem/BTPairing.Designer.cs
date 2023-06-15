
namespace AlzheimerSystem
{
    partial class BTPairing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTPairing));
            this.DataGridView = new CCWin.SkinControl.SkinDataGridView();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtbxBTnameModify = new CCWin.SkinControl.SkinTextBox();
            this.btnModify = new CCWin.SkinControl.SkinButton();
            this.btnDelete = new CCWin.SkinControl.SkinButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new CCWin.SkinControl.SkinButton();
            this.cmboboxLoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ColumnFont = null;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ColumnSelectBackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridView.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridView.HeadFont = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataGridView.HeadSelectBackColor = System.Drawing.Color.LightSlateGray;
            this.DataGridView.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView.LineNumberForeColor = System.Drawing.Color.Black;
            this.DataGridView.Location = new System.Drawing.Point(77, 66);
            this.DataGridView.MouseCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(168)))), ((int)(((byte)(181)))));
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.RowTemplate.Height = 23;
            this.DataGridView.Size = new System.Drawing.Size(651, 275);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.TitleBack = null;
            this.DataGridView.TitleBackColorBegin = System.Drawing.Color.White;
            this.DataGridView.TitleBackColorEnd = System.Drawing.Color.LightSteelBlue;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.skinLabel1.Location = new System.Drawing.Point(5, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 36);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "地點:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.skinLabel2.Location = new System.Drawing.Point(205, 15);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(138, 36);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "藍芽名稱:";
            // 
            // txtbxBTnameModify
            // 
            this.txtbxBTnameModify.BackColor = System.Drawing.Color.Transparent;
            this.txtbxBTnameModify.DownBack = null;
            this.txtbxBTnameModify.Enabled = false;
            this.txtbxBTnameModify.Icon = null;
            this.txtbxBTnameModify.IconIsButton = false;
            this.txtbxBTnameModify.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbxBTnameModify.IsPasswordChat = '\0';
            this.txtbxBTnameModify.IsSystemPasswordChar = false;
            this.txtbxBTnameModify.Lines = new string[0];
            this.txtbxBTnameModify.Location = new System.Drawing.Point(352, 15);
            this.txtbxBTnameModify.Margin = new System.Windows.Forms.Padding(0);
            this.txtbxBTnameModify.MaxLength = 32767;
            this.txtbxBTnameModify.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbxBTnameModify.MouseBack = null;
            this.txtbxBTnameModify.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbxBTnameModify.Multiline = true;
            this.txtbxBTnameModify.Name = "txtbxBTnameModify";
            this.txtbxBTnameModify.NormlBack = null;
            this.txtbxBTnameModify.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxBTnameModify.ReadOnly = true;
            this.txtbxBTnameModify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxBTnameModify.Size = new System.Drawing.Size(285, 40);
            // 
            // 
            // 
            this.txtbxBTnameModify.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxBTnameModify.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxBTnameModify.SkinTxt.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBTnameModify.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbxBTnameModify.SkinTxt.Multiline = true;
            this.txtbxBTnameModify.SkinTxt.Name = "BaseText";
            this.txtbxBTnameModify.SkinTxt.ReadOnly = true;
            this.txtbxBTnameModify.SkinTxt.Size = new System.Drawing.Size(275, 30);
            this.txtbxBTnameModify.SkinTxt.TabIndex = 0;
            this.txtbxBTnameModify.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbxBTnameModify.SkinTxt.WaterText = "";
            this.txtbxBTnameModify.TabIndex = 4;
            this.txtbxBTnameModify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbxBTnameModify.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbxBTnameModify.WaterText = "";
            this.txtbxBTnameModify.WordWrap = true;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.BaseColor = System.Drawing.Color.Silver;
            this.btnModify.BorderColor = System.Drawing.Color.White;
            this.btnModify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModify.DownBack = null;
            this.btnModify.DownBaseColor = System.Drawing.Color.Gray;
            this.btnModify.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.IsDrawGlass = false;
            this.btnModify.Location = new System.Drawing.Point(11, 71);
            this.btnModify.MouseBack = null;
            this.btnModify.MouseBaseColor = System.Drawing.Color.Gray;
            this.btnModify.Name = "btnModify";
            this.btnModify.NormlBack = null;
            this.btnModify.Size = new System.Drawing.Size(142, 40);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "修改配對";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Silver;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.DownBack = null;
            this.btnDelete.DownBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.IsDrawGlass = false;
            this.btnDelete.Location = new System.Drawing.Point(490, 72);
            this.btnDelete.MouseBack = null;
            this.btnDelete.MouseBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = null;
            this.btnDelete.Size = new System.Drawing.Size(147, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "刪除配對";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmboboxLoc);
            this.GroupBox1.Controls.Add(this.skinLabel1);
            this.GroupBox1.Controls.Add(this.btnDelete);
            this.GroupBox1.Controls.Add(this.btnModify);
            this.GroupBox1.Controls.Add(this.skinLabel2);
            this.GroupBox1.Controls.Add(this.txtbxBTnameModify);
            this.GroupBox1.Location = new System.Drawing.Point(80, 361);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(651, 124);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.Silver;
            this.btnBack.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBack.DownBack = null;
            this.btnBack.DownBaseColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.IsDrawGlass = false;
            this.btnBack.Location = new System.Drawing.Point(734, 66);
            this.btnBack.MouseBack = null;
            this.btnBack.MouseBaseColor = System.Drawing.Color.Gray;
            this.btnBack.Name = "btnBack";
            this.btnBack.NormlBack = null;
            this.btnBack.Size = new System.Drawing.Size(61, 162);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "返回上一頁";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmboboxLoc
            // 
            this.cmboboxLoc.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmboboxLoc.FormattingEnabled = true;
            this.cmboboxLoc.Location = new System.Drawing.Point(78, 15);
            this.cmboboxLoc.Name = "cmboboxLoc";
            this.cmboboxLoc.Size = new System.Drawing.Size(121, 38);
            this.cmboboxLoc.TabIndex = 7;
            // 
            // BTPairing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(209)))));
            this.CaptionBackColorBottom = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionBackColorTop = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionFont = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClientSize = new System.Drawing.Size(852, 508);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(5, 0);
            this.Name = "BTPairing";
            this.Text = "藍芽配對";
            this.Load += new System.EventHandler(this.BTPairing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView DataGridView;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox txtbxBTnameModify;
        private CCWin.SkinControl.SkinButton btnModify;
        private CCWin.SkinControl.SkinButton btnDelete;
        private System.Windows.Forms.GroupBox GroupBox1;
        private CCWin.SkinControl.SkinButton btnBack;
        private System.Windows.Forms.ComboBox cmboboxLoc;
    }
}