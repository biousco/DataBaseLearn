using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using AccessDAL;


namespace BLL
{
    public class BackupAndRestoreDb
    {
        //数据库备份和恢复操作类
        //AccessDAL.BackupAndRestoreDb dal = new AccessDAL.BackupAndRestoreDb();
        //多态：子类对象用父类型表示
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
