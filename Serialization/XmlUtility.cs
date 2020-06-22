using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Auu.Utilities.Serialization
{
    public static class XmlUtility
    {
        public static string ToXml(object obj)
        {
            using (var sw = new StringWriter())
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(sw, obj);
                sw.Close();
                return sw.ToString();
            }
        }

        public static T GetObject<T>(string strXml) where T : class
        {
            try
            {
                using (var sr = new StringReader(strXml))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    return serializer.Deserialize(sr) as T;
                }
            }
            catch
            {
                return null;
            }
        }

        public static string GetJsonFromXml(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            var json = JsonConvert.SerializeXmlNode(doc);
            return json;
        }
    }
}