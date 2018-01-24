using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;



namespace BLL
{
    public class BLL_Published
    {
        private static readonly IDAL_Published PublishedDal = new SQLDAL.SQL_Published();





        //查看地域信息
        public IList<Published> getPublishedInf(string lx)
        {
            return PublishedDal.getPublishedInf(lx);
        }






    }
}