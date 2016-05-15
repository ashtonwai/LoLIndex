using System.Runtime.Serialization;

namespace LoLIndex.Models
{
    [DataContract]
    public class Champion
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
    }
}
