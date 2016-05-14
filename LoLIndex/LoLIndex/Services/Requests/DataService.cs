using LoLIndex.Services.Responses;
using System;

namespace LoLIndex.Services.Requests
{
    class DataService
    {
        private const string LOL_API = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/";
        private const string API_KEY = "a4a035f2-b41c-4756-bb76-dbc721bce4dd";

        public object GetAllChampions()
        {
            Uri serviceURI = new Uri($"{LOL_API}/champion?api_key={API_KEY}");
            ServiceManager svcMgr = new ServiceManager(serviceURI);
            var response = svcMgr.CallService<AllChampions>();
            return response.Champions;
        }
    }
}
