using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BackupAndRestoreDb
    {
        //数据库备份和恢复操作类
        IDAL.IBackupAndRestoreDb dal = DALFactory.DataAccessFactory.CreateBackupAndRestoreDb();
        public void BackDb(string backupPath)
        {
            dal.BackDb(backupPath);
        }
        public void RestoreDb(string restorePath)
        {
            dal.RestoreDb(restorePath );
        }
    }
}
