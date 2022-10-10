using System.Text.Json.Serialization;

namespace ShopeeApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Promotion
    {
        reduceNone = 0,
        reduce30K = 30,
        reduce10K = 10,
        reduce20K = 20,
        reduce = 5,
        reduce40K = 40,
        reduce50K = 50,
        reduce60K = 60,
        reduce70K = 70,
        reduce80K = 80,
        reduce90K = 90,
        reduce100K = 100,
        reduce150K = 150,
        reduce200K = 200,
        reduce250K = 250,
        reduce400K = 400
    }
}