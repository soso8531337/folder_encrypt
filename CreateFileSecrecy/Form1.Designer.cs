namespace CreateFileSecrecy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Path = new System.Windows.Forms.Button();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_UnEncrypt = new System.Windows.Forms.Button();
            this.textBox_UnEncPath = new System.Windows.Forms.TextBox();
            this.button_UnEncPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PassWord1 = new System.Windows.Forms.TextBox();
            this.textBox_PassWord2 = new System.Windows.Forms.TextBox();
            this.panel_Single = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.decpypt_status = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.labelLock2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.current_file = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelLock = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel_Single.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(37, 112);
            this.textBox_Path.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(362, 25);
            this.textBox_Path.TabIndex = 0;
            // 
            // button_Path
            // 
            this.button_Path.Location = new System.Drawing.Point(422, 112);
            this.button_Path.Margin = new System.Windows.Forms.Padding(4);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(89, 24);
            this.button_Path.TabIndex = 1;
            this.button_Path.Text = "浏览目录";
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(422, 210);
            this.button_Encrypt.Margin = new System.Windows.Forms.Padding(4);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(89, 24);
            this.button_Encrypt.TabIndex = 2;
            this.button_Encrypt.Text = "开始加密";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // button_UnEncrypt
            // 
            this.button_UnEncrypt.Location = new System.Drawing.Point(422, 170);
            this.button_UnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.button_UnEncrypt.Name = "button_UnEncrypt";
            this.button_UnEncrypt.Size = new System.Drawing.Size(89, 24);
            this.button_UnEncrypt.TabIndex = 3;
            this.button_UnEncrypt.Text = "开始解密";
            this.button_UnEncrypt.UseVisualStyleBackColor = true;
            this.button_UnEncrypt.Click += new System.EventHandler(this.button_UnEncrypt_Click);
            // 
            // textBox_UnEncPath
            // 
            this.textBox_UnEncPath.Location = new System.Drawing.Point(37, 60);
            this.textBox_UnEncPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_UnEncPath.Name = "textBox_UnEncPath";
            this.textBox_UnEncPath.ReadOnly = true;
            this.textBox_UnEncPath.Size = new System.Drawing.Size(361, 25);
            this.textBox_UnEncPath.TabIndex = 4;
            // 
            // button_UnEncPath
            // 
            this.button_UnEncPath.Location = new System.Drawing.Point(424, 60);
            this.button_UnEncPath.Margin = new System.Windows.Forms.Padding(4);
            this.button_UnEncPath.Name = "button_UnEncPath";
            this.button_UnEncPath.Size = new System.Drawing.Size(89, 24);
            this.button_UnEncPath.TabIndex = 5;
            this.button_UnEncPath.Text = "浏览文件";
            this.button_UnEncPath.UseVisualStyleBackColor = true;
            this.button_UnEncPath.Click += new System.EventHandler(this.button_UnEncPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "选择需要解密的文件：";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(33, 82);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 16);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "选择需要加密的文件夹:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "加密密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "解密密码:";
            // 
            // textBox_PassWord1
            // 
            this.textBox_PassWord1.Location = new System.Drawing.Point(137, 153);
            this.textBox_PassWord1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PassWord1.Name = "textBox_PassWord1";
            this.textBox_PassWord1.PasswordChar = '*';
            this.textBox_PassWord1.Size = new System.Drawing.Size(223, 25);
            this.textBox_PassWord1.TabIndex = 7;
            // 
            // textBox_PassWord2
            // 
            this.textBox_PassWord2.Location = new System.Drawing.Point(137, 112);
            this.textBox_PassWord2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PassWord2.MaxLength = 64;
            this.textBox_PassWord2.Name = "textBox_PassWord2";
            this.textBox_PassWord2.PasswordChar = '*';
            this.textBox_PassWord2.Size = new System.Drawing.Size(223, 25);
            this.textBox_PassWord2.TabIndex = 7;
            // 
            // panel_Single
            // 
            this.panel_Single.Controls.Add(this.groupBox2);
            this.panel_Single.Controls.Add(this.groupBox1);
            this.panel_Single.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Single.Location = new System.Drawing.Point(0, 0);
            this.panel_Single.Name = "panel_Single";
            this.panel_Single.Size = new System.Drawing.Size(532, 503);
            this.panel_Single.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.decpypt_status);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.labelLock2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_UnEncPath);
            this.groupBox2.Controls.Add(this.button_UnEncPath);
            this.groupBox2.Controls.Add(this.button_UnEncrypt);
            this.groupBox2.Controls.Add(this.textBox_PassWord2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(4, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 212);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解密";
            // 
            // decpypt_status
            // 
            this.decpypt_status.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decpypt_status.Location = new System.Drawing.Point(39, 159);
            this.decpypt_status.Name = "decpypt_status";
            this.decpypt_status.Size = new System.Drawing.Size(359, 12);
            this.decpypt_status.TabIndex = 14;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(37, 179);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(362, 15);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 11;
            // 
            // labelLock2
            // 
            this.labelLock2.ImageIndex = 0;
            this.labelLock2.ImageList = this.imageList1;
            this.labelLock2.Location = new System.Drawing.Point(366, 112);
            this.labelLock2.Name = "labelLock2";
            this.labelLock2.Size = new System.Drawing.Size(32, 25);
            this.labelLock2.TabIndex = 10;
            this.labelLock2.Click += new System.EventHandler(this.labelLock2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "B.ico");
            this.imageList1.Images.SetKeyName(1, "A.ico");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.current_file);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.labelLock);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Path);
            this.groupBox1.Controls.Add(this.button_Encrypt);
            this.groupBox1.Controls.Add(this.textBox_PassWord1);
            this.groupBox1.Controls.Add(this.button_Path);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 252);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加密";
            // 
            // current_file
            // 
            this.current_file.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.current_file.Location = new System.Drawing.Point(39, 196);
            this.current_file.Name = "current_file";
            this.current_file.Size = new System.Drawing.Size(358, 14);
            this.current_file.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 15);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            // 
            // labelLock
            // 
            this.labelLock.ImageIndex = 0;
            this.labelLock.ImageList = this.imageList1;
            this.labelLock.Location = new System.Drawing.Point(369, 153);
            this.labelLock.Name = "labelLock";
            this.labelLock.Size = new System.Drawing.Size(32, 25);
            this.labelLock.TabIndex = 10;
            this.labelLock.Click += new System.EventHandler(this.labelLock_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "文件";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "文件夹";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.panel_Single);
            this.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件加密工具V1.0";
            this.panel_Single.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_UnEncrypt;
        private System.Windows.Forms.TextBox textBox_UnEncPath;
        private System.Windows.Forms.Button button_UnEncPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PassWord1;
        private System.Windows.Forms.TextBox textBox_PassWord2;
        private System.Windows.Forms.Panel panel_Single;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelLock2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelLock;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label current_file;
        private System.Windows.Forms.Label decpypt_status;
    }
}

