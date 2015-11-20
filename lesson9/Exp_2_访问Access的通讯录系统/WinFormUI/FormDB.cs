using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class FormDB : Form
    {
        //完成对数据库的备份和恢复任务
        string backupPath = "";  //备份路径
        string restorePath = ""; //恢复路径
        BLL.BackupAndRestoreDb bll = new BLL.BackupAndRestoreDb(); 

        public FormDB()
        {
            InitializeComponent();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (backupPath == "")
            {
                MessageBox.Show("请先选择数据库备份路径","提示");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;

                bll.BackDb(backupPath);  //调用BLL类的备份方法

                MessageBox.Show("数据库备份成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }

        }

        private void btnRestor_Click(object sender, EventArgs e)
        {
            if (restorePath  == "")
            {
                MessageBox.Show("请先选择数据库恢复路径", "提示");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;

                bll.RestoreDb(restorePath);  //调用BLL类的恢复方法

                MessageBox.Show("数据库恢复成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btnBackupBath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 1;  
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Bak Files(*.bak)|*.bak"; //设置过滤字段
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = saveFileDialog1.FileName.ToString();
                txtBackup.ReadOnly = true;
            }
            backupPath = txtBackup.Text.Trim();
        }

        private void btnRestorPath_Click(object sender, EventArgs e)
        {
               
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Bak Files(*.bak)|*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {  
                txtRestore.Text = openFileDialog1.FileName.ToString();
                txtRestore.ReadOnly = true;
            }
            restorePath = txtRestore.Text.Trim();
        }
    }
}
