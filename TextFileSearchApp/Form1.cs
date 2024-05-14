using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextFileSearchApp
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<string> fileNameList;
        List<string> openFileNameList;
        string fileName, folderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_MouseLeave(object sender, EventArgs e)
        {
            textEdit1.Focus();
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            if (textEdit1.Text.Length < 50)
            {
                lblAlarm.Text = "Eksik barcode kodu !";
                lblAlarm.Visible = true;
            }
            else if (textEdit1.Text.Length == 50 && fileNameCalculate(textEdit1.Text))
            {
                foreach (var openFileName in openFileNameList)
                {
                    Process.Start("notepad.exe", openFileName);
                } 
                lblAlarm.Visible = false;
            }
            else
            {
                lblAlarm.Text = "Dosya Bulunumadı !";
                lblAlarm.Visible = true;
            }
        }

        private void openFile()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
           
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {          
                fileNameList = new List<string>();
                folderPath=folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (var file in files)
                {
                    fileName = Path.GetFileName(file);
                    fileNameList.Add(fileName);
                }
                if (Path.GetExtension(fileName)==".txt")
                {
                    textEdit1.Enabled = true;
                    textEdit1.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Text uzantılı dosya bunumadı !");
                    textEdit1.Enabled = false;
                }
            }
        }


        private bool fileNameCalculate(String textBarcode)
        {
            bool flag=false;
            textBarcode = textBarcode.Substring(16, 20);
            openFileNameList = new List<string>();
            foreach (var file in fileNameList)
            {
                if (textBarcode==file.Substring(0,20))
                {
                    fileName = folderPath +"/"+ file;
                    openFileNameList.Add(fileName);
                    flag = true;
                }
            }
            return flag;
        }
      
    }
}
