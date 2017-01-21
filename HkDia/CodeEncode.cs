using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HkDia
{
    class CodeEncode
    {
        public static string encodeHeader(string encodedecodeme, bool whatido)
        {
            string str = "";
            int symbol;

            #region encode
            if (whatido)
            {
                for (int i = 0; i < encodedecodeme.Length; i++)
                {
                    symbol = (int)encodedecodeme[i] + i + 1;
                    str += symbol.ToString() + '•';
                }

                return str;
            }
            #endregion
            #region decode
            else
            {
                string strboof = "";
                int cesar = 1;

                for (int i = 0; i < encodedecodeme.Length; i++)
                {
                    if (encodedecodeme[i] != '•')
                    {
                        strboof += encodedecodeme[i];
                    }
                    else
                    {
                        str += Convert.ToChar(Convert.ToInt32(strboof) - cesar);
                        cesar++;
                        strboof = "";
                    }
                }

                return str;
            }
            #endregion
        }
    }
}
