namespace Tenjin.Configuration.Tests.Models;

public class TopSettings
{
    public bool TopProperty1 { get; set; }
    public int TopProperty2 { get; set; }
    public string TopProperty3 { get; set; } = string.Empty;
    public MiddleSettings TopProperty4 { get; set; } = null!;
}