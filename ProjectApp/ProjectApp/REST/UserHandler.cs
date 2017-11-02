using Newtonsoft.Json;
using ProjectApp.DTOClasses;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.REST
{
    class UserHandler
    {
        HttpClient client;
        public UserHandler()
        {
            client = new HttpClient();
        }

        public async Task<HttpResponseMessage> CreateUser(UserDTO u)
        {
            var uri = new Uri(string.Format("http://159.89.5.145:3000/users", string.Empty));
            String a = JsonConvert.SerializeObject(new { user = u });
            System.Diagnostics.Debug.WriteLine(a);
            StringContent content = new StringContent(a, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri,content);
            return response;
        }
    }
}
