namespace RandHeroes
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rand = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.翰墨流轩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rand
            // 
            this.rand.Location = new System.Drawing.Point(40, 148);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(100, 23);
            this.rand.TabIndex = 0;
            this.rand.Text = "随机";
            this.rand.UseVisualStyleBackColor = true;
            this.rand.Click += new System.EventHandler(this.rand_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(40, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(176, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Info
            // 
            this.Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.翰墨流轩ToolStripMenuItem});
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(44, 21);
            this.Info.Text = "关于";
            // 
            // 翰墨流轩ToolStripMenuItem
            // 
            this.翰墨流轩ToolStripMenuItem.Name = "翰墨流轩ToolStripMenuItem";
            this.翰墨流轩ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.翰墨流轩ToolStripMenuItem.Text = "作者：翰墨流轩";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 211);
            this.Controls.Add(this.name);
            this.Controls.Add(this.rand);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "随机英雄";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rand;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem 翰墨流轩ToolStripMenuItem;
    }
}

