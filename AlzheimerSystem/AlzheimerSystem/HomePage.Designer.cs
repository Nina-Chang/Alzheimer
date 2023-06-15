
namespace AlzheimerSystem
{
    partial class HomePage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnScan = new CCWin.SkinControl.SkinButton();
            this.btnBT = new CCWin.SkinControl.SkinButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPortR = new System.IO.Ports.SerialPort(this.components);
            this.btnModifyPairing = new CCWin.SkinControl.SkinButton();
            this.lblwrong = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltime10 = new System.Windows.Forms.Label();
            this.lbltime9 = new System.Windows.Forms.Label();
            this.lbltime8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.skinCmbobxBT10 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace10 = new CCWin.SkinControl.SkinComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.skinCmbobxBT9 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace9 = new CCWin.SkinControl.SkinComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.skinCmbobxBT8 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace8 = new CCWin.SkinControl.SkinComboBox();
            this.lbltime7 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.skinCmbobxBT7 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace7 = new CCWin.SkinControl.SkinComboBox();
            this.lbltime6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltime5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.skinCmbobxBT6 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace6 = new CCWin.SkinControl.SkinComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblRepeat5 = new System.Windows.Forms.Label();
            this.skinCmbobxBT5 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace5 = new CCWin.SkinControl.SkinComboBox();
            this.lbltime4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRepeat4 = new System.Windows.Forms.Label();
            this.skinCmbobxBT4 = new CCWin.SkinControl.SkinComboBox();
            this.skinCmbobxPlace4 = new CCWin.SkinControl.SkinComboBox();
            this.lbltime3 = new System.Windows.Forms.Label();
            this.lbltime2 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRepeat3 = new System.Windows.Forms.Label();
            this.cmboBxBT3 = new CCWin.SkinControl.SkinComboBox();
            this.cmbPlace3 = new CCWin.SkinControl.SkinComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRepeat2 = new System.Windows.Forms.Label();
            this.cmboBxBT2 = new CCWin.SkinControl.SkinComboBox();
            this.cmbPlace2 = new CCWin.SkinControl.SkinComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboBxBT = new CCWin.SkinControl.SkinComboBox();
            this.cmbPlace = new CCWin.SkinControl.SkinComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增感測器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.BaseColor = System.Drawing.Color.Silver;
            this.btnScan.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnScan.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnScan.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnScan.DownBack = null;
            this.btnScan.DownBaseColor = System.Drawing.Color.Gray;
            this.btnScan.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnScan.IsDrawGlass = false;
            this.btnScan.Location = new System.Drawing.Point(41, 92);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnScan.MouseBack = null;
            this.btnScan.MouseBaseColor = System.Drawing.Color.Gray;
            this.btnScan.Name = "btnScan";
            this.btnScan.NormlBack = null;
            this.btnScan.Radius = 4;
            this.btnScan.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnScan.Size = new System.Drawing.Size(279, 128);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "選取感測器";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnBT
            // 
            this.btnBT.BackColor = System.Drawing.Color.Transparent;
            this.btnBT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.btnBT.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnBT.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBT.DownBack = null;
            this.btnBT.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(154)))), ((int)(((byte)(146)))));
            this.btnBT.Font = new System.Drawing.Font("微軟正黑體", 21.75F);
            this.btnBT.IsDrawGlass = false;
            this.btnBT.Location = new System.Drawing.Point(429, 93);
            this.btnBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBT.MouseBack = null;
            this.btnBT.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(154)))), ((int)(((byte)(146)))));
            this.btnBT.Name = "btnBT";
            this.btnBT.NormlBack = null;
            this.btnBT.Radius = 4;
            this.btnBT.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnBT.Size = new System.Drawing.Size(279, 128);
            this.btnBT.TabIndex = 3;
            this.btnBT.Text = "啟動感測器";
            this.btnBT.UseVisualStyleBackColor = false;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnModifyPairing
            // 
            this.btnModifyPairing.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyPairing.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(209)))));
            this.btnModifyPairing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(209)))));
            this.btnModifyPairing.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModifyPairing.DownBack = null;
            this.btnModifyPairing.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(154)))), ((int)(((byte)(139)))));
            this.btnModifyPairing.Font = new System.Drawing.Font("微軟正黑體", 21.75F);
            this.btnModifyPairing.IsDrawGlass = false;
            this.btnModifyPairing.Location = new System.Drawing.Point(816, 93);
            this.btnModifyPairing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModifyPairing.MouseBack = null;
            this.btnModifyPairing.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(154)))), ((int)(((byte)(139)))));
            this.btnModifyPairing.Name = "btnModifyPairing";
            this.btnModifyPairing.NormlBack = null;
            this.btnModifyPairing.Radius = 4;
            this.btnModifyPairing.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnModifyPairing.Size = new System.Drawing.Size(279, 128);
            this.btnModifyPairing.TabIndex = 10;
            this.btnModifyPairing.Text = "修改藍芽配對";
            this.btnModifyPairing.UseVisualStyleBackColor = false;
            this.btnModifyPairing.Click += new System.EventHandler(this.btnModifyPairing_Click);
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblwrong.ForeColor = System.Drawing.Color.Firebrick;
            this.lblwrong.Location = new System.Drawing.Point(411, 232);
            this.lblwrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(0, 35);
            this.lblwrong.TabIndex = 11;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDone.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDone.Location = new System.Drawing.Point(35, 232);
            this.lblDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(0, 35);
            this.lblDone.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 280);
            this.panel1.Controls.Add(this.lbltime10);
            this.panel1.Controls.Add(this.lbltime9);
            this.panel1.Controls.Add(this.lbltime8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox10);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.lbltime7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.lbltime6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbltime5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.lbltime4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.lbltime3);
            this.panel1.Controls.Add(this.lbltime2);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 272);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 953);
            this.panel1.TabIndex = 13;
            // 
            // lbltime10
            // 
            this.lbltime10.AutoSize = true;
            this.lbltime10.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime10.ForeColor = System.Drawing.Color.Beige;
            this.lbltime10.Location = new System.Drawing.Point(956, 1988);
            this.lbltime10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime10.Name = "lbltime10";
            this.lbltime10.Size = new System.Drawing.Size(0, 129);
            this.lbltime10.TabIndex = 62;
            this.lbltime10.Visible = false;
            // 
            // lbltime9
            // 
            this.lbltime9.AutoSize = true;
            this.lbltime9.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime9.ForeColor = System.Drawing.Color.Beige;
            this.lbltime9.Location = new System.Drawing.Point(956, 1777);
            this.lbltime9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime9.Name = "lbltime9";
            this.lbltime9.Size = new System.Drawing.Size(0, 129);
            this.lbltime9.TabIndex = 61;
            this.lbltime9.Visible = false;
            // 
            // lbltime8
            // 
            this.lbltime8.AutoSize = true;
            this.lbltime8.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime8.ForeColor = System.Drawing.Color.Beige;
            this.lbltime8.Location = new System.Drawing.Point(956, 1563);
            this.lbltime8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime8.Name = "lbltime8";
            this.lbltime8.Size = new System.Drawing.Size(0, 129);
            this.lbltime8.TabIndex = 60;
            this.lbltime8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Beige;
            this.label10.Location = new System.Drawing.Point(733, 1988);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 129);
            this.label10.TabIndex = 59;
            this.label10.Text = "次數:";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Beige;
            this.label9.Location = new System.Drawing.Point(733, 1777);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 129);
            this.label9.TabIndex = 58;
            this.label9.Text = "次數:";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Beige;
            this.label8.Location = new System.Drawing.Point(733, 1563);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 129);
            this.label8.TabIndex = 57;
            this.label8.Text = "次數:";
            this.label8.Visible = false;
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.Controls.Add(this.skinCmbobxBT10);
            this.groupBox10.Controls.Add(this.skinCmbobxPlace10);
            this.groupBox10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox10.Location = new System.Drawing.Point(68, 1945);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox10.Size = new System.Drawing.Size(660, 183);
            this.groupBox10.TabIndex = 56;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "感測器10";
            this.groupBox10.Visible = false;
            // 
            // skinCmbobxBT10
            // 
            this.skinCmbobxBT10.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT10.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT10.FormattingEnabled = true;
            this.skinCmbobxBT10.Items.AddRange(new object[] {
            "HIM19:98D391FD9EA7",
            "HIM01:98D3B1FD52C1",
            "HIM10:98D321FC7C06"});
            this.skinCmbobxBT10.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT10.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT10.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT10.Name = "skinCmbobxBT10";
            this.skinCmbobxBT10.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT10.TabIndex = 1;
            this.skinCmbobxBT10.WaterText = "";
            // 
            // skinCmbobxPlace10
            // 
            this.skinCmbobxPlace10.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace10.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace10.FormattingEnabled = true;
            this.skinCmbobxPlace10.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace10.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.skinCmbobxPlace10.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace10.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace10.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace10.Name = "skinCmbobxPlace10";
            this.skinCmbobxPlace10.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace10.TabIndex = 0;
            this.skinCmbobxPlace10.WaterText = "";
            // 
            // groupBox9
            // 
            this.groupBox9.AutoSize = true;
            this.groupBox9.Controls.Add(this.skinCmbobxBT9);
            this.groupBox9.Controls.Add(this.skinCmbobxPlace9);
            this.groupBox9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox9.Location = new System.Drawing.Point(68, 1732);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox9.Size = new System.Drawing.Size(660, 183);
            this.groupBox9.TabIndex = 55;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "感測器9";
            this.groupBox9.Visible = false;
            // 
            // skinCmbobxBT9
            // 
            this.skinCmbobxBT9.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT9.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT9.FormattingEnabled = true;
            this.skinCmbobxBT9.Items.AddRange(new object[] {
            "HIM19:98D391FD9EA7",
            "HIM01:98D3B1FD52C1",
            "HIM10:98D321FC7C06"});
            this.skinCmbobxBT9.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT9.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT9.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT9.Name = "skinCmbobxBT9";
            this.skinCmbobxBT9.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT9.TabIndex = 1;
            this.skinCmbobxBT9.WaterText = "";
            // 
            // skinCmbobxPlace9
            // 
            this.skinCmbobxPlace9.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace9.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace9.FormattingEnabled = true;
            this.skinCmbobxPlace9.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace9.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.skinCmbobxPlace9.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace9.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace9.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace9.Name = "skinCmbobxPlace9";
            this.skinCmbobxPlace9.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace9.TabIndex = 0;
            this.skinCmbobxPlace9.WaterText = "";
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.skinCmbobxBT8);
            this.groupBox8.Controls.Add(this.skinCmbobxPlace8);
            this.groupBox8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox8.Location = new System.Drawing.Point(68, 1520);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox8.Size = new System.Drawing.Size(660, 183);
            this.groupBox8.TabIndex = 54;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "感測器8";
            this.groupBox8.Visible = false;
            // 
            // skinCmbobxBT8
            // 
            this.skinCmbobxBT8.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT8.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT8.FormattingEnabled = true;
            this.skinCmbobxBT8.Items.AddRange(new object[] {
            "HIM19:98D391FD9EA7",
            "HIM01:98D3B1FD52C1",
            "HIM10:98D321FC7C06"});
            this.skinCmbobxBT8.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT8.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT8.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT8.Name = "skinCmbobxBT8";
            this.skinCmbobxBT8.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT8.TabIndex = 1;
            this.skinCmbobxBT8.WaterText = "";
            // 
            // skinCmbobxPlace8
            // 
            this.skinCmbobxPlace8.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace8.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace8.FormattingEnabled = true;
            this.skinCmbobxPlace8.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace8.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.skinCmbobxPlace8.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace8.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace8.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace8.Name = "skinCmbobxPlace8";
            this.skinCmbobxPlace8.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace8.TabIndex = 0;
            this.skinCmbobxPlace8.WaterText = "";
            // 
            // lbltime7
            // 
            this.lbltime7.AutoSize = true;
            this.lbltime7.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime7.ForeColor = System.Drawing.Color.Beige;
            this.lbltime7.Location = new System.Drawing.Point(956, 1353);
            this.lbltime7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime7.Name = "lbltime7";
            this.lbltime7.Size = new System.Drawing.Size(0, 129);
            this.lbltime7.TabIndex = 53;
            this.lbltime7.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Beige;
            this.label7.Location = new System.Drawing.Point(733, 1353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 129);
            this.label7.TabIndex = 52;
            this.label7.Text = "次數:";
            this.label7.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.skinCmbobxBT7);
            this.groupBox7.Controls.Add(this.skinCmbobxPlace7);
            this.groupBox7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox7.Location = new System.Drawing.Point(68, 1310);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(660, 183);
            this.groupBox7.TabIndex = 51;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "感測器7";
            this.groupBox7.Visible = false;
            // 
            // skinCmbobxBT7
            // 
            this.skinCmbobxBT7.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT7.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT7.FormattingEnabled = true;
            this.skinCmbobxBT7.Items.AddRange(new object[] {
            "HIM19:98D391FD9EA7",
            "HIM01:98D3B1FD52C1",
            "HIM10:98D321FC7C06"});
            this.skinCmbobxBT7.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT7.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT7.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT7.Name = "skinCmbobxBT7";
            this.skinCmbobxBT7.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT7.TabIndex = 1;
            this.skinCmbobxBT7.WaterText = "";
            // 
            // skinCmbobxPlace7
            // 
            this.skinCmbobxPlace7.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace7.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace7.FormattingEnabled = true;
            this.skinCmbobxPlace7.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace7.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.skinCmbobxPlace7.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace7.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace7.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace7.Name = "skinCmbobxPlace7";
            this.skinCmbobxPlace7.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace7.TabIndex = 0;
            this.skinCmbobxPlace7.WaterText = "";
            // 
            // lbltime6
            // 
            this.lbltime6.AutoSize = true;
            this.lbltime6.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime6.ForeColor = System.Drawing.Color.Beige;
            this.lbltime6.Location = new System.Drawing.Point(956, 1143);
            this.lbltime6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime6.Name = "lbltime6";
            this.lbltime6.Size = new System.Drawing.Size(0, 129);
            this.lbltime6.TabIndex = 50;
            this.lbltime6.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Beige;
            this.label6.Location = new System.Drawing.Point(733, 1143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 129);
            this.label6.TabIndex = 49;
            this.label6.Text = "次數:";
            this.label6.Visible = false;
            // 
            // lbltime5
            // 
            this.lbltime5.AutoSize = true;
            this.lbltime5.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime5.ForeColor = System.Drawing.Color.Beige;
            this.lbltime5.Location = new System.Drawing.Point(956, 935);
            this.lbltime5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime5.Name = "lbltime5";
            this.lbltime5.Size = new System.Drawing.Size(0, 129);
            this.lbltime5.TabIndex = 48;
            this.lbltime5.Visible = false;
            this.lbltime5.TextChanged += new System.EventHandler(this.lbltime5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(743, 935);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 129);
            this.label5.TabIndex = 47;
            this.label5.Text = "次數:";
            this.label5.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.skinCmbobxBT6);
            this.groupBox6.Controls.Add(this.skinCmbobxPlace6);
            this.groupBox6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox6.Location = new System.Drawing.Point(68, 1100);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(660, 183);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "感測器6";
            this.groupBox6.Visible = false;
            // 
            // skinCmbobxBT6
            // 
            this.skinCmbobxBT6.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT6.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT6.FormattingEnabled = true;
            this.skinCmbobxBT6.Items.AddRange(new object[] {
            "HIM19:98D391FD9EA7",
            "HIM01:98D3B1FD52C1",
            "HIM10:98D321FC7C06"});
            this.skinCmbobxBT6.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT6.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT6.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT6.Name = "skinCmbobxBT6";
            this.skinCmbobxBT6.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT6.TabIndex = 1;
            this.skinCmbobxBT6.WaterText = "";
            // 
            // skinCmbobxPlace6
            // 
            this.skinCmbobxPlace6.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace6.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace6.FormattingEnabled = true;
            this.skinCmbobxPlace6.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace6.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.skinCmbobxPlace6.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace6.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace6.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace6.Name = "skinCmbobxPlace6";
            this.skinCmbobxPlace6.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace6.TabIndex = 0;
            this.skinCmbobxPlace6.WaterText = "";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.lblRepeat5);
            this.groupBox5.Controls.Add(this.skinCmbobxBT5);
            this.groupBox5.Controls.Add(this.skinCmbobxPlace5);
            this.groupBox5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox5.Location = new System.Drawing.Point(68, 892);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(660, 247);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "感測器5";
            this.groupBox5.Visible = false;
            // 
            // lblRepeat5
            // 
            this.lblRepeat5.AutoSize = true;
            this.lblRepeat5.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRepeat5.Location = new System.Drawing.Point(20, 125);
            this.lblRepeat5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat5.Name = "lblRepeat5";
            this.lblRepeat5.Size = new System.Drawing.Size(0, 38);
            this.lblRepeat5.TabIndex = 2;
            // 
            // skinCmbobxBT5
            // 
            this.skinCmbobxBT5.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT5.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT5.FormattingEnabled = true;
            this.skinCmbobxBT5.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT5.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT5.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT5.Name = "skinCmbobxBT5";
            this.skinCmbobxBT5.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT5.TabIndex = 1;
            this.skinCmbobxBT5.WaterText = "";
            this.skinCmbobxBT5.SelectedIndexChanged += new System.EventHandler(this.skinCmbobxBT5_SelectedIndexChanged);
            this.skinCmbobxBT5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinCmbobxBT5_MouseDown);
            // 
            // skinCmbobxPlace5
            // 
            this.skinCmbobxPlace5.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace5.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace5.FormattingEnabled = true;
            this.skinCmbobxPlace5.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace5.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace5.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace5.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace5.Name = "skinCmbobxPlace5";
            this.skinCmbobxPlace5.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace5.TabIndex = 0;
            this.skinCmbobxPlace5.WaterText = "";
            // 
            // lbltime4
            // 
            this.lbltime4.AutoSize = true;
            this.lbltime4.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime4.ForeColor = System.Drawing.Color.Beige;
            this.lbltime4.Location = new System.Drawing.Point(956, 723);
            this.lbltime4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime4.Name = "lbltime4";
            this.lbltime4.Size = new System.Drawing.Size(0, 129);
            this.lbltime4.TabIndex = 44;
            this.lbltime4.Visible = false;
            this.lbltime4.TextChanged += new System.EventHandler(this.lbltime4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(743, 723);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 129);
            this.label4.TabIndex = 43;
            this.label4.Text = "次數:";
            this.label4.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRepeat4);
            this.groupBox4.Controls.Add(this.skinCmbobxBT4);
            this.groupBox4.Controls.Add(this.skinCmbobxPlace4);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox4.Location = new System.Drawing.Point(68, 682);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(660, 183);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "感測器4";
            this.groupBox4.Visible = false;
            // 
            // lblRepeat4
            // 
            this.lblRepeat4.AutoSize = true;
            this.lblRepeat4.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRepeat4.Location = new System.Drawing.Point(20, 132);
            this.lblRepeat4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat4.Name = "lblRepeat4";
            this.lblRepeat4.Size = new System.Drawing.Size(0, 38);
            this.lblRepeat4.TabIndex = 2;
            // 
            // skinCmbobxBT4
            // 
            this.skinCmbobxBT4.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxBT4.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxBT4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxBT4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxBT4.FormattingEnabled = true;
            this.skinCmbobxBT4.Location = new System.Drawing.Point(28, 72);
            this.skinCmbobxBT4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxBT4.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT4.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxBT4.Name = "skinCmbobxBT4";
            this.skinCmbobxBT4.Size = new System.Drawing.Size(300, 48);
            this.skinCmbobxBT4.TabIndex = 1;
            this.skinCmbobxBT4.WaterText = "";
            this.skinCmbobxBT4.SelectedIndexChanged += new System.EventHandler(this.skinCmbobxBT4_SelectedIndexChanged);
            this.skinCmbobxBT4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinCmbobxBT4_MouseDown);
            // 
            // skinCmbobxPlace4
            // 
            this.skinCmbobxPlace4.BaseColor = System.Drawing.Color.White;
            this.skinCmbobxPlace4.BorderColor = System.Drawing.Color.White;
            this.skinCmbobxPlace4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbobxPlace4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbobxPlace4.FormattingEnabled = true;
            this.skinCmbobxPlace4.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.skinCmbobxPlace4.Location = new System.Drawing.Point(404, 72);
            this.skinCmbobxPlace4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinCmbobxPlace4.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace4.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.skinCmbobxPlace4.Name = "skinCmbobxPlace4";
            this.skinCmbobxPlace4.Size = new System.Drawing.Size(191, 48);
            this.skinCmbobxPlace4.TabIndex = 0;
            this.skinCmbobxPlace4.WaterText = "";
            // 
            // lbltime3
            // 
            this.lbltime3.AutoSize = true;
            this.lbltime3.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime3.ForeColor = System.Drawing.Color.Beige;
            this.lbltime3.Location = new System.Drawing.Point(958, 507);
            this.lbltime3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime3.Name = "lbltime3";
            this.lbltime3.Size = new System.Drawing.Size(0, 129);
            this.lbltime3.TabIndex = 18;
            this.lbltime3.TextChanged += new System.EventHandler(this.lbltime3_TextChanged);
            // 
            // lbltime2
            // 
            this.lbltime2.AutoSize = true;
            this.lbltime2.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime2.ForeColor = System.Drawing.Color.Beige;
            this.lbltime2.Location = new System.Drawing.Point(958, 290);
            this.lbltime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime2.Name = "lbltime2";
            this.lbltime2.Size = new System.Drawing.Size(0, 129);
            this.lbltime2.TabIndex = 17;
            this.lbltime2.TextChanged += new System.EventHandler(this.lbltime2_TextChanged);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Beige;
            this.lbltime.Location = new System.Drawing.Point(958, 93);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 129);
            this.lbltime.TabIndex = 16;
            this.lbltime.TextChanged += new System.EventHandler(this.lbltime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(743, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 129);
            this.label3.TabIndex = 15;
            this.label3.Text = "次數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(736, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 129);
            this.label2.TabIndex = 14;
            this.label2.Text = "次數:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(743, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 129);
            this.label1.TabIndex = 13;
            this.label1.Text = "次數:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRepeat3);
            this.groupBox3.Controls.Add(this.cmboBxBT3);
            this.groupBox3.Controls.Add(this.cmbPlace3);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(68, 462);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(660, 183);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "感測器3";
            // 
            // lblRepeat3
            // 
            this.lblRepeat3.AutoSize = true;
            this.lblRepeat3.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRepeat3.Location = new System.Drawing.Point(20, 132);
            this.lblRepeat3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat3.Name = "lblRepeat3";
            this.lblRepeat3.Size = new System.Drawing.Size(0, 38);
            this.lblRepeat3.TabIndex = 2;
            // 
            // cmboBxBT3
            // 
            this.cmboBxBT3.BaseColor = System.Drawing.Color.White;
            this.cmboBxBT3.BorderColor = System.Drawing.Color.White;
            this.cmboBxBT3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBxBT3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxBT3.FormattingEnabled = true;
            this.cmboBxBT3.Items.AddRange(new object[] {
            "HIM10:98D321FC7C06",
            "HIM13:98D311FC223C",
            "HIM15:98D371FD4468"});
            this.cmboBxBT3.Location = new System.Drawing.Point(28, 72);
            this.cmboBxBT3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboBxBT3.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.cmboBxBT3.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.cmboBxBT3.Name = "cmboBxBT3";
            this.cmboBxBT3.Size = new System.Drawing.Size(300, 48);
            this.cmboBxBT3.TabIndex = 1;
            this.cmboBxBT3.WaterText = "";
            this.cmboBxBT3.SelectedIndexChanged += new System.EventHandler(this.cmboBxBT3_SelectedIndexChanged);
            this.cmboBxBT3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmboBxBT3_MouseDown);
            // 
            // cmbPlace3
            // 
            this.cmbPlace3.BaseColor = System.Drawing.Color.White;
            this.cmbPlace3.BorderColor = System.Drawing.Color.White;
            this.cmbPlace3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPlace3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace3.FormattingEnabled = true;
            this.cmbPlace3.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbPlace3.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.cmbPlace3.Location = new System.Drawing.Point(404, 72);
            this.cmbPlace3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPlace3.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPlace3.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPlace3.Name = "cmbPlace3";
            this.cmbPlace3.Size = new System.Drawing.Size(191, 48);
            this.cmbPlace3.TabIndex = 0;
            this.cmbPlace3.WaterText = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRepeat2);
            this.groupBox2.Controls.Add(this.cmboBxBT2);
            this.groupBox2.Controls.Add(this.cmbPlace2);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(68, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(660, 183);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "感測器2";
            // 
            // lblRepeat2
            // 
            this.lblRepeat2.AutoSize = true;
            this.lblRepeat2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRepeat2.Location = new System.Drawing.Point(20, 132);
            this.lblRepeat2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat2.Name = "lblRepeat2";
            this.lblRepeat2.Size = new System.Drawing.Size(0, 38);
            this.lblRepeat2.TabIndex = 2;
            // 
            // cmboBxBT2
            // 
            this.cmboBxBT2.BaseColor = System.Drawing.Color.White;
            this.cmboBxBT2.BorderColor = System.Drawing.Color.White;
            this.cmboBxBT2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBxBT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxBT2.FormattingEnabled = true;
            this.cmboBxBT2.Items.AddRange(new object[] {
            "HIM10:98D321FC7C06",
            "HIM13:98D311FC223C",
            "HIM15:98D371FD4468"});
            this.cmboBxBT2.Location = new System.Drawing.Point(28, 72);
            this.cmboBxBT2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboBxBT2.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.cmboBxBT2.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.cmboBxBT2.Name = "cmboBxBT2";
            this.cmboBxBT2.Size = new System.Drawing.Size(300, 48);
            this.cmboBxBT2.TabIndex = 1;
            this.cmboBxBT2.WaterText = "";
            this.cmboBxBT2.SelectedIndexChanged += new System.EventHandler(this.cmboBxBT2_SelectedIndexChanged);
            this.cmboBxBT2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmboBxBT2_MouseDown);
            // 
            // cmbPlace2
            // 
            this.cmbPlace2.BaseColor = System.Drawing.Color.White;
            this.cmbPlace2.BorderColor = System.Drawing.Color.White;
            this.cmbPlace2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPlace2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace2.FormattingEnabled = true;
            this.cmbPlace2.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbPlace2.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.cmbPlace2.Location = new System.Drawing.Point(404, 72);
            this.cmbPlace2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPlace2.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPlace2.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPlace2.Name = "cmbPlace2";
            this.cmbPlace2.Size = new System.Drawing.Size(191, 48);
            this.cmbPlace2.TabIndex = 0;
            this.cmbPlace2.WaterText = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboBxBT);
            this.groupBox1.Controls.Add(this.cmbPlace);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(68, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(660, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "感測器1";
            // 
            // cmboBxBT
            // 
            this.cmboBxBT.BaseColor = System.Drawing.Color.White;
            this.cmboBxBT.BorderColor = System.Drawing.Color.White;
            this.cmboBxBT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBxBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxBT.FormattingEnabled = true;
            this.cmboBxBT.Items.AddRange(new object[] {
            "HIM13:98D311FC223C"});
            this.cmboBxBT.Location = new System.Drawing.Point(28, 72);
            this.cmboBxBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboBxBT.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.cmboBxBT.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.cmboBxBT.Name = "cmboBxBT";
            this.cmboBxBT.Size = new System.Drawing.Size(300, 48);
            this.cmboBxBT.TabIndex = 1;
            this.cmboBxBT.WaterText = "";
            this.cmboBxBT.SelectedIndexChanged += new System.EventHandler(this.cmboBxBT_SelectedIndexChanged);
            this.cmboBxBT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmboBxBT_MouseDown);
            // 
            // cmbPlace
            // 
            this.cmbPlace.BaseColor = System.Drawing.Color.White;
            this.cmbPlace.BorderColor = System.Drawing.Color.White;
            this.cmbPlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.ItemBorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbPlace.Items.AddRange(new object[] {
            "房間",
            "浴室",
            "書房",
            "飯廳",
            "廚房"});
            this.cmbPlace.Location = new System.Drawing.Point(404, 72);
            this.cmbPlace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPlace.MouseColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPlace.MouseGradientColor = System.Drawing.Color.CornflowerBlue;
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(191, 48);
            this.cmbPlace.TabIndex = 0;
            this.cmbPlace.WaterText = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增感測器ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 28);
            // 
            // 新增感測器ToolStripMenuItem
            // 
            this.新增感測器ToolStripMenuItem.Name = "新增感測器ToolStripMenuItem";
            this.新增感測器ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.新增感測器ToolStripMenuItem.Text = "新增感測器";
            this.新增感測器ToolStripMenuItem.Click += new System.EventHandler(this.新增感測器ToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AccessibleDescription = "";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.BackLayout = false;
            this.CaptionBackColorBottom = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionBackColorTop = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionFont = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1188, 899);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.btnModifyPairing);
            this.Controls.Add(this.btnBT);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EffectBack = System.Drawing.Color.WhiteSmoke;
            this.EffectWidth = 10;
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(5, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomePage";
            this.Radius = 55;
            this.ShadowWidth = 20;
            this.Text = "偵測系統";
            this.TitleOffset = new System.Drawing.Point(20, 2);
            this.TitleSuitColor = true;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton btnScan;
        private CCWin.SkinControl.SkinButton btnBT;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPortR;
        private CCWin.SkinControl.SkinButton btnModifyPairing;
        private System.Windows.Forms.Label lblwrong;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltime3;
        private System.Windows.Forms.Label lbltime2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CCWin.SkinControl.SkinComboBox cmboBxBT3;
        private CCWin.SkinControl.SkinComboBox cmbPlace3;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinComboBox cmboBxBT2;
        private CCWin.SkinControl.SkinComboBox cmbPlace2;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinComboBox cmboBxBT;
        private CCWin.SkinControl.SkinComboBox cmbPlace;
        private System.Windows.Forms.Label lbltime10;
        private System.Windows.Forms.Label lbltime9;
        private System.Windows.Forms.Label lbltime8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox10;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT10;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace10;
        private System.Windows.Forms.GroupBox groupBox9;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT9;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace9;
        private System.Windows.Forms.GroupBox groupBox8;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT8;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace8;
        private System.Windows.Forms.Label lbltime7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT7;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace7;
        private System.Windows.Forms.Label lbltime6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltime5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT6;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace6;
        private System.Windows.Forms.GroupBox groupBox5;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT5;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace5;
        private System.Windows.Forms.Label lbltime4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private CCWin.SkinControl.SkinComboBox skinCmbobxBT4;
        private CCWin.SkinControl.SkinComboBox skinCmbobxPlace4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增感測器ToolStripMenuItem;
        private System.Windows.Forms.Label lblRepeat3;
        private System.Windows.Forms.Label lblRepeat2;
        private System.Windows.Forms.Label lblRepeat5;
        private System.Windows.Forms.Label lblRepeat4;
    }
}

