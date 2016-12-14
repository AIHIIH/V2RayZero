namespace V2RayZero
{
    partial class V2Ray_ZERO
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V2Ray_ZERO));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxTaskbar = new System.Windows.Forms.TextBox();
            this.contextMenuStripTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbService = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.plLeft = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnStar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plRight = new System.Windows.Forms.Panel();
            this.txtAlterID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServicePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIconV2ray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxSecurity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxNetwork = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            this.contextMenuStripTextBox.SuspendLayout();
            this.plLeft.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.plRight.SuspendLayout();
            this.contextMenuStripIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxTaskbar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxTaskbar
            // 
            this.textBoxTaskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.textBoxTaskbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskbar.ContextMenuStrip = this.contextMenuStripTextBox;
            this.textBoxTaskbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTaskbar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.textBoxTaskbar.Location = new System.Drawing.Point(3, 3);
            this.textBoxTaskbar.MaxLength = 0;
            this.textBoxTaskbar.Multiline = true;
            this.textBoxTaskbar.Name = "textBoxTaskbar";
            this.textBoxTaskbar.ReadOnly = true;
            this.textBoxTaskbar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTaskbar.Size = new System.Drawing.Size(813, 437);
            this.textBoxTaskbar.TabIndex = 1;
            // 
            // contextMenuStripTextBox
            // 
            this.contextMenuStripTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.contextMenuStripTextBox.Name = "contextMenuStripTextBox";
            this.contextMenuStripTextBox.Size = new System.Drawing.Size(101, 48);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.TextBoxCopy);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.TextBoxClear);
            // 
            // lsbService
            // 
            this.lsbService.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsbService.FormattingEnabled = true;
            this.lsbService.ItemHeight = 20;
            this.lsbService.Location = new System.Drawing.Point(0, 0);
            this.lsbService.Name = "lsbService";
            this.lsbService.Size = new System.Drawing.Size(312, 384);
            this.lsbService.TabIndex = 20;
            this.lsbService.SelectedIndexChanged += new System.EventHandler(this.lsbService_SelectedIndexChanged);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(165, 451);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 27);
            this.btnDown.TabIndex = 16;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(165, 414);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 27);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(45, 451);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 27);
            this.btnUp.TabIndex = 18;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // plLeft
            // 
            this.plLeft.BackColor = System.Drawing.Color.Gray;
            this.plLeft.Controls.Add(this.lsbService);
            this.plLeft.Controls.Add(this.btnDown);
            this.plLeft.Controls.Add(this.btnDel);
            this.plLeft.Controls.Add(this.btnUp);
            this.plLeft.Controls.Add(this.btnAdd);
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(3, 3);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(312, 511);
            this.plLeft.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGroup.Location = new System.Drawing.Point(121, 382);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(311, 26);
            this.txtGroup.TabIndex = 46;
            this.txtGroup.Tag = "group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(54, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Group";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocalPort.Location = new System.Drawing.Point(121, 306);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(311, 26);
            this.txtLocalPort.TabIndex = 45;
            this.txtLocalPort.Tag = "local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(40, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "本地端口";
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMark.Location = new System.Drawing.Point(121, 344);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(311, 26);
            this.txtMark.TabIndex = 40;
            this.txtMark.Tag = "mark";
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(121, 447);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(88, 47);
            this.btnStar.TabIndex = 42;
            this.btnStar.Text = "OK";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(68, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "备注";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 550);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.plRight);
            this.tabPage1.Controls.Add(this.plLeft);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // plRight
            // 
            this.plRight.BackColor = System.Drawing.Color.Gray;
            this.plRight.Controls.Add(this.cbxNetwork);
            this.plRight.Controls.Add(this.cbxSecurity);
            this.plRight.Controls.Add(this.txtGroup);
            this.plRight.Controls.Add(this.label8);
            this.plRight.Controls.Add(this.txtLocalPort);
            this.plRight.Controls.Add(this.label6);
            this.plRight.Controls.Add(this.txtMark);
            this.plRight.Controls.Add(this.btnStar);
            this.plRight.Controls.Add(this.label7);
            this.plRight.Controls.Add(this.label9);
            this.plRight.Controls.Add(this.label10);
            this.plRight.Controls.Add(this.txtAlterID);
            this.plRight.Controls.Add(this.label4);
            this.plRight.Controls.Add(this.txtLevel);
            this.plRight.Controls.Add(this.label5);
            this.plRight.Controls.Add(this.txtID);
            this.plRight.Controls.Add(this.label3);
            this.plRight.Controls.Add(this.txtServicePort);
            this.plRight.Controls.Add(this.label2);
            this.plRight.Controls.Add(this.txtIP);
            this.plRight.Controls.Add(this.label1);
            this.plRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plRight.Location = new System.Drawing.Point(315, 3);
            this.plRight.Name = "plRight";
            this.plRight.Size = new System.Drawing.Size(501, 511);
            this.plRight.TabIndex = 1;
            // 
            // txtAlterID
            // 
            this.txtAlterID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAlterID.Location = new System.Drawing.Point(121, 184);
            this.txtAlterID.Name = "txtAlterID";
            this.txtAlterID.Size = new System.Drawing.Size(311, 26);
            this.txtAlterID.TabIndex = 41;
            this.txtAlterID.Tag = "alterId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(53, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "alterId";
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLevel.Location = new System.Drawing.Point(121, 146);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(311, 26);
            this.txtLevel.TabIndex = 37;
            this.txtLevel.Tag = "level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(65, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "level";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtID.Location = new System.Drawing.Point(121, 108);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(311, 26);
            this.txtID.TabIndex = 35;
            this.txtID.Tag = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(83, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "id";
            // 
            // txtServicePort
            // 
            this.txtServicePort.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtServicePort.Location = new System.Drawing.Point(121, 70);
            this.txtServicePort.Name = "txtServicePort";
            this.txtServicePort.Size = new System.Drawing.Size(311, 26);
            this.txtServicePort.TabIndex = 33;
            this.txtServicePort.Tag = "remote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "远程端口";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(121, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(311, 26);
            this.txtIP.TabIndex = 31;
            this.txtIP.Tag = "address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "IP";
            // 
            // notifyIconV2ray
            // 
            this.notifyIconV2ray.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIconV2ray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconV2ray.Icon")));
            this.notifyIconV2ray.Text = "v2ray";
            this.notifyIconV2ray.Visible = true;
            this.notifyIconV2ray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconV2ray_MouseClick);
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重载ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStripIcon.Name = "contextMenuStripV2ray";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(101, 48);
            // 
            // 重载ToolStripMenuItem
            // 
            this.重载ToolStripMenuItem.Name = "重载ToolStripMenuItem";
            this.重载ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.重载ToolStripMenuItem.Text = "重载";
            this.重载ToolStripMenuItem.Click += new System.EventHandler(this.V2ray_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(40, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "加密方式";
            // 
            // cbxSecurity
            // 
            this.cbxSecurity.FormattingEnabled = true;
            this.cbxSecurity.Items.AddRange(new object[] {
            "aes-128-cfb",
            "aes-128-gcm",
            "chacha20-poly1305",
            "none"});
            this.cbxSecurity.Location = new System.Drawing.Point(121, 226);
            this.cbxSecurity.Name = "cbxSecurity";
            this.cbxSecurity.Size = new System.Drawing.Size(141, 28);
            this.cbxSecurity.TabIndex = 49;
            this.cbxSecurity.Tag = "security";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(68, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "协议";
            // 
            // cbxNetwork
            // 
            this.cbxNetwork.FormattingEnabled = true;
            this.cbxNetwork.Items.AddRange(new object[] {
            "TCP",
            "mKCP",
            "WebSocket "});
            this.cbxNetwork.Location = new System.Drawing.Point(121, 266);
            this.cbxNetwork.Name = "cbxNetwork";
            this.cbxNetwork.Size = new System.Drawing.Size(141, 28);
            this.cbxNetwork.TabIndex = 49;
            this.cbxNetwork.Tag = "security";
            // 
            // V2Ray_ZERO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V2Ray_ZERO";
            this.Text = "V2Ray ZERO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.V2ray_Shown);
            this.SizeChanged += new System.EventHandler(this.V2ray_SizeChanged);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStripTextBox.ResumeLayout(false);
            this.plLeft.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.plRight.ResumeLayout(false);
            this.plRight.PerformLayout();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxTaskbar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ListBox lsbService;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel plRight;
        private System.Windows.Forms.TextBox txtAlterID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServicePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIconV2ray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem 重载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxSecurity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxNetwork;
        private System.Windows.Forms.Label label10;
    }
}

