using System.Collections.Generic;
using RestSharp;

namespace hydra.Models
{
    public class SrApi
    {
        const string BaseUrl = "http://api.sr.se/api/v2";

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = BaseUrl;
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

        public List<ProgramCategory> GetProgramCategories()
        {
            var request = new RestRequest();
            request.Resource = "/programcategories/?pagination=false";
            request.RootElement = "programcategories";
            return Execute<List<ProgramCategory>>(request);
        }
    }

    public class ProgramCategory
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}