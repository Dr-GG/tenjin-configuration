using System.Collections.Generic;

namespace Tenjin.Configuration.Tests.Models
{
    public class MiddleSettings
    {
        public bool MiddleProperty1 { get; set; }
        public int MiddleProperty2 { get; set; }
        public string MiddleProperty3 { get; set; } = string.Empty;
        public IEnumerable<BottomSettings> MiddleProperty4 { get; set; } = null!;
    }
}
