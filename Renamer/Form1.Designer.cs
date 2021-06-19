namespace Renamer
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
            this.originList = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.newList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // originList
            // 
            this.originList.Dock = System.Windows.Forms.DockStyle.Left;
            this.originList.FormattingEnabled = true;
            this.originList.ItemHeight = 12;
            this.originList.Items.AddRange(new object[] {
            "1",
            "2",
            "31",
            "4",
            "5",
            "51",
            "51",
            "561",
            "51",
            "516",
            "15",
            "15",
            "1",
            "2",
            "31",
            "4",
            "5",
            "51",
            "51",
            "561",
            "51",
            "516",
            "15",
            "15",
            "1",
            "2",
            "31",
            "4",
            "5",
            "51",
            "51",
            "561",
            "51",
            "516",
            "15",
            "15"});
            this.originList.Location = new System.Drawing.Point(0, 0);
            this.originList.Name = "originList";
            this.originList.Size = new System.Drawing.Size(188, 284);
            this.originList.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(321, 529);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "执行";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(240, 529);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "还原";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // newList
            // 
            this.newList.Dock = System.Windows.Forms.DockStyle.Right;
            this.newList.FormattingEnabled = true;
            this.newList.ItemHeight = 12;
            this.newList.Items.AddRange(new object[] {
            "1",
            "2",
            "31",
            "4",
            "5",
            "51",
            "51",
            "561",
            "51",
            "516",
            "15",
            "15",
            "1",
            "2",
            "31",
            "4",
            "5",
            "51",
            "51",
            "561",
            "51",
            "516",
            "15",
            "15",
            "1",
            "2",
            "31",
            "4",
            "5",
            "51",
            "51",
            "561",
            "51",
            "516",
            "15",
            "15"});
            this.newList.Location = new System.Drawing.Point(196, 0);
            this.newList.Name = "newList";
            this.newList.Size = new System.Drawing.Size(188, 284);
            this.newList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.originList);
            this.panel1.Controls.Add(this.newList);
            this.panel1.Location = new System.Drawing.Point(12, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 284);
            this.panel1.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(85, 8);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(230, 21);
            this.txtPath.TabIndex = 3;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择文件夹：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "重命名后目录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "原目录";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(321, 7);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDir.TabIndex = 6;
            this.btnSelectDir.Text = "选择";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 564);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Renamer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox originList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ListBox newList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectDir;
    }
}

