using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_de_Vyver_Steve_TussentijdsExamen_Opdracht2
{
	class CustomException: Exception
	{
		public CustomException() : base() { }
		public CustomException(string message) : base(message) { }
	}
}
