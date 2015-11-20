namespace WinFormUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.联系人管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系人列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分组管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分组列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库备份与恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.tstbnContactList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGroupList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolstrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "联系你我他，沟通无极限";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.联系人管理ToolStripMenuItem,
            this.分组管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 联系人管理ToolStripMenuItem
            // 
            this.联系人管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.联系人列表ToolStripMenuItem,
            this.增加联系人ToolStripMenuItem});
            this.联系人管理ToolStripMenuItem.Name = "联系人管理ToolStripMenuItem";
            this.联系人管理ToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.联系人管理ToolStripMenuItem.Text = "联系人管理";
            // 
            // 联系人列表ToolStripMenuItem
            // 
            this.联系人列表ToolStripMenuItem.Name = "联系人列表ToolStripMenuItem";
            this.联系人列表ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.联系人列表ToolStripMenuItem.Text = "联系人列表";
            this.联系人列表ToolStripMenuItem.Click += new System.EventHandler(this.联系人列表ToolStripMenuItem_Click);
            // 
            // 增加联系人ToolStripMenuItem
            // 
            this.增加联系人ToolStripMenuItem.Name = "增加联系人ToolStripMenuItem";
            this.增加联系人ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.增加联系人ToolStripMenuItem.Text = "增加联系人";
            this.增加联系人ToolStripMenuItem.Click += new System.EventHandler(this.增加联系人ToolStripMenuItem_Click);
            // 
            // 分组管理ToolStripMenuItem
            // 
            this.分组管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分组列表ToolStripMenuItem,
            this.增加分组ToolStripMenuItem});
            this.分组管理ToolStripMenuItem.Name = "分组管理ToolStripMenuItem";
            this.分组管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.分组管理ToolStripMenuItem.Text = "分组管理";
            // 
            // 分组列表ToolStripMenuItem
            // 
            this.分组列表ToolStripMenuItem.Name = "分组列表ToolStripMenuItem";
            this.分组列表ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.分组列表ToolStripMenuItem.Text = "分组列表";
            this.分组列表ToolStripMenuItem.Click += new System.EventHandler(this.分组列表ToolStripMenuItem_Click);
            // 
            // 增加分组ToolStripMenuItem
            // 
            this.增加分组ToolStripMenuItem.Name = "增加分组ToolStripMenuItem";
            this.增加分组ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.增加分组ToolStripMenuItem.Text = "增加分组";
            this.增加分组ToolStripMenuItem.Click += new System.EventHandler(this.增加分组ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.数据库备份与恢复ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 数据库备份与恢复ToolStripMenuItem
            // 
            this.数据库备份与恢复ToolStripMenuItem.Name = "数据库备份与恢复ToolStripMenuItem";
            this.数据库备份与恢复ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.数据库备份与恢复ToolStripMenuItem.Text = "数据库备份与恢复";
            this.数据库备份与恢复ToolStripMenuItem.Click += new System.EventHandler(this.数据库备份与恢复ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolstrip
            // 
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbnContactList,
            this.tsbtnGroupList,
            this.tsbtnPwd,
            this.toolStripButton2});
            this.toolstrip.Location = new System.Drawing.Point(0, 24);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(617, 25);
            this.toolstrip.TabIndex = 2;
            this.toolstrip.Text = "toolStrip1";
            // 
            // tstbnContactList
            // 
            this.tstbnContactList.Image = ((System.Drawing.Image)(resources.GetObject("tstbnContactList.Image")));
            this.tstbnContactList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbnContactList.Name = "tstbnContactList";
            this.tstbnContactList.Size = new System.Drawing.Size(85, 22);
            this.tstbnContactList.Text = "联系人列表";
            this.tstbnContactList.Click += new System.EventHandler(this.联系人列表ToolStripMenuItem_Click);
            // 
            // tsbtnGroupList
            // 
            this.tsbtnGroupList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGroupList.Image")));
            this.tsbtnGroupList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGroupList.Name = "tsbtnGroupList";
            this.tsbtnGroupList.Size = new System.Drawing.Size(73, 22);
            this.tsbtnGroupList.Text = "分组列表";
            this.tsbtnGroupList.Click += new System.EventHandler(this.分组列表ToolStripMenuItem_Click);
            // 
            // tsbtnPwd
            // 
            this.tsbtnPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPwd.Image")));
            this.tsbtnPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPwd.Name = "tsbtnPwd";
            this.tsbtnPwd.Size = new System.Drawing.Size(73, 22);
            this.tsbtnPwd.Text = "修改密码";
            this.tsbtnPwd.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUserName,
            this.tsslblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblUserName
            // 
            this.tsslblUserName.Name = "tsslblUserName";
            this.tsslblUserName.Size = new System.Drawing.Size(131, 17);
            this.tsslblUserName.Text = "toolStripStatusLabel1";
            // 
            // tsslblDate
            // 
            this.tsslblDate.Name = "tsslblDate";
            this.tsslblDate.Size = new System.Drawing.Size(131, 17);
            this.tsslblDate.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 352);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "我的通讯录";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 联系人管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系人列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加联系人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分组管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分组列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库备份与恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton tstbnContactList;
        private System.Windows.Forms.ToolStripButton tsbtnGroupList;
        private System.Windows.Forms.ToolStripButton tsbtnPwd;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDate;
    }
}