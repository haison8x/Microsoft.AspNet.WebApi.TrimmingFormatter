using System.Web.Http;

namespace Microsoft.AspNet.WebApi.TrimmingFormatter
{
    public static class FormatterConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SerializerSettings.Converters
                .Add(new TrimmingConverter());
        }
    }
}
