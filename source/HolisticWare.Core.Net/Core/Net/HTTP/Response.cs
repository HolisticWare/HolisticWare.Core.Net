using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Net
{
	public partial class Response
	{
		public string Body 
		{
			get; 
			set;
		}

		public System.Net.CookieCollection Cookies
		{
			get;
			set;
		}

		public System.Net.Http.HttpResponseMessage HttpResponseMessage
		{
			get;
			set;
		}

	}
}
