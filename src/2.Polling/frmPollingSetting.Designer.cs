namespace Polling
{
    partial class frmPollingSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPollingSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_quit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.txt_pollinginterval = new System.Windows.Forms.TextBox();
            this.txt_pollingrecordcount = new System.Windows.Forms.TextBox();
            this.txt_retrycount = new System.Windows.Forms.TextBox();
            this.txt_retryinterval = new System.Windows.Forms.TextBox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.cbb_column = new System.Windows.Forms.ComboBox();
            this.txt_initvalue = new System.Windows.Forms.TextBox();
            this.cbb_conn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_view = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "轮询时长：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "轮询记录数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "重试次数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "重试时长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "约束列类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "约束列名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "初始值：";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 415);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(370, 27);
            this.toolStrip1.TabIndex = 7;
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
            // txt_pollinginterval
            // 
            this.txt_pollinginterval.Location = new System.Drawing.Point(158, 115);
            this.txt_pollinginterval.Name = "txt_pollinginterval";
            this.txt_pollinginterval.Size = new System.Drawing.Size(167, 30);
            this.txt_pollinginterval.TabIndex = 8;
            // 
            // txt_pollingrecordcount
            // 
            this.txt_pollingrecordcount.Location = new System.Drawing.Point(158, 154);
            this.txt_pollingrecordcount.Name = "txt_pollingrecordcount";
            this.txt_pollingrecordcount.Size = new System.Drawing.Size(167, 30);
            this.txt_pollingrecordcount.TabIndex = 9;
            // 
            // txt_retrycount
            // 
            this.txt_retrycount.Location = new System.Drawing.Point(158, 194);
            this.txt_retrycount.Name = "txt_retrycount";
            this.txt_retrycount.Size = new System.Drawing.Size(167, 30);
            this.txt_retrycount.TabIndex = 10;
            // 
            // txt_retryinterval
            // 
            this.txt_retryinterval.Location = new System.Drawing.Point(158, 234);
            this.txt_retryinterval.Name = "txt_retryinterval";
            this.txt_retryinterval.Size = new System.Drawing.Size(167, 30);
            this.txt_retryinterval.TabIndex = 11;
            // 
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Location = new System.Drawing.Point(158, 275);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(167, 31);
            this.cbb_type.TabIndex = 12;
            // 
            // cbb_column
            // 
            this.cbb_column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_column.FormattingEnabled = true;
            this.cbb_column.Location = new System.Drawing.Point(158, 316);
            this.cbb_column.Name = "cbb_column";
            this.cbb_column.Size = new System.Drawing.Size(167, 31);
            this.cbb_column.TabIndex = 13;
            // 
            // txt_initvalue
            // 
            this.txt_initvalue.Location = new System.Drawing.Point(158, 357);
            this.txt_initvalue.Name = "txt_initvalue";
            this.txt_initvalue.Size = new System.Drawing.Size(167, 30);
            this.txt_initvalue.TabIndex = 14;
            // 
            // cbb_conn
            // 
            this.cbb_conn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_conn.FormattingEnabled = true;
            this.cbb_conn.Location = new System.Drawing.Point(158, 31);
            this.cbb_conn.Name = "cbb_conn";
            this.cbb_conn.Size = new System.Drawing.Size(167, 31);
            this.cbb_conn.TabIndex = 16;
            this.cbb_conn.SelectedIndexChanged += new System.EventHandler(this.cbb_conn_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "数据库连接：";
            // 
            // cbb_view
            // 
            this.cbb_view.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_view.FormattingEnabled = true;
            this.cbb_view.Location = new System.Drawing.Point(158, 74);
            this.cbb_view.Name = "cbb_view";
            this.cbb_view.Size = new System.Drawing.Size(167, 31);
            this.cbb_view.TabIndex = 18;
            this.cbb_view.SelectedIndexChanged += new System.EventHandler(this.cbb_view_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "扁平化视图：";
            // 
            // frmPollingSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 442);
            this.Controls.Add(this.cbb_view);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbb_conn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_initvalue);
            this.Controls.Add(this.cbb_column);
            this.Controls.Add(this.cbb_type);
            this.Controls.Add(this.txt_retryinterval);
            this.Controls.Add(this.txt_retrycount);
            this.Controls.Add(this.txt_pollingrecordcount);
            this.Controls.Add(this.txt_pollinginterval);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPollingSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "轮询设置";
            this.Load += new System.EventHandler(this.frmPollingSetting_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txt_pollinginterval;
        private System.Windows.Forms.TextBox txt_pollingrecordcount;
        private System.Windows.Forms.TextBox txt_retrycount;
        private System.Windows.Forms.TextBox txt_retryinterval;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.ComboBox cbb_column;
        private System.Windows.Forms.TextBox txt_initvalue;
        private System.Windows.Forms.ToolStripButton tsb_quit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ComboBox cbb_conn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_view;
        private System.Windows.Forms.Label label9;
    }
}