using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                 new Product
        {
            Id = 1,
            CategoryId = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G) is a comedy science fiction series",
            Image = "https://m.media-amazon.com/images/M/MV5BZmU5MGU4MjctNjA2OC00N2FhLWFhNWQtMzQyMGI2ZmQ0Y2YyL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
            Price = 9.99m,
            OriginalPrice = 19.99m
        },
        new Product
        {
            Id = 2,
            CategoryId = 1,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.",
            Image = "https://i.pinimg.com/originals/3c/6e/a9/3c6ea950d05f8a6c66061a262a3ac39b.jpg",
            Price = 7.19m,
            OriginalPrice = 14.99m
            },
        new Product
        {
            Id = 3,
            CategoryId = 1,
            Title = "Nineteen Eighty-Four",
            Description = "Nineteen Eighty-Four: A Novel, often referred to as 1984, is a dystopian social science fiction novel by the English novelist George Orwell.",
            Image = "https://images-na.ssl-images-amazon.com/images/I/91SZSW8qSsL.jpg",
            Price = 8.99m
        },
        new Product
        {
            Id = 4,
            CategoryId = 2,
            Title = "Pentax Spotmatic",
            Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
            Image = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Spotmatic-4.jpg",
            Price = 166.66m,
            OriginalPrice = 249.00m
        },
        new Product
        {
            Id = 5,
            CategoryId = 2,
            Title = "Xbox",
            Description = "Xbox is a video gaming brand created and owned by Microsoft. The brand consists of five video game consoles, as well as applications (games), streaming services, an online service by the name of Xbox network, and the development arm by the name of Xbox Game Studios.",
            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Xbox-console.jpg/1200px-Xbox-console.jpg",
            Price = 159.99m,
            OriginalPrice = 299m
        },
        new Product
        {
            Id = 6,
            CategoryId = 2,
            Title = "Super Nintendo Entertainment System",
            Description = "The Super Nintendo Entertainment System (SNES),[b] commonly shortened to Super NES or Super Nintendo,[c] is a 16-bit home video game console developed by Nintendo",
            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/SNES-Mod1-Console-Set.jpg/375px-SNES-Mod1-Console-Set.jpg",
            Price = 73.74m,
            OriginalPrice = 400m
        },
        new Product
        {
            Id = 7,
            CategoryId = 3,
            Title = "Half-Life 2",
            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve.",
            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/25/Half-Life_2_cover.jpg/220px-Half-Life_2_cover.jpg",
            Price = 8.19m,
            OriginalPrice = 29.99m,
        },
        new Product
        {
            Id = 8,
            CategoryId = 3,
            Title = "Diablo II",
            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North ",
            Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
            Price = 9.99m,
            OriginalPrice = 24.99m
        },
        new Product
        {
            Id = 9,
            CategoryId = 3,
            Title = "Day of the Tentacle",
            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle,[2][3] is a 1993 graphic adventure game developed and published by LucasArts.",
            Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
            Price = 7.99m,
            OriginalPrice = 22.99m
        }
        };
        }
    }
}
