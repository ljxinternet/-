namespace V视频助手
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_DownLoad = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.textBox_SiteUrl = new System.Windows.Forms.TextBox();
            this.Btn_JieXi = new System.Windows.Forms.Button();
            this.TxtBox_Url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_SaveFiePath = new System.Windows.Forms.Button();
            this.Btn_ChiceFile = new System.Windows.Forms.Button();
            this.textBox_DownLoaderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel_JXResult = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_DownLoad);
            this.groupBox1.Controls.Add(this.Btn_Pause);
            this.groupBox1.Controls.Add(this.textBox_SiteUrl);
            this.groupBox1.Controls.Add(this.Btn_JieXi);
            this.groupBox1.Controls.Add(this.TxtBox_Url);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "解析区";
            // 
            // Btn_DownLoad
            // 
            this.Btn_DownLoad.Location = new System.Drawing.Point(489, 45);
            this.Btn_DownLoad.Name = "Btn_DownLoad";
            this.Btn_DownLoad.Size = new System.Drawing.Size(75, 23);
            this.Btn_DownLoad.TabIndex = 5;
            this.Btn_DownLoad.Text = "下载";
            this.Btn_DownLoad.UseVisualStyleBackColor = true;
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Location = new System.Drawing.Point(408, 45);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pause.TabIndex = 4;
            this.Btn_Pause.Text = "粘贴";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            // 
            // textBox_SiteUrl
            // 
            this.textBox_SiteUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SiteUrl.Location = new System.Drawing.Point(8, 45);
            this.textBox_SiteUrl.Multiline = true;
            this.textBox_SiteUrl.Name = "textBox_SiteUrl";
            this.textBox_SiteUrl.ReadOnly = true;
            this.textBox_SiteUrl.Size = new System.Drawing.Size(388, 32);
            this.textBox_SiteUrl.TabIndex = 3;
            this.textBox_SiteUrl.Text = "支持下载腾讯视频、秒拍视频、微博视频、今日头条、阳光宽频网、快手、微信、百度视频、梨视频、西瓜视频等";
            this.textBox_SiteUrl.DoubleClick += new System.EventHandler(this.textBox_SiteUrl_DoubleClick);
            // 
            // Btn_JieXi
            // 
            this.Btn_JieXi.Location = new System.Drawing.Point(489, 15);
            this.Btn_JieXi.Name = "Btn_JieXi";
            this.Btn_JieXi.Size = new System.Drawing.Size(75, 23);
            this.Btn_JieXi.TabIndex = 2;
            this.Btn_JieXi.Text = "解析";
            this.Btn_JieXi.UseVisualStyleBackColor = true;
            // 
            // TxtBox_Url
            // 
            this.TxtBox_Url.Location = new System.Drawing.Point(71, 17);
            this.TxtBox_Url.Name = "TxtBox_Url";
            this.TxtBox_Url.Size = new System.Drawing.Size(412, 21);
            this.TxtBox_Url.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网页链接:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_SaveFiePath);
            this.groupBox2.Controls.Add(this.Btn_ChiceFile);
            this.groupBox2.Controls.Add(this.textBox_DownLoaderPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下载设置";
            // 
            // Btn_SaveFiePath
            // 
            this.Btn_SaveFiePath.Location = new System.Drawing.Point(489, 44);
            this.Btn_SaveFiePath.Name = "Btn_SaveFiePath";
            this.Btn_SaveFiePath.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveFiePath.TabIndex = 3;
            this.Btn_SaveFiePath.Text = "保存路径";
            this.Btn_SaveFiePath.UseVisualStyleBackColor = true;
            // 
            // Btn_ChiceFile
            // 
            this.Btn_ChiceFile.Location = new System.Drawing.Point(489, 15);
            this.Btn_ChiceFile.Name = "Btn_ChiceFile";
            this.Btn_ChiceFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChiceFile.TabIndex = 2;
            this.Btn_ChiceFile.Text = "选择";
            this.Btn_ChiceFile.UseVisualStyleBackColor = true;
            this.Btn_ChiceFile.Click += new System.EventHandler(this.Btn_ChiceFile_Click);
            // 
            // textBox_DownLoaderPath
            // 
            this.textBox_DownLoaderPath.Location = new System.Drawing.Point(71, 17);
            this.textBox_DownLoaderPath.Multiline = true;
            this.textBox_DownLoaderPath.Name = "textBox_DownLoaderPath";
            this.textBox_DownLoaderPath.ReadOnly = true;
            this.textBox_DownLoaderPath.Size = new System.Drawing.Size(412, 50);
            this.textBox_DownLoaderPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "路径:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel_JXResult);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 39);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "解析结果";
            // 
            // linkLabel_JXResult
            // 
            this.linkLabel_JXResult.AutoSize = true;
            this.linkLabel_JXResult.Location = new System.Drawing.Point(9, 17);
            this.linkLabel_JXResult.Name = "linkLabel_JXResult";
            this.linkLabel_JXResult.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_JXResult.TabIndex = 0;
            this.linkLabel_JXResult.TabStop = true;
            this.linkLabel_JXResult.Text = "NULL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 212);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 212);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V视频下载解析 V1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_SiteUrl;
        private System.Windows.Forms.Button Btn_JieXi;
        private System.Windows.Forms.TextBox TxtBox_Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Pause;
        private System.Windows.Forms.LinkLabel linkLabel_JXResult;
        private System.Windows.Forms.Button Btn_DownLoad;
        private System.Windows.Forms.Button Btn_SaveFiePath;
        private System.Windows.Forms.Button Btn_ChiceFile;
        private System.Windows.Forms.TextBox textBox_DownLoaderPath;
        private System.Windows.Forms.Label label2;
    }
}

