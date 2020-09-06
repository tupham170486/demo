using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
		public float Div(int a,int b)
		{
			float ret = a / b;
			
			return ret;
		}

		public string GetDateTime()
		{
			return System.DateTime.Now.ToString();
		}
    }
}
