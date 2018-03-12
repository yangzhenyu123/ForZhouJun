using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyFolder
{
    public partial class Tool : Form
    {
        public Tool()
        {
            InitializeComponent();
        }

        private void btn_ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            string dirpath = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dirpath = ofd.SelectedPath;
            }

            if (string.IsNullOrEmpty(dirpath))
            {
                MessageBox.Show("请选择路径", "提示", MessageBoxButtons.OK);
                return;
            }
            txt_path.Text = dirpath;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string logFileName = "GetNullFolder" + DateTime.Now.ToString("yyyyMMddhhmmss");
            List<string> pathList = GetNullFolderPath();
            foreach (var item in pathList)
            {
                Application.DoEvents();
                TxtHandle.OutTXTByString(item, logFileName);
            }
            MessageBox.Show("老哥，搞完了，清单：" + "D:\\ZhouJunLog\\" + logFileName + ".txt");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string logFileName = "DeleteNullFolder" + DateTime.Now.ToString("yyyyMMddhhmmss");
            List<string> pathList = GetNullFolderPath();
            foreach (var item in pathList)
            {
                Application.DoEvents();
                if (Directory.Exists(item))
                {
                    Directory.Delete(item);
                    TxtHandle.OutTXTByString(item, logFileName);
                }
            }
            MessageBox.Show("老哥，搞完了,一共删了 " + pathList.Count + " 个空文件夹，清单：" + "D:\\ZhouJunLog\\" + logFileName + ".txt");
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            string logFileName = "DeleteNullFolder" + DateTime.Now.ToString("yyyyMMddhhmmss");
            int totalDeleteCount = 0;
            List<string> pathList = GetNullFolderPath();
            while (pathList.Count > 0)
            {
                Application.DoEvents();       
                foreach (var item in pathList)
                {
                    Application.DoEvents();
                    if (Directory.Exists(item))
                    {
                        totalDeleteCount++;
                        Directory.Delete(item);
                        TxtHandle.OutTXTByString(item, logFileName);
                    }
                }
                pathList = GetNullFolderPath();
            }

            MessageBox.Show("老哥，搞完了,一共删了 " + totalDeleteCount + " 个空文件夹，清单：" + "D:\\ZhouJunLog\\" + logFileName + ".txt");
        }



        private List<string> GetNullFolderPath()
        {
            List<string> pathList = new List<string>();

            string rootPath = txt_path.Text;
            if (!Directory.Exists(rootPath))
            {
                MessageBox.Show("老哥，能先选择一下根文件夹么");
                return pathList;
            }
            LoopGetNullFolderPath(ref  pathList, rootPath);
            return pathList;
        }


        private void LoopGetNullFolderPath(ref  List<string> pathList, string currentFolderPath)
        {
            Application.DoEvents();

            var folderPaths = Directory.GetDirectories(currentFolderPath);
            if (folderPaths != null && folderPaths.Length > 0) //有子文件夹
            {
                Application.DoEvents();
                foreach (var item in folderPaths)
                {
                    LoopGetNullFolderPath(ref pathList, item);
                }
                return;
            }

            var filePaths = Directory.GetFiles(currentFolderPath);
            if (filePaths != null && filePaths.Length > 0) //有文件
            {
                return;
            }

            Application.DoEvents();
            pathList.Add(currentFolderPath); //没文件，也没有文件夹

        }



    }
}
