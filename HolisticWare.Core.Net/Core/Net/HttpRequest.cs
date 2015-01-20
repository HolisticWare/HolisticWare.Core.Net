using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Core.Net
{
	public partial class HttpRequest
	{
		public static async Task<Core.Net.Response> Post(string uri, IEnumerable<KeyValuePair<string, string>> kvp)
		{
			Core.Net.Response response = null;
			string result_content = null;

			using (HttpClientHandler handler = new HttpClientHandler())
			using (HttpClient client = new HttpClient(handler))
			{
				handler.UseDefaultCredentials = true;
				handler.AllowAutoRedirect = true;
				handler.UseCookies = true;

				handler.CookieContainer = new CookieContainer();

				client.BaseAddress = new Uri(uri);
				FormUrlEncodedContent content = new FormUrlEncodedContent(kvp);
				HttpResponseMessage response_message = await client.PostAsync(uri, content);
				result_content = await response_message.Content.ReadAsStringAsync();

				CookieCollection cookies = handler.CookieContainer.GetCookies(client.BaseAddress);


				response = new Core.Net.Response()
				{
					Body = result_content
				,	Cookies = cookies
				,	HttpResponseMessage = response_message
				};
				
				// Uri that the cookies are associated with
				//foreach(Cookie c in cookies)
				//{
				//	Debug.WriteLine("Name		= ", c.Name);
				//	Debug.WriteLine("Value		= ", c.Value);
				//	Debug.WriteLine("Domain		= ", c.Domain);
				//	Debug.WriteLine("Expires	= ", c.Expires);
				//	Debug.WriteLine("Expired	= ", c.Expired);
				//	Debug.WriteLine("Comment	= ", c.Comment);
				//	Debug.WriteLine("CommentUri	= ", c.CommentUri);
				//
				//	if (c.Name == "csrftoken")
				//	{
				//		Authentication.XCRFToken = c.Value;
				//	}
			}

			return response;
		}
	}
}
