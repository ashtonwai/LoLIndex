using LoLIndex.Models;
using LoLIndex.Services.Requests;
using System.Collections.Generic;

namespace LoLIndex.ViewControllers
{
    public class ViewController
    {
        public List<Champion> Champions;

        DataService dataService;
        public ViewController()
        {
            dataService = new DataService();
        }

        public List<Champion> AllChampions()
        {
            Champions = new List<Champion>();
            ChampionList champList = dataService.GetChampionList();
            foreach (var champ in champList.Data.Values)
            {
                Champions.Add(champ);
            }
            return Champions;
        }

        public ChampionDetails ChampionDetail(int champId)
        {
            ChampionDetails champResponse = dataService.GetChampionDetail(new ChampionDetailRequest()
            {
                ChampId = champId
            });
            return champResponse;
        }
    }
}
