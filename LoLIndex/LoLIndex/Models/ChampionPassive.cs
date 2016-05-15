using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionPassive
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [DataMember(Name = "image")]
        public LoLImage Image { get; set; }
    }
}
