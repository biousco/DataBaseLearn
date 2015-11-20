using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IDAL;

namespace AccessDAL
{
    public class BackupAndRestoreDb : IBackupAndRestoreDb
    {
        //备份数据库
        public void BackDb(string backupPath)
        {
            if (File.Exists(backupPath)) //判断文件是否存在
            {
                File.Delete(backupPath); //如果存在，则删除文件
            }
            File.Copy(System.Configuration.ConfigurationManager.AppSettings["DbPath"], backupPath, true);
        }

        //恢复数据库
        public void RestoreDb(string restorePath)
        {
            File.Copy(restorePath, System.Configuration.ConfigurationManager.AppSettings["DbPath"], true);
        }
    }
}
