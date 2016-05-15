using LoLIndex.Models;
using System;

namespace LoLIndex.Services.Requests
{
    class DataService
    {
        private const string LOL_API = "https://global.api.pvp.net/api/lol/static-data/na/v1.2";
        private const string API_KEY = "a4a035f2-b41c-4756-bb76-dbc721bce4dd";

        public ChampionData GetChampionData()
        {
            Uri serviceURI = new Uri($"{LOL_API}/champion?champData=image&api_key={API_KEY}");
            ServiceManager svcMgr = new ServiceManager(serviceURI);
            ChampionData response = svcMgr.CallService<ChampionData>();
            return response;
        }

        public ChampionDetails GetChampionDetail(ChampionDetailRequest request)
        {
            Uri serviceURI = new Uri($"{LOL_API}/champion/{request.ChampId}?champData=all&api_key={API_KEY}");
            ServiceManager svcMgr = new ServiceManager(serviceURI);
            ChampionDetails response = svcMgr.CallService<ChampionDetails>();
            return response;
        }
    }
}
