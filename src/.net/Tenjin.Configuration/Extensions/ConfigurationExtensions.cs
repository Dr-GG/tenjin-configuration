using Microsoft.Extensions.Configuration;

namespace Tenjin.Configuration.Extensions;

public static class ConfigurationExtensions
{
    public static TObject BindObject<TObject>(this IConfiguration configuration, string key)
        where TObject : class, new()
    {
        var obj = new TObject();

        configuration.Bind(key, obj);

        return obj;
    }
}