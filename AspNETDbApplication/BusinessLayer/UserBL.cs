using DataLayer;
using DataTransferModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBL
    {
        DBHelper dbHelper;
        public UserBL()
        {
            dbHelper = new DBHelper();
        }

        public bool GetUserInformation(UserCredentails user)
        {
            var result = dbHelper.GetUserInformation(user);

            if (result.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
