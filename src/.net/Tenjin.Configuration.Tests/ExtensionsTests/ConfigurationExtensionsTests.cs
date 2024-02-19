using System.IO;
using System.Text;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Tenjin.Configuration.Extensions;
using Tenjin.Configuration.Tests.Constants;
using Tenjin.Configuration.Tests.Models;

namespace Tenjin.Configuration.Tests.ExtensionsTests;

[TestFixture]
public class ConfigurationExtensionsTests
{
    [Test]
    public void BindObject_WhenProvidedWithAValidJson_EqualsTheExpectedPopulatedObject()
    {
        var jsonUtf8 = Encoding.UTF8.GetBytes(TestConstants.GetJson());
        using var jsonStream = new MemoryStream(jsonUtf8);
        var config = new ConfigurationBuilder()
           .AddJsonStream(jsonStream)
           .Build();
        var settings = config.BindObject<TopSettings>("TestSection");

        settings.Should().BeEquivalentTo(TestConstants.TestSettingsObject);
    }
}