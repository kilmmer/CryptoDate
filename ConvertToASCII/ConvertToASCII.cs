using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToASCII
{
    public class ConvertToASCII
    {
	    public string ConversorAscii(string str)
	    {
		    for (int i = 0; i < str.Length; i++)
			{
				var letra = Convert.ToChar(str[i]);
				var cod = Convert.ToInt32(letra);

				return cod.ToString();
			}
		    return null;
	    }
    }
}
