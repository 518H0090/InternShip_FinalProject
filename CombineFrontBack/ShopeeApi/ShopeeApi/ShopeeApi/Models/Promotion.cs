using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Promotion
    {
        reduceNone = 0,
        reduce30K = 30000,
        reduce10K = 10000,
        reduce20K = 20000,
        reduce = 5000,
        reduce40K = 40000,
        reduce50K = 50000,
        reduce60K = 60000,
        reduce70K = 70000,
        reduce80K = 80000,
        reduce90K = 90000,
        reduce100K = 100000,
        reduce150K = 150000,
        reduce200K = 200000,
        reduce250K = 250000,
        reduce400K = 400000
    }
}