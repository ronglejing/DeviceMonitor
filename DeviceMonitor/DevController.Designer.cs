namespace DeviceMonitor
{
    partial class DevController
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_DevType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DevType
            // 
            this.label_DevType.AutoSize = true;
            this.label_DevType.Location = new System.Drawing.Point(1, 11);
            this.label_DevType.Name = "label_DevType";
            this.label_DevType.Size = new System.Drawing.Size(55, 15);
            this.label_DevType.TabIndex = 0;
            this.label_DevType.Text = "分拣墙";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_DevType);
            this.panel1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 40);
            this.panel1.TabIndex = 1;
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(84, 34);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(103, 15);
            this.label_ip.TabIndex = 3;
            this.label_ip.Text = "192.168.15.1";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(193, 34);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(47, 15);
            this.label_port.TabIndex = 4;
            this.label_port.Text = "50000";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_number.Location = new System.Drawing.Point(84, 9);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(52, 15);
            this.label_number.TabIndex = 5;
            this.label_number.Text = "20001";
            // 
            // DevController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.panel1);
            this.Name = "DevController";
            this.Size = new System.Drawing.Size(255, 60);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_DevType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_number;
    }
}
