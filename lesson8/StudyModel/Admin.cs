using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyModel
{
    public class Admin
    {
        private string adminUser = string.Empty;
        private string adminPwd = string.Empty;

        public string AdminUser
        {
            get { return this.adminUser; }
            set { this.adminUser = value; }
        }
        public string AdminPwd
        {
            get { return this.adminUser; }
            set { this.adminPwd = value; }
        }
    }
}
