using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoLIndex.Models
{
    [DataContract]
    public class SpellLevelTip
    {
        [DataMember(Name = "label")]
        public List<string> Label { get; set; }

        [DataMember(Name = "effect")]
        public List<string> Effect { get; set; }
    }
}
