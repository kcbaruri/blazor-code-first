using System.Collections.Generic;

namespace BlazorCodeFirst.Shared.Models.ViewModels
{
    public class Window
    {
        public string Name { get; set; }
        public int QuantityOfWindows { get; set; }
        public int TotalSubElements{ get; set; }
        public List<SubElement> SubElements { get; set; }
    }
}
