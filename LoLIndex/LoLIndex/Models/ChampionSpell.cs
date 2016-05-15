using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionSpell
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [DataMember(Name = "tooltip")]
        public string ToolTip { get; set; }

        [DataMember(Name = "sanitizedtooltip")]
        public string SanitizedToolTip { get; set; }

        [DataMember(Name = "leveltip")]
        public object LevelTip { get; set; }

        [DataMember(Name = "image")]
        public LoLImage Image { get; set; }

        [DataMember(Name = "resource")]
        public string Resource { get; set; }

        [DataMember(Name = "maxrank")]
        public int MaxRank { get; set; }

        [DataMember(Name = "cost")]
        public List<int> Cost { get; set; }

        [DataMember(Name = "costType")]
        public string CostType { get; set; }

        [DataMember(Name = "costBurn")]
        public string CostBurn { get; set; }

        [DataMember(Name = "cooldown")]
        public List<int> Cooldown { get; set; }

        [DataMember(Name = "cooldownBurn")]
        public int CooldownBurn { get; set; }

        [DataMember(Name = "effect")]
        public List<List<int>> Effect { get; set; }

        [DataMember(Name = "effectBurn")]
        public List<string> EffectBurn { get; set; }

        [DataMember(Name = "vars")]
        public List<SpellVar> Vars { get; set; }

        [DataMember(Name = "range")]
        public List<int> Range { get; set; }

        [DataMember(Name = "rangeBurn")]
        public string RangeBurn { get; set; }

        [DataMember(Name = "key")]
        public string Key { get; set; }
    }
}
