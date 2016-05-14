using System.Runtime.Serialization;

namespace LoLIndex.Services.Responses
{
    [DataContract]
    class AllChampions
    {
        [DataMember(Name="data")]
        public object Champions { get; set; }
    }
}
