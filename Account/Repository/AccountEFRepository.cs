using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Account.Repository
{
    public class AccountEFRepository
    {
        //撈資料
        public List<Repository.AccountBook> account()
        {
            using (var dbcontext = new SkillTreeHomeworkEntities())
            {
                return dbcontext.AccountBook.ToList();
            }
        }
    }
}