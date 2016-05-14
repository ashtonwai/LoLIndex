using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionInfo
    {
        [DataMember(Name="id")]
        public int ChampId { get; set; }

        [DataMember(Name="title")]
        public string ChampTitle { get; set; }

        [DataMember(Name="name")]
        public string ChampName { get; set; }

        [DataMember(Name="key")]
        public string ChampKey { get; set; }
    }
}
