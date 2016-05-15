using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionSkin
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "num")]
        public int Num { get; set; }
    }
}
