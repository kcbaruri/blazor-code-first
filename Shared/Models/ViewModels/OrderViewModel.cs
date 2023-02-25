using System.Collections.Generic;

namespace BlazorCodeFirst.Shared.Models.ViewModels
{
    public class OrderViewModel
    {
        public string Name { get; set; }
        public string State { get; set; }
        public List<Window> Windows { get; set; }
    }
}
