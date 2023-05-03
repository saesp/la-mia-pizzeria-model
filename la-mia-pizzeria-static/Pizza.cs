namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }

        public Pizza(int id, string name, string? description, string? image, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }

        public static List<Pizza> pizzas = new()
        {
            new (1, "Marinara", null, null, 4),
            new (2, "Margherita", null, null, 5),
            new (3, "Filetto", null, null, 7),
            new (4, "Capricciosa", null, null, 7),
            new (5, "Bufala", null, null, 8),
            new (6, "4 formaggi", null, null, 8),
        };
    }
}
