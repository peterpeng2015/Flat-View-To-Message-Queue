namespace Acquisition
{
    partial class frmDBLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBLink));
            this.dbConnect = new CommomUserControls.DBConnect();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txt_dbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tsb_testConnect = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cbb_dbClass = new System.Windows.Forms.ComboBox();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbConnect
            // 
            this.dbConnect.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dbConnect.Location = new System.Drawing.Point(4, 103);
            this.dbConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbConnect.Name = "dbConnect";
            this.dbConnect.Size = new System.Drawing.Size(422, 256);
            this.dbConnect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库类型：";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_close,
            this.toolStripSeparator6,
            this.toolStripSeparator3,
            this.tsb_save,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.tsb_testConnect});
            this.toolStrip2.Location = new System.Drawing.Point(0, 376);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(430, 30);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txt_dbName
            // 
            this.txt_dbName.Location = new System.Drawing.Point(175, 26);
            this.txt_dbName.Name = "txt_dbName";
            this.txt_dbName.Size = new System.Drawing.Size(200, 30);
            this.txt_dbName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "数据库名称：";
            // 
            // tsb_testConnect
            // 
            this.tsb_testConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_testConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsb_testConnect.Image")));
            this.tsb_testConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_testConnect.Name = "tsb_testConnect";
            this.tsb_testConnect.Size = new System.Drawing.Size(82, 27);
            this.tsb_testConnect.Text = "测试连接";
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(48, 27);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(48, 27);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 30);
            // 
            // cbb_dbClass
            // 
            this.cbb_dbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dbClass.FormattingEnabled = true;
            this.cbb_dbClass.Location = new System.Drawing.Point(175, 72);
            this.cbb_dbClass.Name = "cbb_dbClass";
            this.cbb_dbClass.Size = new System.Drawing.Size(200, 31);
            this.cbb_dbClass.TabIndex = 7;
            // 
            // frmDBLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 406);
            this.Controls.Add(this.cbb_dbClass);
            this.Controls.Add(this.txt_dbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbConnect);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDBLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接";
            this.Load += new System.EventHandler(this.frmDBLink_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommomUserControls.DBConnect dbConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TextBox txt_dbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsb_testConnect;
        private System.Windows.Forms.ComboBox cbb_dbClass;
    }
}

