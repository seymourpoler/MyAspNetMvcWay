using Newtonsoft.Json;

namespace MyAspNetWay
{
    public static class Serializer
    {
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static string Serialize<T>(T dto)
        {
            return JsonConvert.SerializeObject(dto);
        }
    }
}