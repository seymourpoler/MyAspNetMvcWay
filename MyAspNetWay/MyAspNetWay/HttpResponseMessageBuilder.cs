using System.Net;
using System.Net.Http;
using System.Text;

namespace MyAspNetWay
{
    public class HttpResponseMessageBuilder
    {
        public static HttpResponseMessage Build<T>(T obj, HttpStatusCode statusCode = HttpStatusCode.OK) where T : class
        {
            return new HttpResponseMessage
            {
                Content = new StringContent(Serializer.Serialize(obj),
                                            Encoding.UTF8,
                                            "application/json"),
                StatusCode = statusCode
            };
        }

        public static HttpResponseMessage Build(HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new HttpResponseMessage {StatusCode = statusCode};
        }
    }
}