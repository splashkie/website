using MudBlazor;

namespace MudBlazorWebApp1.Components.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public MudImage Image { get; set; }
        public int Price {  get; set; }
        public int Discount { get; set; }
    }
}
