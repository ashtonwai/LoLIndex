using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class SpellVar
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "coeff")]
        public List<double> Coeff { get; set; }
    }
}
