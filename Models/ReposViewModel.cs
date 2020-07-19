using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace gitsearch_aspnetapp.Models
{
    public class ReposViewModel
    {
        public JArray Repos { get; set; }
        public string User { get; set; }
        public string Avatar { get; set; }
        public string Error { get; set; }
        public string StatusCode { get; set; }
        public static async Task<ReposViewModel> GetRepos(string user, string avatar)
        {
            try
            {
                Uri Url = new Uri($"https://api.github.com/users/{user.ToLower().Replace(" ", "")}/repos?per_page=300");
                string Json = JsonConvert.SerializeObject(new object());
                StringContent Data = new StringContent(Json, Encoding.UTF8, "application/json");
                HttpClient Client = new HttpClient();
                Client.DefaultRequestHeaders.Add("User-Agent", "Git-Searching-App");
                HttpResponseMessage Res = await Client.GetAsync(Url.AbsoluteUri);
                string content = Res.Content.ReadAsStringAsync().Result;
                JArray ReposInfo = JArray.Parse(content);
                try { return new ReposViewModel(ReposInfo) {User = user, Avatar = avatar}; }
                catch { return new ReposViewModel(JObject.Parse(content)["message"].ToString(), ((int) Res.StatusCode).ToString()) {User = user, Avatar = avatar}; }
            }
            catch
            {
                return new ReposViewModel("Not found", "404");
            }
        }
        public ReposViewModel(JArray Repos)
        {
            this.Repos = Repos;
        }
        public ReposViewModel(string Error, string StatusCode)
        {
            this.Error = Error;
            this.StatusCode =  StatusCode;
        }
    }
}