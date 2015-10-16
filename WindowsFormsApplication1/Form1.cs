using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        #region 
        public int index;
        public string msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Txt_FileUrl.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Btn_BackOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                Txt_BackUrl.Text = folderBrowserDialog2.SelectedPath;
            }
        }
        #endregion       
        Thread thread;
        Thread copyThread;
        Thread isOkThread;
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_FileUrl.Text))
            {
                MessageBox.Show("请选择文件路径!");
                Btn_Open.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Txt_BackUrl.Text))
            {
                MessageBox.Show("请选择备份路径!");
                Btn_BackOpen.Focus();
                return;
            }
            try
            {
                Btn_Suspend.Enabled = true;
                Btn_Back.Enabled = false;
                thread = new Thread(new ThreadStart(Back));
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void Back()
        {
            Lit_Msg.Text = msg;
            index = Txt_FileUrl.Text.LastIndexOf("\\");
            DirectoryInfo dir = new DirectoryInfo(Txt_FileUrl.Text);
            CopyFile(dir);
            // 2、启动一个线程来拷贝获取的所有文件
            copyThread = new Thread(new ThreadStart(ThreadCopyFile));
            copyThread.IsBackground = true;
            copyThread.Start();
            Recursion(dir);
            //判断是否结束
            isOkThread = new Thread(new ThreadStart(IsOk));
            isOkThread.IsBackground = true;
            isOkThread.Start();
        }
        
        #region 调用winRAR
        /// <summary>
        /// 调用winRAR
        /// </summary>
        /// <param name="name">压缩包名</param>
        /// <param name="dirPath">打包源路径</param>
        /// <param name="zipPath">压缩包存放位置</param>
        /// <param name="smarkPath">备注文件 主意路径存在的空格</param>>
        /// <returns></returns>
        public string winRAR(string dirPath, string zipPath, string smarkPath, string defaultValue)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");
                string WinRarPath = key.GetValue("").ToString();
                if (!WinRarPath.Equals(""))
                {
                    System.Diagnostics.Process Process1 = new System.Diagnostics.Process();
                    Process1.StartInfo.FileName = "Winrar.exe";
                    Process1.StartInfo.CreateNoWindow = false;
                    string SFXPath = key.GetValue("Path").ToString() + "\\Wtwsm.SFX";
                    if (File.Exists(SFXPath))
                    {
                        Process1.StartInfo.Arguments = "a -r -ep1 " + zipPath + " -s -ibck -z" + smarkPath + " -sfx " + SFXPath + " " + dirPath.Trim();
                    }
                    else
                    {
                        Process1.StartInfo.Arguments = "a -r -ep1 " + "\"" + zipPath + "\"" + " -s -ibck -z" + smarkPath + " -sfx " + "\"" + dirPath.Trim() + "\"";
                    }
                    Process1.Start();
                    if (Process1.HasExited)
                    {
                        int iExitCode = Process1.ExitCode;
                        if (iExitCode == 0)
                        {
                            return defaultValue;
                        }
                        else
                            return "Error";
                    }
                    else
                        return "Error";
                }
                else
                    return "Error";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        #region 递归文件夹
        protected void Recursion(DirectoryInfo dir) {
            try
            {
                DirectoryInfo[] subDirs = dir.GetDirectories();
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    CopyFile(dirInfo);
                    Recursion(dirInfo);
                }
            }
            catch (Exception)
            {
                
            }
        }
        #endregion
        #region 创建文件夹
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        protected string CreateDirectory(string path)
        {
            string backUrl = Txt_BackUrl.Text + path;
            try
            {
                Directory.CreateDirectory(backUrl);
            }
            catch (Exception)
            {
                return backUrl;
            }
            return backUrl;
        }
        #endregion
        #region 复制文件
        int okBack = 0;
        List<string> backList = new List<string>();  //存储备份路径
        List<FileInfo[]> fileList = new List<FileInfo[]>();  //存储已获取文件夹的路径
        int listIndex = 0;
        int noCount = 0;
        public void ThreadCopyFile()
        {
            while (true)
            {
                if (fileList.Count > 0 && backList.Count > 0)
                {
                    if (fileList.Count > listIndex && fileList[listIndex] != null && backList.Count > listIndex && backList[listIndex] != null)
                    {
                        foreach (FileInfo file in fileList[listIndex])
                        {
                            string exeName = Path.GetExtension(file.FullName);
                            if (Txt_ExeName.Text.ToLower().IndexOf(exeName.ToLower()) == -1)
                            {
                                try
                                {
                                    string fileUrl = file.FullName;
                                    string backUrl = backList[listIndex];
                                    string backFileUrl = backUrl + "\\" + file.Name;
                                    if (File.Exists(backFileUrl))
                                        File.Delete(backFileUrl);
                                    File.Copy(fileUrl, backFileUrl);
                                    okBack++;
                                    if (fileUrl.Length > 55)
                                        Lit_Msg.Text = fileUrl.Substring(0, 55) + "\n" + fileUrl.Substring(55);
                                    else
                                        Lit_Msg.Text = fileUrl;
                                    Lit_OkBack.Text = okBack.ToString();
                                }
                                catch (Exception)
                                {
                                    if (Lit_Fail.Text != "0" || Lit_No.Text != "")
                                        Lit_Fail.Text = (Convert.ToInt32(Lit_Fail.Text) + 1).ToString();
                                }
                            }
                            else
                            {
                                if (Lit_No.Text != "0" || Lit_No.Text != "")
                                {
                                    noCount++;
                                    Lit_No.Text = noCount.ToString();
                                }
                            }
                        }
                        if(thread.ThreadState != System.Threading.ThreadState.Stopped)
                            thread.Suspend();
                        backList.Remove(backList[listIndex]);
                        fileList.Remove(fileList[listIndex]);
                        if (thread.ThreadState != System.Threading.ThreadState.Stopped)
                            thread.Resume();
                        listIndex = 0;
                    }
                    else
                    {
                        if (fileList.Count > listIndex && backList.Count > listIndex)
                            listIndex++;
                        else
                            listIndex = 0;
                    }
                }
            }
        }
        /// <summary>
        /// 复制文件
        /// 分两个步骤
        /// 1、获取所有文件
        /// 2、启动一个线程来拷贝获取的所有文件(见back方法)
        /// //51aspx.com下载
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <param name="backUrl"></param>
        protected void CopyFile(DirectoryInfo dirInfo)
        {
            try
            {
                lock (thread)
                {
                    //获取所有文件
                    string directoryName = dirInfo.Name;
                    string path = dirInfo.FullName.Substring(index);
                    string backUrl = CreateDirectory(path);
                    backList.Add(backUrl);
                    if (dirInfo.FullName.Length > 55)
                        Lit_Msg2.Text = dirInfo.FullName.Substring(0, 55) + "\n" + dirInfo.FullName.Substring(55);
                    else
                        Lit_Msg2.Text = dirInfo.FullName;
                    FileInfo[] files = dirInfo.GetFiles();
                    fileList.Add(files);
                    if (Lit_FileNumber.Text != "0" || Lit_FileNumber.Text != "")
                        Lit_FileNumber.Text = (Convert.ToInt32(Lit_FileNumber.Text) + files.Length).ToString();
                    Lit_FolderNumber.Text = (Convert.ToInt32(Lit_FolderNumber.Text) + 1).ToString();
                }
            }
            catch (Exception)
            {
                
            }           
        }        
        #endregion        
        #region 判断是否结束
        public void IsOk()
        {
            while (true)
            {
                try
                {
                    string no = Lit_No.Text;
                    string okBack = Lit_OkBack.Text;
                    string fail = Lit_Fail.Text;
                    int all = Convert.ToInt32(no) + Convert.ToInt32(okBack) + Convert.ToInt32(fail);
                    if (all >= Convert.ToInt32(Lit_FileNumber.Text))
                    {
                        string fileName = Txt_FileUrl.Text.Substring(Txt_FileUrl.Text.LastIndexOf("\\"));
                        string zipPath = Txt_BackUrl.Text + fileName;
                        winRAR(zipPath, zipPath, "", "Remark2");
                        Btn_Back.Enabled = true;
                        thread.Abort();
                        copyThread.Abort();
                        MessageBox.Show("OK..运行压缩程序!");  
                        isOkThread.Abort();                                              
                        return;
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }
        #endregion
        #region 加载
        private void Form1_Load(object sender, EventArgs e)
        {            
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.ThreadState != System.Threading.ThreadState.Stopped)
                thread.Suspend();
            if (copyThread != null && copyThread.ThreadState != System.Threading.ThreadState.Stopped)
                copyThread.Suspend();
            if (isOkThread != null && isOkThread.ThreadState != System.Threading.ThreadState.Stopped)
                isOkThread.Suspend();
        }

        private void Btn_Suspend_Click(object sender, EventArgs e)
        {
            if (Btn_Suspend.Text == "暂停")
            {
                try
                {
                    if (thread != null)
                        thread.Suspend();
                    if (copyThread != null)
                        copyThread.Suspend();
                    if (isOkThread != null)
                        isOkThread.Suspend();
                }
                catch (Exception)
                {
                }
                finally
                {
                    Btn_Suspend.Text = "恢复";
                }
            }
            else
            {
                try
                {
                    if (thread != null)
                        thread.Resume();
                    if (copyThread != null)
                        copyThread.Resume();
                    if (isOkThread != null)
                        isOkThread.Resume();
                }
                catch (Exception)
                {
                }
                finally
                {
                    Btn_Suspend.Text = "暂停";
                }
            }
        }


    }
}
