using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace gitsearch_aspnetapp.Models
{
	public class GetUserViewModel
	{
		public JObject User { get; set; }
		public string Error { get; set; }
		public string StatusCode { get; set; }
		public static async Task<dynamic> GetUserInfo(string user)
		{
			try
			{
				Uri URL = new Uri($"https://api.github.com/users/{user.ToLower().Replace(" ", "")}");
				string Json = JsonConvert.SerializeObject(new object());
				StringContent Data = new StringContent(Json, Encoding.UTF8, "application/json");
				HttpClient Client = new HttpClient();
				Client.DefaultRequestHeaders.Add("User-Agent", "Git-Searching-App");
				HttpResponseMessage Res = await Client.GetAsync(URL.AbsoluteUri);
				string ResContent = Res.Content.ReadAsStringAsync().Result;
				JObject UserInfo = JObject.Parse(ResContent);
				try { string test = UserInfo["login"].ToString(); return new GetUserViewModel(UserInfo); }
				catch { return new GetUserViewModel(UserInfo["message"].ToString(), ((int) Res.StatusCode).ToString()); }
			}
			catch
			{
				return new GetUserViewModel("Not found", StatusCodes.Status404NotFound.ToString());
			}
		}	
		private GetUserViewModel(JObject User)
		{
			this.User = User;
		}
		private GetUserViewModel(string Error, string StatusCode)
		{
			this.Error = Error;
			this.StatusCode = StatusCode;
		}
	}
}