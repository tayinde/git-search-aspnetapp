using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace gitsearch_aspnetapp.Models
{
    public class FollowersViewModel
    {
        public JArray Followers { get; set; }
        public string User { get; set; }
        public string Avatar { get; set; }
        public string Error { get; set; }
        public string StatusCode { get; set; }
        public static async Task<FollowersViewModel> GetFollowers(string user, string avatar)
        {
            try
            {
                Uri Url = new Uri($"https://api.github.com/users/{user.ToLower().Replace(" ", "")}/followers?per_page=5000");
                string Json = JsonConvert.SerializeObject(new object());
                StringContent Data = new StringContent(Json, Encoding.UTF8, "application/json");
                HttpClient Client = new HttpClient();
                Client.DefaultRequestHeaders.Add("User-Agent", "Git-Searching-App");
                HttpResponseMessage Res = await Client.GetAsync(Url.AbsoluteUri);
                string content = Res.Content.ReadAsStringAsync().Result;
                JArray FollowersInfo = JArray.Parse(content);
                try { return new FollowersViewModel(FollowersInfo) {User = user, Avatar = avatar}; }
                catch { return new FollowersViewModel(JObject.Parse(content)["message"].ToString(), ((int) Res.StatusCode).ToString()) {User = user, Avatar = avatar}; }
            }
            catch
            {
                return new FollowersViewModel("Not found", "404");
            }
        }
        public FollowersViewModel(JArray Followers)
        {
            this.Followers = Followers;
        }
        public FollowersViewModel(string Error, string StatusCode)
        {
            this.Error = Error;
            this.StatusCode =  StatusCode;
        }
    }
}