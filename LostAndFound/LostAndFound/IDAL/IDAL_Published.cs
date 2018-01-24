using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace IDAL
{
    public interface IDAL_Published
    {
        
        IList<Published> getAreaInf(string lx);




        IList<Published> getPublishedInf(string lx);
    }


}
