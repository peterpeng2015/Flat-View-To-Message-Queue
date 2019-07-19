namespace InstallServices
{
    partial class frmMain
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
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_uninstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(78, 28);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(115, 39);
            this.btn_install.TabIndex = 0;
            this.btn_install.Text = "安装服务";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(78, 86);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(115, 39);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "启动服务";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(78, 146);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(115, 39);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "暂停服务";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_uninstall
            // 
            this.btn_uninstall.Location = new System.Drawing.Point(78, 204);
            this.btn_uninstall.Name = "btn_uninstall";
            this.btn_uninstall.Size = new System.Drawing.Size(115, 39);
            this.btn_uninstall.TabIndex = 3;
            this.btn_uninstall.Text = "卸载服务";
            this.btn_uninstall.UseVisualStyleBackColor = true;
            this.btn_uninstall.Click += new System.EventHandler(this.btn_uninstall_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 290);
            this.Controls.Add(this.btn_uninstall);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_install);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务控制器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_uninstall;
    }
}