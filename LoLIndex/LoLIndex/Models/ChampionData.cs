using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    class ChampionData
    {
        [DataMember(Name = "data")]
        public ChampionDictionary Data { get; set; }
    }
}
