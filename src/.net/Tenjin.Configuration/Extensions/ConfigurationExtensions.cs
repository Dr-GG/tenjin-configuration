using Microsoft.Extensions.Configuration;

namespace Tenjin.Configuration.Extensions;

/// <summary>
/// A collection of extensions for the IConfiguration instance.
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Binds an object by key from an IConfiguration instance to a strongly typed object.
    /// </summary>
    public static TObject BindObject<TObject>(this IConfiguration configuration, string key)
        where TObject : class, new()
    {
        var obj = new TObject();

        configuration.Bind(key, obj);

        return obj;
    }
}