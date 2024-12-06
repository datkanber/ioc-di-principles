using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyIOC.console
{
    internal class DALFactory
    {
        public static IDAL GetDal()
        {
            return new DAL();
        }
    }
}