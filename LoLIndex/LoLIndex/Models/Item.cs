using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }
    }
}
