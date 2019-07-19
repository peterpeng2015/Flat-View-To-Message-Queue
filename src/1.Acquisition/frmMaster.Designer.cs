namespace Acquisition
{
    partial class frmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_addLink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_modifyLink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_deleteLink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.dgv_dbLink = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dbLink)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_addLink,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsb_modifyLink,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.tsb_deleteLink,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_addLink
            // 
            this.tsb_addLink.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addLink.Image")));
            this.tsb_addLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addLink.Name = "tsb_addLink";
            this.tsb_addLink.Size = new System.Drawing.Size(102, 27);
            this.tsb_addLink.Text = "新增连接";
            this.tsb_addLink.Click += new System.EventHandler(this.tsb_addLink_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tsb_modifyLink
            // 
            this.tsb_modifyLink.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modifyLink.Image")));
            this.tsb_modifyLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modifyLink.Name = "tsb_modifyLink";
            this.tsb_modifyLink.Size = new System.Drawing.Size(102, 27);
            this.tsb_modifyLink.Text = "修改连接";
            this.tsb_modifyLink.Click += new System.EventHandler(this.tsb_modifyLink_Click);
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
            // tsb_deleteLink
            // 
            this.tsb_deleteLink.Image = ((System.Drawing.Image)(resources.GetObject("tsb_deleteLink.Image")));
            this.tsb_deleteLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_deleteLink.Name = "tsb_deleteLink";
            this.tsb_deleteLink.Size = new System.Drawing.Size(102, 27);
            this.tsb_deleteLink.Text = "删除连接";
            this.tsb_deleteLink.Click += new System.EventHandler(this.tsb_deleteLink_Click);
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
            // tsb_close
            // 
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(68, 27);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // dgv_dbLink
            // 
            this.dgv_dbLink.AllowUserToAddRows = false;
            this.dgv_dbLink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_dbLink.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dbLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dbLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dbLink.Location = new System.Drawing.Point(0, 30);
            this.dgv_dbLink.Name = "dgv_dbLink";
            this.dgv_dbLink.RowTemplate.Height = 27;
            this.dgv_dbLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dbLink.Size = new System.Drawing.Size(839, 358);
            this.dgv_dbLink.TabIndex = 1;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 388);
            this.Controls.Add(this.dgv_dbLink);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaster_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dbLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgv_dbLink;
        private System.Windows.Forms.ToolStripButton tsb_addLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_modifyLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_deleteLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsb_close;
    }
}