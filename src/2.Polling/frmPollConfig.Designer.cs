namespace Polling
{
    partial class frmPollConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPollConfig));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_task = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.tsb_addtask = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_deletetask = new System.Windows.Forms.ToolStripButton();
            this.dgv_setting = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsb_addpoll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_updatepoll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_deletepoll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_quit = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_setting)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1807, 485);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_task);
            this.panel1.Controls.Add(this.toolStrip4);
            this.panel1.Controls.Add(this.dgv_setting);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1807, 485);
            this.panel1.TabIndex = 3;
            // 
            // dgv_task
            // 
            this.dgv_task.AllowUserToAddRows = false;
            this.dgv_task.AllowUserToDeleteRows = false;
            this.dgv_task.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_task.BackgroundColor = System.Drawing.Color.White;
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_task.Location = new System.Drawing.Point(0, 350);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.ReadOnly = true;
            this.dgv_task.RowTemplate.Height = 27;
            this.dgv_task.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_task.Size = new System.Drawing.Size(1807, 135);
            this.dgv_task.TabIndex = 6;
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.tsb_addtask,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsb_deletetask});
            this.toolStrip4.Location = new System.Drawing.Point(0, 323);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(1807, 27);
            this.toolStrip4.TabIndex = 5;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(69, 24);
            this.toolStripLabel8.Text = "任务设置";
            // 
            // tsb_addtask
            // 
            this.tsb_addtask.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addtask.Image")));
            this.tsb_addtask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addtask.Name = "tsb_addtask";
            this.tsb_addtask.Size = new System.Drawing.Size(93, 24);
            this.tsb_addtask.Text = "新增任务";
            this.tsb_addtask.Click += new System.EventHandler(this.tsb_addtask_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_deletetask
            // 
            this.tsb_deletetask.Image = ((System.Drawing.Image)(resources.GetObject("tsb_deletetask.Image")));
            this.tsb_deletetask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_deletetask.Name = "tsb_deletetask";
            this.tsb_deletetask.Size = new System.Drawing.Size(93, 24);
            this.tsb_deletetask.Text = "删除任务";
            this.tsb_deletetask.Click += new System.EventHandler(this.tsb_deletetask_Click);
            // 
            // dgv_setting
            // 
            this.dgv_setting.AllowUserToAddRows = false;
            this.dgv_setting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_setting.BackgroundColor = System.Drawing.Color.White;
            this.dgv_setting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_setting.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_setting.Location = new System.Drawing.Point(0, 27);
            this.dgv_setting.Name = "dgv_setting";
            this.dgv_setting.ReadOnly = true;
            this.dgv_setting.RowTemplate.Height = 27;
            this.dgv_setting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_setting.Size = new System.Drawing.Size(1807, 296);
            this.dgv_setting.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsb_addpoll,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.tsb_updatepoll,
            this.toolStripSeparator8,
            this.toolStripSeparator7,
            this.tsb_deletepoll,
            this.toolStripSeparator9,
            this.toolStripSeparator10,
            this.tsb_quit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1807, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 24);
            this.toolStripLabel1.Text = "轮询设置";
            // 
            // tsb_addpoll
            // 
            this.tsb_addpoll.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addpoll.Image")));
            this.tsb_addpoll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addpoll.Name = "tsb_addpoll";
            this.tsb_addpoll.Size = new System.Drawing.Size(123, 24);
            this.tsb_addpoll.Text = "新增轮询设置";
            this.tsb_addpoll.Click += new System.EventHandler(this.tsb_addpoll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_updatepoll
            // 
            this.tsb_updatepoll.Image = ((System.Drawing.Image)(resources.GetObject("tsb_updatepoll.Image")));
            this.tsb_updatepoll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_updatepoll.Name = "tsb_updatepoll";
            this.tsb_updatepoll.Size = new System.Drawing.Size(123, 24);
            this.tsb_updatepoll.Text = "修改轮询设置";
            this.tsb_updatepoll.Click += new System.EventHandler(this.tsb_updatepoll_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_deletepoll
            // 
            this.tsb_deletepoll.Image = ((System.Drawing.Image)(resources.GetObject("tsb_deletepoll.Image")));
            this.tsb_deletepoll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_deletepoll.Name = "tsb_deletepoll";
            this.tsb_deletepoll.Size = new System.Drawing.Size(123, 24);
            this.tsb_deletepoll.Text = "删除轮询设置";
            this.tsb_deletepoll.ToolTipText = "删除轮询设置";
            this.tsb_deletepoll.Click += new System.EventHandler(this.tsb_deletepoll_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_quit
            // 
            this.tsb_quit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_quit.Image")));
            this.tsb_quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_quit.Name = "tsb_quit";
            this.tsb_quit.Size = new System.Drawing.Size(63, 24);
            this.tsb_quit.Text = "关闭";
            this.tsb_quit.Click += new System.EventHandler(this.tsb_quit_Click);
            // 
            // frmPollConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 485);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPollConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "轮询设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPollConfig_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_setting)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_task;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.DataGridView dgv_setting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_addpoll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsb_updatepoll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsb_deletepoll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsb_quit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsb_addtask;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_deletetask;
    }
}

