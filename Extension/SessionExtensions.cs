using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MerchWebsite.Extension
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : 
                JsonConvert.DeserializeObject<T>(value);
        }
    }
}

/*
    A static class, method, field, property, or event is callable on a class even when no instance of the class has been created. 
    If any instances of the class are created, they cannot be used to access the static member. 
    Only one copy of static fields and events exists, and static methods and properties can only access static fields and static events. 
    Static members are often used to represent data or calculations that do not change in response to object state; 
    for instance, a math library might contain static methods for calculating sine and cosine.
 */