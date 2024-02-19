using Microsoft.Extensions.Configuration;

namespace Tenjin.Configuration.Extensions;

/// <summary>
/// A collection of extension methods for IConfiguration.
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Binds an object of a specified type to the configuration section with the specified key.
    /// </summary>
    public static TObject BindObject<TObject>(this IConfiguration configuration, string key)
        where TObject : class, new()
    {
        var obj = new TObject();

        configuration.Bind(key, obj);

        return obj;
    }
}