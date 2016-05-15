using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class RecommenedBlocks
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "recMath")]
        public bool RecMath { get; set; }

        [DataMember(Name = "items")]
        public List<Item> Items { get; set; }
    }
}
