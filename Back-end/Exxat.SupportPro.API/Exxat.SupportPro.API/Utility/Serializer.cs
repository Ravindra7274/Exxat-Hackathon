using System;
using Newtonsoft.Json;

namespace Exxat.SupportPro.API.Utility
{
    public class Serializer
    {        
        public static TClass GetObject<TClass>(String json) where TClass : class, new()
        {
            TClass x = new TClass();
            try
            {
                if (!String.IsNullOrEmpty(json))
                {
                    x = Newtonsoft.Json.JsonConvert.DeserializeObject<TClass>(json);
                }
                else
                {
                    x = null;
                }
            }
            catch (Exception ex)
            {
                x = null;
            }
            return x;
        }

        public static Object GetObject(string data)
        {
            object x = new object();
            try
            {
                if (!String.IsNullOrEmpty(data))
                {
                    x = Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                }
                else
                {
                    x = null;
                }
            }
            catch
            {
                x = null;
            }
            return x;
        }
        public static T GetContextObject<T>(String json) where T : class, new()
        {
            T context = null;
            try
            {
                if (!String.IsNullOrEmpty(json))
                {
                    var o = JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string, object>>(json, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, DateFormatHandling = DateFormatHandling.MicrosoftDateFormat, Formatting = Formatting.None });

                    if (o != null)
                    {
                        var contextClass = typeof(T).Name;
                        if (o.ContainsKey(contextClass))
                        {
                            context = (T)JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(o[contextClass]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return context;
        }
    }
}