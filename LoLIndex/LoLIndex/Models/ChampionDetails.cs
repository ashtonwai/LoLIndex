using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionDetails
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "image")]
        public LoLImage Image { get; set; }

        [DataMember(Name = "skins")]
        public List<ChampionSkin> Skins { get; set; }

        [DataMember(Name = "lore")]
        public string Lore { get; set; }

        [DataMember(Name = "blurb")]
        public string Blurb;

        [DataMember(Name = "allytips")]
        public List<string> AllyTips { get; set; }

        [DataMember(Name = "enemytips")]
        public List<string> EnemyTips { get; set; }

        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }

        [DataMember(Name = "partype")]
        public string Partype { get; set; }

        [DataMember(Name = "info")]
        public ChampionInfo Info { get; set; }

        [DataMember(Name = "stats")]
        public ChampionStats Stats { get; set; }

        [DataMember(Name = "spells")]
        public List<ChampionSpell> Spells { get; set; }

        [DataMember(Name = "passive")]
        public ChampionPassive Passive { get; set; }

        [DataMember(Name = "recommended")]
        public List<ChampionRecommended> Recommended { get; set; }
    }
}
