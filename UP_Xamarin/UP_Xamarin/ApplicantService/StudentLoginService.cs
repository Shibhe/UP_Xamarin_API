using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UP_Xamarin.ApplicantService
{
    public class StudentLoginService
    {
        public async Task LoginAsync(string username, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string> ("username", username),
                new KeyValuePair<string, string> ("Password", password),
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:64599/api/StudentLogins/");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();

            var response = await client.SendAsync(request);
            var content = await request.Content.ReadAsStringAsync();
            Debug.WriteLine(content);
        }
    }
}
