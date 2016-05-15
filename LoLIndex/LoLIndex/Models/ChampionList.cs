using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    class ChampionList
    {
        [DataMember(Name = "data")]
        public Dictionary<string, Champion> Data { get; set; }
    }
}
