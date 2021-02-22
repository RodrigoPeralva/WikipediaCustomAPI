using System.Net.Http;
using System.Threading.Tasks;

namespace WikipediaAPI {

    public class WikipediaClient {
        private readonly HttpClient client = new HttpClient();
        private const string baseUrl = "https://en.wikipedia.org/w/api.php";

        public Task<string> GetWiki(string palavra) {
            var paramsUrl = $"?action=query&format=json&list=search&srsearch={palavra}";

            var url = baseUrl + paramsUrl;

            var res = client.GetStringAsync(url);
            return res;
        }
    }
}