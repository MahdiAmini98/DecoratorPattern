using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Example_3.WebClient
{
    public class WebClientDecorator:System.Net.WebClient
    {
        private readonly System.Net.WebClient _webClient;

        public WebClientDecorator(System.Net.WebClient webClient)
        {
            _webClient = webClient;
        }

        public string DownloadString(string address)
        {
            if (address.StartsWith("https://www.Bugeto.com"))
            {
                return _webClient.DownloadString(address);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
