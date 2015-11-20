using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IContact
    {
        int GetContactCount(int groupId);
        DataTable GetList(string strWhere);
        bool Add(Model.Contact model);
        bool Delete(int Id);
        bool Update(Model.Contact model);
        Model.Contact GetModel(int Id);
        int GetContactCountByGroupId(int groupId);
    }
}
