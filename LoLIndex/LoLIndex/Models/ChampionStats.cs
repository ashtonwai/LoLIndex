using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class ChampionStats
    {
        [DataMember(Name = "armor")]
        public double Armor { get; set; }

        [DataMember(Name = "armorperlevel")]
        public double ArmorPerLevel { get; set; }

        [DataMember(Name = "attackdamage")]
        public double AttackDamage { get; set; }

        [DataMember(Name = "attackdamageperlevel")]
        public double AttackDamagePerLevel { get; set; }

        [DataMember(Name = "attackrange")]
        public int AttackRange { get; set; }

        [DataMember(Name = "attackspeedoffset")]
        public double AttackSpeedOffset { get; set; }

        [DataMember(Name = "attackspeedperlevel")]
        public double AttackSpeedPerLevel { get; set; }

        [DataMember(Name = "crit")]
        public double Crit { get; set; }

        [DataMember(Name = "critperlevel")]
        public double CritPerLevel { get; set; }

        [DataMember(Name = "hp")]
        public double Hp { get; set; }

        [DataMember(Name = "hpperlevel")]
        public double HpPerLevel { get; set; }

        [DataMember(Name = "hpregenperlevel")]
        public double HpRegenPerLevel { get; set; }

        [DataMember(Name = "movespeed")]
        public int MoveSpeed { get; set; }

        [DataMember(Name = "mp")]
        public double Mp { get; set; }

        [DataMember(Name = "mpperlevel")]
        public double MpPerLevel { get; set; }

        [DataMember(Name = "mpregen")]
        public double MpRegen { get; set; }

        [DataMember(Name = "mpregenperlevel")]
        public double MpRegenPerLevel { get; set; }

        [DataMember(Name = "spellblock")]
        public double SpellBlock { get; set; }

        [DataMember(Name = "spellblockperlevel")]
        public double SpellBlockPerLevel { get; set; }
    }
}
