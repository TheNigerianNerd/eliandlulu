namespace BlazorApp.Client.Features.Home;
public class MenuItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Image { get; set; } = "";
        public bool IsAvailable { get; set; } = true;
        public bool IsVegetarian { get; set; }
        public int PrepTimeMinutes { get; set; }
    }
