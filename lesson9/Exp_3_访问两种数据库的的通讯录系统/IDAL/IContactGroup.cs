﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data ;

namespace IDAL
{
   public interface  IContactGroup
    {
       DataTable GetList(string strWhere);
       bool Add(Model .ContactGroup model);
       Model.ContactGroup GetModel(int Id);
       Model.ContactGroup GetModel(string groupName);
       bool Delete(int Id);
       bool Update(Model .ContactGroup  model);
    }
}
