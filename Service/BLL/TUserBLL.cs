﻿using DAL;
using Model;

namespace BLL
{
    public class TUserBLL : BLLBase<TUserDAL, TUserModel>
    {
        public TUserBLL()
            : base()
        {
        }

        public TUserBLL(string connName)
            : base(connName)
        {
        }

        public TUserBLL(string connName, string areaNo)
            : base(connName, areaNo)
        {
        }

        public object GetGridData()
        {
            return this.CreateDAL().GetGridData();
        }
    }
}
