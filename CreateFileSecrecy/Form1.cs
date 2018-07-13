using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace CreateFileSecrecy
{
    public partial class Form1 : Form
    {
        private int SelectType = 0;
        private bool cancelEncrypt = false;
        private bool cancelDecrypt = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Path_Click(object sender, EventArgs e)
        {
             if (SelectType == 0)
             {
                 System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
                 if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 {
                     textBox_Path.Text = fbd.SelectedPath;
                 }
             }
             else
             {
                 OpenFileDialog f = new OpenFileDialog();
                 f.InitialDirectory = @"C:\";
                 if (f.ShowDialog() == DialogResult.OK)
                 {
                     textBox_Path.Text = f.FileName;
                 }
             }
         }

         private void button_Encrypt_Click(object sender, EventArgs e)
         {
             string Result = "";
             string savePath="";

             if (textBox_Path.Text.Trim().Length == 0) {
                 MessageBox.Show("请选择需要加密的文件!");
                 return;
             }
             if (SelectType == 0 && !Directory.Exists(textBox_Path.Text.Trim()))
             {
                 MessageBox.Show("请确认所选文件夹是否存在:\r\n" + textBox_Path.Text.Trim());
                 return;
             }
             if (SelectType == 1 && !File.Exists(textBox_Path.Text.Trim()))
             {
                 MessageBox.Show("请确认所选文件是否存在:\r\n" + textBox_Path.Text.Trim());
                 return;
             }
             //MessageBox.Show("1:"+button_Encrypt.Text);
             if (button_Encrypt.Text.CompareTo("取消") == 0) 
             {  
                /*取消操作*/
                 cancelEncrypt = true;
                 button_Encrypt.Enabled = false;
                 current_file.Text = "正在取消...";
                 return;
             }
             button_Encrypt.Text = "取消";

             current_file.Text = "准备加密...";
             //禁用选择路径按钮
             button_Path.Enabled = false;
             textBox_PassWord1.Enabled = false;
             cancelEncrypt = false;
             int bRet = encryptFiles(textBox_Path.Text.Trim(), SelectType, ref Result, ref savePath, textBox_PassWord1.Text.Trim());
             if (bRet == 1)
             {
                 MessageBox.Show("加密成功!\r\n路径: " + savePath);
             }
             else if(bRet == 0)
             {
                 MessageBox.Show("加密失败!\r\n" + Result);
             }
             else if (bRet == 3) 
             {
                //取消操作
                 MessageBox.Show("已取消！");
             }
             //禁用选择路径按钮
             button_Path.Enabled = true;
             textBox_PassWord1.Enabled = true;
             button_Encrypt.Enabled = true;
             this.textBox_PassWord1.Text = "";
             this.textBox_Path.Text = "";
             current_file.Text = "";
             progressBar1.Value = 0;
             cancelEncrypt = false;
             button_Encrypt.Text = "开始加密";
         }

         private void button_UnEncrypt_Click(object sender, EventArgs e)
         {
             string Result = "";
             string OpenPath = "";
             this.progressBar2.Value = 0;
             if (!File.Exists(textBox_UnEncPath.Text.Trim()))
             {
                 if (textBox_UnEncPath.Text.Trim().Length == 0)
                 {
                     MessageBox.Show("请选择需要解密的文件！");
                 }
                 else {
                     MessageBox.Show("请确认解密文件是否存在:\r\n" + textBox_UnEncPath.Text.Trim());              
                 }
                 
                 return;
             }
             if (button_UnEncrypt.Text.CompareTo("取消") == 0)
             {
                 /*取消操作*/
                 cancelDecrypt = true;
                 button_UnEncrypt.Enabled = false;
                 decpypt_status.Text = "正在取消...";
                 return;
             }
             button_UnEncrypt.Text = "取消";
             //禁用选择路径按钮
             button_UnEncPath.Enabled = false;
             textBox_PassWord2.Enabled = false;
             cancelDecrypt = false;
             int bRet = decryptFiles(this.textBox_UnEncPath.Text.Trim(), ref Result, ref OpenPath, textBox_PassWord2.Text.Trim());
             if (bRet == 1)
             {
                 MessageBox.Show("解密成功!\r\n路径: " + OpenPath);
             }
             else if(bRet == 0){
                 MessageBox.Show("解密失败!\r\n" + Result);
             }
             else if (bRet == 3) {
                 //取消操作
                 MessageBox.Show("已取消！");
             }
             button_UnEncPath.Enabled = true;
             textBox_PassWord2.Enabled = true;
             cancelDecrypt = false;
             button_UnEncrypt.Text = "开始解密";
             button_UnEncrypt.Enabled = true;
             this.textBox_UnEncPath.Text = "";
             this.textBox_PassWord2.Text = "";
             decpypt_status.Text = "";
             this.progressBar2.Value = 0;
         }

         private void button_UnEncPath_Click(object sender, EventArgs e)
         {
             OpenFileDialog _openFileDialog = new OpenFileDialog();
             _openFileDialog.InitialDirectory = "C:\\";
             _openFileDialog.Filter = "Lock文件|*.Lock";
             DialogResult dlgResult = _openFileDialog.ShowDialog();
             if (dlgResult == DialogResult.OK)
             {
                 this.textBox_UnEncPath.Text = _openFileDialog.FileName;
                 decpypt_status.Text = "";
             }
         }

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
         {
             SelectType = 0;
             labelTitle.Text = "选择需要加密的文件夹:";
             button_Path.Text = "浏览目录";
         }

         private void radioButton2_CheckedChanged(object sender, EventArgs e)
         {
             SelectType = 1;
             labelTitle.Text = "选择需要加密的文件:";
             button_Path.Text = "选择文件";
         }

         private void labelLock_Click(object sender, EventArgs e)
         {
             if (labelLock.ImageIndex == 0)
             {
                 labelLock.ImageIndex = 1;
                 textBox_PassWord1.PasswordChar = '\0';
             }
             else if (labelLock.ImageIndex == 1)
             {
                 labelLock.ImageIndex = 0;
                 textBox_PassWord1.PasswordChar = '*';
             }
         }

         private void labelLock2_Click(object sender, EventArgs e)
         {
             if (labelLock2.ImageIndex == 0)
             {
                 labelLock2.ImageIndex = 1;
                 textBox_PassWord2.PasswordChar = '\0';
             }
             else if (labelLock2.ImageIndex == 1)
             {
                 labelLock2.ImageIndex = 0;
                 textBox_PassWord2.PasswordChar = '*';
             }
         }
         /*encryptOp = 1 encrypt file
          *encryptOp = 0 decrypt file
          */
         private void setLabelStatus(bool encryptOp)
         {
             if (encryptOp == true)
             {

             }
             else { 
             
             }
         }
         private void SaveProgress(object sender, SaveProgressEventArgs e)
         {
             if (cancelEncrypt == true) 
             {
                 e.Cancel = true;
                 return;
             }
             Application.DoEvents();
             if (e.EventType == ZipProgressEventType.Adding_Started)
             {
                 MessageBox.Show("adding started");
             }
             else if (e.EventType == ZipProgressEventType.Adding_AfterAddEntry)
             {
                 MessageBox.Show("Adding_AfterAddEntry:" + e.EntriesTotal.ToString());
             }
             else if (e.EventType == ZipProgressEventType.Adding_Completed)
             {
                 MessageBox.Show("Adding_Completed:" + e.EntriesTotal.ToString());
             }
             else if (e.EventType == ZipProgressEventType.Saving_Started)
             {
                 current_file.Text = "开始加密...";
             }
             else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
             {
                 current_file.Text = "正在加密[%0]: " + e.CurrentEntry.FileName;

                 progressBar1.Maximum = e.EntriesTotal;
                 progressBar1.Value = e.EntriesSaved + 1;
             }
             else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
             {
                 int progress = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                 current_file.Text = "正在加密[" + progress.ToString() + "%]: " + e.CurrentEntry.FileName;
             }
             else if (e.EventType == ZipProgressEventType.Saving_Completed)
             {
                // MessageBox.Show("Done: " + e.ArchiveName);
                 current_file.Text = "加密完成...";
             }
         }

         private int encryptFiles(string sourceDirectory, int zipType, ref string Result, ref string savePath, string passWord = "")
         {
             try
             {
                 //获取指定目录下的所有文件夹路径
                 DirectoryInfo dirInfo = new DirectoryInfo(sourceDirectory);

                 //生成压缩路径
                 Directory.SetCurrentDirectory(Directory.GetParent(sourceDirectory).FullName);
                 string targetFileName = Path.Combine(Directory.GetCurrentDirectory(), dirInfo.Name + ".Lock");

                 if (File.Exists(targetFileName)) {
                     DialogResult dr = MessageBox.Show("加密文件已存在，是否继续？", "加密文件",MessageBoxButtons.YesNo);
                     if (dr == DialogResult.Yes)
                     {
                         File.Delete(targetFileName);
                     }
                     else {
                         return 2;
                     }
                 }

                 using (ZipFile zip = new ZipFile(targetFileName, Encoding.UTF8))
                 {

                     //加密压缩
                     zip.Password = passWord;
                     //支持大文件传输
                     zip.UseZip64WhenSaving = Zip64Option.AsNecessary;
                     if (zipType == 0)
                     {
                         //将要压缩的文件夹添加到zip对象中去(要压缩的文件夹路径和名称)
                         zip.AddDirectory(sourceDirectory);
                     }
                     else
                     {
                         //将要压缩的文件添加到zip对象中去,如果文件不存在抛错FileNotFoundExcept
                         zip.AddFile(sourceDirectory, "");
                     }

                     zip.SaveProgress += SaveProgress;
                     zip.Save();
                 }
                 if (cancelEncrypt == true)
                 {
                     return 3;
                 }
                 if (zipType == 0)
                 {
                     Directory.Delete(sourceDirectory, true);
                 }
                 else
                 {
                     File.Delete(sourceDirectory);
                 }

                 savePath = targetFileName;
             }
             catch (Exception ex)
             {
                 Result = ex.Message.Replace("zip", "").Replace("Zip", "");
                 return 0;
             }
             return 1;
         }

         private void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
         {
             /*
                Extracting_BeforeExtractEntry = 17,
                Extracting_AfterExtractEntry = 18,
                Extracting_ExtractEntryWouldOverwrite = 19,
                Extracting_EntryBytesWritten = 20,
                Extracting_BeforeExtractAll = 21,
                Extracting_AfterExtractAll = 22,

             if (e.EntriesTotal <= 0) return;
             progressBar2.Maximum = e.EntriesTotal;
             progressBar2.Value = e.EntriesExtracted;
             */
             if (cancelDecrypt == true)
             {
                 e.Cancel = true;
                 return;
             }
             Application.DoEvents();
             if (e.EventType == ZipProgressEventType.Adding_Started)
             {
                 MessageBox.Show("adding started");
             }
             else if (e.EventType == ZipProgressEventType.Adding_AfterAddEntry)
             {
                 MessageBox.Show("Adding_AfterAddEntry:" + e.EntriesTotal.ToString());
             }
             else if (e.EventType == ZipProgressEventType.Adding_Completed)
             {
                 MessageBox.Show("Adding_Completed:" + e.EntriesTotal.ToString());
             }
             else if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractAll)
             {
                 decpypt_status.Text = "开始解密...";
             }
             else if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
             {
                 decpypt_status.Text = "正在解密[%0]: " + e.CurrentEntry.FileName;

                 progressBar2.Maximum = e.EntriesTotal;
                 progressBar2.Value = e.EntriesExtracted + 1;
             }
             else if (e.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
             {
                 int progress = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                 decpypt_status.Text = "正在解密[" + progress.ToString() + "%]: " + e.CurrentEntry.FileName;
             }
             else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
             {
                 // MessageBox.Show("Done: " + e.ArchiveName);
                 decpypt_status.Text = "解密完成...";
             }
         }
         private int decryptFiles(string zipFileName, ref string Result, ref string OpenPath, string passWord = "")
         {
             try
             {
                 DirectoryInfo dirInfo = new DirectoryInfo(zipFileName);
                 Directory.SetCurrentDirectory(Directory.GetParent(zipFileName).FullName);
                 string targetFileName = Path.Combine(Directory.GetCurrentDirectory(), dirInfo.Name.Replace(".Lock", ""));

                 int encFileType = 0;
                 if (Directory.Exists(targetFileName))
                 {
                     encFileType = 1;
                 }
                 else if (File.Exists(targetFileName))
                 {
                     encFileType = 2;
                 }
                 if (encFileType != 0)
                 {
                     DialogResult dr = MessageBox.Show("解密文件已存在，是否继续？", "解密文件", MessageBoxButtons.YesNo);
                     if (dr == DialogResult.Yes)
                     {
                         if (encFileType == 2) {
                             File.Delete(targetFileName);                        
                         }else if(encFileType == 1){
                             Directory.Delete(targetFileName, true);
                         }
                     }
                     else
                     {
                         return 2;
                     }
                 }
                 using (ZipFile zip = new ZipFile(zipFileName, Encoding.UTF8))
                 {
                     zip.Password = passWord;
                     //支持大文件传输
                     zip.UseZip64WhenSaving = Zip64Option.AsNecessary;
                     zip.ExtractProgress += zip_ExtractProgress;
                     zip.ExtractAll(targetFileName);
                 }
                 if (cancelDecrypt == true)
                 {
                     //取消操作
                     return 3;
                 }
                 File.Delete(zipFileName);
                 if (File.Exists(targetFileName))
                 {

                 }
                 else if (Directory.Exists(targetFileName))
                 {

                 }
                 else
                 {
                     //表明白空目录被删除,手动创建，主要针对空目录
                     Directory.CreateDirectory(targetFileName);
                 }
                 OpenPath = targetFileName;
             }
             catch (Exception ex)
             {
                 Result = ex.Message.Replace("zip", "").Replace("Zip", "");
                 return 0;
             }

             return 1;
         }
    }

}
