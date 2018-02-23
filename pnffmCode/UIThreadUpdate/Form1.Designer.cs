namespace UIThreadUpdate
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUploadMark = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.uploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblUploadMark
            // 
            this.lblUploadMark.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadMark.Location = new System.Drawing.Point(12, 16);
            this.lblUploadMark.Name = "lblUploadMark";
            this.lblUploadMark.Size = new System.Drawing.Size(201, 17);
            this.lblUploadMark.TabIndex = 10;
            this.lblUploadMark.Text = "Uploading Order 5060 of 10500";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 8);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(232, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(146, 76);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(77, 26);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // uploadProgressBar
            // 
            this.uploadProgressBar.Location = new System.Drawing.Point(12, 33);
            this.uploadProgressBar.Maximum = 10500;
            this.uploadProgressBar.Name = "uploadProgressBar";
            this.uploadProgressBar.Size = new System.Drawing.Size(288, 26);
            this.uploadProgressBar.TabIndex = 6;
            this.uploadProgressBar.Value = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 116);
            this.Controls.Add(this.lblUploadMark);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.uploadProgressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bulk Order Upload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUploadMark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ProgressBar uploadProgressBar;
    }
}

