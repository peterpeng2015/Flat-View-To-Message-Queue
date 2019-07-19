namespace Polling
{
    partial class frmTaskSettring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskSettring));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_polling = new System.Windows.Forms.ComboBox();
            this.cbb_tasktype = new System.Windows.Forms.ComboBox();
            this.cbb_taskresult = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_quit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "轮询设置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "任务类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "任务结果：";
            // 
            // cbb_polling
            // 
            this.cbb_polling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_polling.FormattingEnabled = true;
            this.cbb_polling.Location = new System.Drawing.Point(135, 47);
            this.cbb_polling.Name = "cbb_polling";
            this.cbb_polling.Size = new System.Drawing.Size(167, 31);
            this.cbb_polling.TabIndex = 13;
            // 
            // cbb_tasktype
            // 
            this.cbb_tasktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tasktype.FormattingEnabled = true;
            this.cbb_tasktype.Location = new System.Drawing.Point(135, 98);
            this.cbb_tasktype.Name = "cbb_tasktype";
            this.cbb_tasktype.Size = new System.Drawing.Size(167, 31);
            this.cbb_tasktype.TabIndex = 14;
            // 
            // cbb_taskresult
            // 
            this.cbb_taskresult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_taskresult.FormattingEnabled = true;
            this.cbb_taskresult.Location = new System.Drawing.Point(135, 148);
            this.cbb_taskresult.Name = "cbb_taskresult";
            this.cbb_taskresult.Size = new System.Drawing.Size(167, 31);
            this.cbb_taskresult.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_quit,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsb_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 268);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(338, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_quit
            // 
            this.tsb_quit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_quit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_quit.Image")));
            this.tsb_quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_quit.Name = "tsb_quit";
            this.tsb_quit.Size = new System.Drawing.Size(43, 24);
            this.tsb_quit.Text = "退出";
            this.tsb_quit.Click += new System.EventHandler(this.tsb_quit_Click);
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
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(43, 24);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // frmTaskSettring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 295);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbb_taskresult);
            this.Controls.Add(this.cbb_tasktype);
            this.Controls.Add(this.cbb_polling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaskSettring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务设置";
            this.Load += new System.EventHandler(this.frmTaskSettring_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_polling;
        private System.Windows.Forms.ComboBox cbb_tasktype;
        private System.Windows.Forms.ComboBox cbb_taskresult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_quit;
    }
}