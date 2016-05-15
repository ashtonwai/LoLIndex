using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionRecommended
    {
        [DataMember(Name = "champion")]
        public string Champion { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "map")]
        public string Map { get; set; }

        [DataMember(Name = "mode")]
        public string Mode { get; set; }

        [DataMember(Name = "blocks")]
        public List<RecommenedBlocks> Blocks { get; set; }
    }
}
