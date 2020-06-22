using System.IO;
using Newtonsoft.Json;

namespace Auu.Utilities.Serialization
{
    public static class JsonUtility
    {
        public static string ToJson(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return json;
        }

        public static T GetObject<T>(string json)
        {
            var serializer = new JsonSerializer();
            var sr = new StringReader(json);
            var o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            var t = (T) o;
            return t;
        }


        public static string GetXmlFromJson(string json)
        {
            var doc = JsonConvert.DeserializeXmlNode(json);
            return doc?.OuterXml;
        }
    }
}