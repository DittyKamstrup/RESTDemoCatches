using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RESTDemoCatches;

namespace CatchConsole
{
    class RestClient
    {
        private const string uri = "http://localhost:10887/Service1.svc";


        //private static async Task<IList<Catch>> GetCatchesAsync()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        string content = await client.GetStringAsync(CustomersUri);
        //        IList<Catch> cList = JsonConvert.DeserializeObject<IList<Catch>>(content);
        //        return cList;
        //    }
        //}


    }
}
