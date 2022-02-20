using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacaManager
{
    public class Common
    {
        public string checkMaID(int ma)
        {
            string tmp = "";
            if (ma <= 999999)
            {

                if (ma <= 99999)
                {
                    tmp = "0";

                    if (ma <= 9999)
                    {
                        tmp = "00";

                        if (ma <= 999)
                        {
                            tmp = "000";
                            if (ma <= 99)
                            {
                                tmp = "0000";
                                if (ma <= 9)
                                {
                                    tmp = "00000";
                                }
                            }
                        }
                    }
                }
            }
            return tmp + ma.ToString();
        }
    }

}
