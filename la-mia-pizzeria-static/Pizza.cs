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
            new (1, "Marinara", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam mattis, nunc ut varius pharetra, enim ipsum euismod ante, a sodales mauris dui nec lectus. Pellentesque ut justo vel nulla sagittis imperdiet non non risus. Nam et sollicitudin orci. Sed finibus eros ac bibendum mollis. ", "https://th.bing.com/th/id/R.2b81070d5bf07de3fc737e11828ec9fa?rik=HyW%2bu6OVuIEfWw&pid=ImgRaw&r=0", 4),
            new (2, "Margherita", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam mattis, nunc ut varius pharetra, enim ipsum euismod ante, a sodales mauris dui nec lectus. Pellentesque ut justo vel nulla sagittis imperdiet non non risus. Nam et sollicitudin orci. Sed finibus eros ac bibendum mollis. ", "https://cdn.vox-cdn.com/thumbor/-8vtkFItJQ85nEafqXxZ_oYz694=/0x0:4500x3000/1200x800/filters:focal(1890x1140:2610x1860)/cdn.vox-cdn.com/uploads/chorus_image/image/60380693/20180424_GH_UNAPIZZA_1012.0.jpg", 5),
            new (3, "Filetto", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam mattis, nunc ut varius pharetra, enim ipsum euismod ante, a sodales mauris dui nec lectus. Pellentesque ut justo vel nulla sagittis imperdiet non non risus. Nam et sollicitudin orci. Sed finibus eros ac bibendum mollis. ", "https://th.bing.com/th/id/OIP.b8GPIG9ud5VziECz8Q9L7AHaE8?pid=ImgDet&rs=1", 7),
            new (4, "Capricciosa", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam mattis, nunc ut varius pharetra, enim ipsum euismod ante, a sodales mauris dui nec lectus. Pellentesque ut justo vel nulla sagittis imperdiet non non risus. Nam et sollicitudin orci. Sed finibus eros ac bibendum mollis. ", "https://th.bing.com/th/id/R.983f28b64fa9d565d7fd63bf557b6b23?rik=xYG9aRt7az1v2g&pid=ImgRaw&r=0", 7),
            new (5, "Bufala", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam mattis, nunc ut varius pharetra, enim ipsum euismod ante, a sodales mauris dui nec lectus. Pellentesque ut justo vel nulla sagittis imperdiet non non risus. Nam et sollicitudin orci. Sed finibus eros ac bibendum mollis. ", "https://th.bing.com/th/id/R.d026806ae7b9b122e68f1b28b22dba7b?rik=Rm%2bw5ToaHvSvKw&riu=http%3a%2f%2fwww.italianconceptrestaurant.com%2fwp-content%2fuploads%2f2020%2f06%2fbufala.jpg&ehk=11iv1pKIcWHQiV8m4lr2OHb1eunZyiKob%2fvJrcfdst8%3d&risl=&pid=ImgRaw&r=0", 8),
            new (6, "Ortolana", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam mattis, nunc ut varius pharetra, enim ipsum euismod ante, a sodales mauris dui nec lectus. Pellentesque ut justo vel nulla sagittis imperdiet non non risus. Nam et sollicitudin orci. Sed finibus eros ac bibendum mollis. ", "https://th.bing.com/th/id/R.711776b78a0f958f0dcb7d202ace90c9?rik=p2m7q8Z3oyU0lw&pid=ImgRaw&r=0", 8),
        };
    }
}
