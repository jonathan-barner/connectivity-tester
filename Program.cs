using System;
using System.Net.Http;

namespace conn
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("http://neverssl.com");
            Test("https://google.com");

            Test("https://iam-client-test.us-east.philips-healthsuite.com/authorize/oauth2/token");
        }

        static void Test(string url)
        {
            try
            {
                Console.WriteLine($"===== Downloading {url}  .net version {Environment.Version} =====");
                var client = new HttpClient();
                var result = client.GetAsync(url).Result;
                Console.WriteLine($"StatusCode: {(int)result.StatusCode} {result.StatusCode}, ReasonPhrase: {result.ReasonPhrase}, Version: {result.Version}, Via: {result.Headers.Via}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
