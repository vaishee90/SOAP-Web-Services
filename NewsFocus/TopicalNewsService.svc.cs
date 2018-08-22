using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using unirest_net;
using Newtonsoft.Json;

namespace NewsFocus
{
    public class TopicalNewsService : ITopicalNewsService
    {
        public string[] NewsFocus(string[] keyWords)
        {
            List<string> resultUrlList = new List<string>();
            string apiKey = "";
            string query = "";
            Int32 count = 10;
            bool autoCorrect = true;
            if (keyWords.Length < 2)
                query = keyWords[0];
            else
            {
                query = keyWords[0];
                for (Int32 i = 1; i < keyWords.Length; i++)
                {
                    query += "+" + keyWords[i];
                }
            }

            // Referenced from: https://rapidapi.com/contextualwebsearch/api/Web%20Search/docs
            // hitting the contextualwebsearch API to get the response
            var response = unirest_net.http.Unirest.get(string.Format("https://contextualwebsearch-websearch-v1.p.mashape.com/api/Search/WebSearchAPI?q={0}&count={1}&autocorrect={2}", query, count, autoCorrect))
                .header("X-Mashape-Key", apiKey)
                .header("X-Mashape-Host", "contextualwebsearch-websearch-v1.p.mashape.com")
                .asJson<string>();

            // get the body of the JSON response
            dynamic jsonBody = JsonConvert.DeserializeObject(response.Body);

            // loop through each item in the JSON body to fetch the URLs
            foreach (var webPage in jsonBody["value"])
            {
                string url = webPage["url"].ToString();
                resultUrlList.Add(url);
            }

            // return the list of URLs gathered
            return resultUrlList.ToArray();
        }
    }
}
