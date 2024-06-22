namespace AutoMP4toWAV
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ffmpegPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFFmpegBtn = new System.Windows.Forms.Button();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.logText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 42F);
            this.button1.Location = new System.Drawing.Point(142, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "じっこう！！！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ffmpegPath
            // 
            this.ffmpegPath.Location = new System.Drawing.Point(209, 37);
            this.ffmpegPath.Name = "ffmpegPath";
            this.ffmpegPath.Size = new System.Drawing.Size(343, 19);
            this.ffmpegPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ffmpeg.exeのパス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "監視フォルダーのパス";
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(209, 87);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(343, 19);
            this.folderPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(11, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "wav形式、PCM16bit、44.1khzに、\r\nffmpegによって変換されます";
            // 
            // selectFFmpegBtn
            // 
            this.selectFFmpegBtn.Location = new System.Drawing.Point(558, 37);
            this.selectFFmpegBtn.Name = "selectFFmpegBtn";
            this.selectFFmpegBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFFmpegBtn.TabIndex = 6;
            this.selectFFmpegBtn.Text = "ファイル選択";
            this.selectFFmpegBtn.UseVisualStyleBackColor = true;
            this.selectFFmpegBtn.Click += new System.EventHandler(this.selectFFmpegBtn_Click);
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(558, 87);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFolderBtn.TabIndex = 7;
            this.selectFolderBtn.Text = "フォルダ選択";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // logText
            // 
            this.logText.AutoSize = true;
            this.logText.Location = new System.Drawing.Point(14, 377);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(161, 12);
            this.logText.TabIndex = 8;
            this.logText.Text = "ようこそ。ここにログが表示されます";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 398);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.selectFFmpegBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ffmpegPath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "AutoMP4toWAV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ffmpegPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectFFmpegBtn;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label logText;
    }
}

