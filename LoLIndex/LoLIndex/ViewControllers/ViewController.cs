using LoLIndex.Models;
using LoLIndex.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LoLIndex.ViewControllers
{
    public class ViewController
    {
        DataService dataService;
        public ViewController()
        {
            dataService = new DataService();
        }

        public List<Champion> AllChampions()
        {
            List<Champion> Champions = new List<Champion>();
            ChampionDictionary champList = dataService.GetChampionData().Data;
            PropertyInfo[] champs = champList.GetType().GetProperties();
            foreach (var champ in champs)
            {
                Champions.Add((Champion)champ.GetValue(champList, null));
            }
            Champions = Champions.OrderBy(o => o.Key).ToList();

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
