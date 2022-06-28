using System.Text.Json;
using Tenjin.Configuration.Tests.Models;

namespace Tenjin.Configuration.Tests.Constants;

public static class TestConstants
{
    public static readonly TopSettings TestSettingsObject = new()
    {
        TopProperty1 = false,
        TopProperty2 = 100,
        TopProperty3 = "top property 3",
        TopProperty4 = new MiddleSettings
        {
            MiddleProperty1 = true,
            MiddleProperty2 = 200,
            MiddleProperty3 = "top property 4",
            MiddleProperty4 = new[]
            {
                new BottomSettings
                {
                    BottomProperty1 = false,
                    BottomProperty2 = 301,
                    BottomProperty3 = "Bottom Property 3_1"
                },
                new BottomSettings
                {
                    BottomProperty1 = true,
                    BottomProperty2 = 302,
                    BottomProperty3 = "Bottom Property 3_2"
                },
                new BottomSettings
                {
                    BottomProperty1 = false,
                    BottomProperty2 = 303,
                    BottomProperty3 = "Bottom Property 3_3"
                },
                new BottomSettings
                {
                    BottomProperty1 = true,
                    BottomProperty2 = 304,
                    BottomProperty3 = "Bottom Property 3_4"
                },
                new BottomSettings
                {
                    BottomProperty1 = false,
                    BottomProperty2 = 305,
                    BottomProperty3 = "Bottom Property 3_5"
                }
            }
        }
    };

    public static string GetJson()
    {
        var jsonObject = new
        {
            TestSection = TestSettingsObject
        };

        return JsonSerializer.Serialize(jsonObject);
    }
}