using LoLIndex.Models;
using LoLIndex.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLIndex.ViewControllers
{
    public class ViewController
    {
        DataService dataService;
        public ViewController()
        {
            dataService = new DataService();
        }

        public object GetAllChampions()
        {
            return dataService.GetAllChampions();
        }
    }
}
