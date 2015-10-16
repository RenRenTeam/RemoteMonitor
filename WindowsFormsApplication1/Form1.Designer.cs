namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_FileUrl = new System.Windows.Forms.TextBox();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_BackUrl = new System.Windows.Forms.TextBox();
            this.Btn_BackOpen = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Txt_ExeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lit_Msg = new System.Windows.Forms.Label();
            this.Lit_FolderNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lit_FolderNumber = new System.Windows.Forms.Label();
            this.Lit_FileNumber = new System.Windows.Forms.Label();
            this.Lit_OkBack = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lit_No = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lit_Fail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lit_Msg2 = new System.Windows.Forms.Label();
            this.Btn_Suspend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径：";
            // 
            // Txt_FileUrl
            // 
            this.Txt_FileUrl.Location = new System.Drawing.Point(83, 15);
            this.Txt_FileUrl.Name = "Txt_FileUrl";
            this.Txt_FileUrl.Size = new System.Drawing.Size(234, 21);
            this.Txt_FileUrl.TabIndex = 0;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(333, 13);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(75, 23);
            this.Btn_Open.TabIndex = 1;
            this.Btn_Open.Text = "打开";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "备份路径：";
            // 
            // Txt_BackUrl
            // 
            this.Txt_BackUrl.Enabled = false;
            this.Txt_BackUrl.Location = new System.Drawing.Point(83, 50);
            this.Txt_BackUrl.Name = "Txt_BackUrl";
            this.Txt_BackUrl.Size = new System.Drawing.Size(234, 21);
            this.Txt_BackUrl.TabIndex = 0;
            // 
            // Btn_BackOpen
            // 
            this.Btn_BackOpen.Location = new System.Drawing.Point(333, 48);
            this.Btn_BackOpen.Name = "Btn_BackOpen";
            this.Btn_BackOpen.Size = new System.Drawing.Size(75, 23);
            this.Btn_BackOpen.TabIndex = 3;
            this.Btn_BackOpen.Text = "选择";
            this.Btn_BackOpen.UseVisualStyleBackColor = true;
            this.Btn_BackOpen.Click += new System.EventHandler(this.Btn_BackOpen_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(83, 316);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "开始";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Txt_ExeName
            // 
            this.Txt_ExeName.Location = new System.Drawing.Point(14, 99);
            this.Txt_ExeName.Multiline = true;
            this.Txt_ExeName.Name = "Txt_ExeName";
            this.Txt_ExeName.Size = new System.Drawing.Size(394, 51);
            this.Txt_ExeName.TabIndex = 5;
            this.Txt_ExeName.Text = ".html|.mdf|.ldf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "不需要备份文件后缀：";
            // 
            // Lit_Msg
            // 
            this.Lit_Msg.AutoSize = true;
            this.Lit_Msg.Location = new System.Drawing.Point(59, 208);
            this.Lit_Msg.Name = "Lit_Msg";
            this.Lit_Msg.Size = new System.Drawing.Size(47, 12);
            this.Lit_Msg.TabIndex = 6;
            this.Lit_Msg.Text = "Lit_Msg";
            // 
            // Lit_FolderNum
            // 
            this.Lit_FolderNum.AutoSize = true;
            this.Lit_FolderNum.Location = new System.Drawing.Point(29, 252);
            this.Lit_FolderNum.Name = "Lit_FolderNum";
            this.Lit_FolderNum.Size = new System.Drawing.Size(53, 12);
            this.Lit_FolderNum.TabIndex = 8;
            this.Lit_FolderNum.Text = "文件夹：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "文件数量：";
            // 
            // Lit_FolderNumber
            // 
            this.Lit_FolderNumber.AutoSize = true;
            this.Lit_FolderNumber.Location = new System.Drawing.Point(88, 252);
            this.Lit_FolderNumber.Name = "Lit_FolderNumber";
            this.Lit_FolderNumber.Size = new System.Drawing.Size(11, 12);
            this.Lit_FolderNumber.TabIndex = 8;
            this.Lit_FolderNumber.Text = "0";
            // 
            // Lit_FileNumber
            // 
            this.Lit_FileNumber.AutoSize = true;
            this.Lit_FileNumber.Location = new System.Drawing.Point(242, 252);
            this.Lit_FileNumber.Name = "Lit_FileNumber";
            this.Lit_FileNumber.Size = new System.Drawing.Size(11, 12);
            this.Lit_FileNumber.TabIndex = 8;
            this.Lit_FileNumber.Text = "0";
            // 
            // Lit_OkBack
            // 
            this.Lit_OkBack.AutoSize = true;
            this.Lit_OkBack.Location = new System.Drawing.Point(88, 287);
            this.Lit_OkBack.Name = "Lit_OkBack";
            this.Lit_OkBack.Size = new System.Drawing.Size(11, 12);
            this.Lit_OkBack.TabIndex = 8;
            this.Lit_OkBack.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "已拷贝：";
            // 
            // Lit_No
            // 
            this.Lit_No.AutoSize = true;
            this.Lit_No.Location = new System.Drawing.Point(242, 287);
            this.Lit_No.Name = "Lit_No";
            this.Lit_No.Size = new System.Drawing.Size(11, 12);
            this.Lit_No.TabIndex = 8;
            this.Lit_No.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "过    滤：";
            // 
            // Lit_Fail
            // 
            this.Lit_Fail.AutoSize = true;
            this.Lit_Fail.Location = new System.Drawing.Point(372, 287);
            this.Lit_Fail.Name = "Lit_Fail";
            this.Lit_Fail.Size = new System.Drawing.Size(11, 12);
            this.Lit_Fail.TabIndex = 8;
            this.Lit_Fail.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "失  败：";
            // 
            // Lit_Msg2
            // 
            this.Lit_Msg2.AutoSize = true;
            this.Lit_Msg2.Location = new System.Drawing.Point(59, 168);
            this.Lit_Msg2.Name = "Lit_Msg2";
            this.Lit_Msg2.Size = new System.Drawing.Size(47, 12);
            this.Lit_Msg2.TabIndex = 6;
            this.Lit_Msg2.Text = "Lit_Msg";
            // 
            // Btn_Suspend
            // 
            this.Btn_Suspend.Enabled = false;
            this.Btn_Suspend.Location = new System.Drawing.Point(227, 316);
            this.Btn_Suspend.Name = "Btn_Suspend";
            this.Btn_Suspend.Size = new System.Drawing.Size(75, 23);
            this.Btn_Suspend.TabIndex = 9;
            this.Btn_Suspend.Text = "暂停";
            this.Btn_Suspend.UseVisualStyleBackColor = true;
            this.Btn_Suspend.Click += new System.EventHandler(this.Btn_Suspend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "当前：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "加载：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 351);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Suspend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lit_Fail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lit_No);
            this.Controls.Add(this.Lit_OkBack);
            this.Controls.Add(this.Lit_FileNumber);
            this.Controls.Add(this.Lit_FolderNumber);
            this.Controls.Add(this.Lit_FolderNum);
            this.Controls.Add(this.Lit_Msg2);
            this.Controls.Add(this.Lit_Msg);
            this.Controls.Add(this.Txt_ExeName);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_BackOpen);
            this.Controls.Add(this.Txt_BackUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.Txt_FileUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDC Back Beta 2.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FileUrl;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_BackUrl;
        private System.Windows.Forms.Button Btn_BackOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.TextBox Txt_ExeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lit_Msg;
        private System.Windows.Forms.Label Lit_FolderNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lit_FolderNumber;
        private System.Windows.Forms.Label Lit_FileNumber;
        private System.Windows.Forms.Label Lit_OkBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lit_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lit_Fail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lit_Msg2;
        private System.Windows.Forms.Button Btn_Suspend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
    }
}

