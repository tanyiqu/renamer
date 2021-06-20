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
            System.Windows.Forms.CheckBox checkNoExt;
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.listOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            checkNoExt = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(321, 531);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "执行";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(240, 531);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "还原";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择文件夹：";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDir.Location = new System.Drawing.Point(321, 7);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDir.TabIndex = 6;
            this.btnSelectDir.Text = "选择";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listOrigin,
            this.listNew});
            this.dataGridView.Location = new System.Drawing.Point(7, 236);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(389, 287);
            this.dataGridView.TabIndex = 7;
            // 
            // listOrigin
            // 
            this.listOrigin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.listOrigin.HeaderText = "原目录";
            this.listOrigin.Name = "listOrigin";
            this.listOrigin.ReadOnly = true;
            // 
            // listNew
            // 
            this.listNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.listNew.HeaderText = "重命名后目录";
            this.listNew.Name = "listNew";
            this.listNew.ReadOnly = true;
            // 
            // checkNoExt
            // 
            checkNoExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            checkNoExt.AutoSize = true;
            checkNoExt.Checked = true;
            checkNoExt.CheckState = System.Windows.Forms.CheckState.Checked;
            checkNoExt.Location = new System.Drawing.Point(304, 214);
            checkNoExt.Name = "checkNoExt";
            checkNoExt.Size = new System.Drawing.Size(96, 16);
            checkNoExt.TabIndex = 8;
            checkNoExt.Text = "不显示扩展名";
            checkNoExt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 564);
            this.Controls.Add(checkNoExt);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Renamer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn listOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn listNew;
    }
}

