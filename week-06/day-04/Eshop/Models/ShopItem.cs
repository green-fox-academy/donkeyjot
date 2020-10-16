using System;
namespace Eshop.Models
{
    public class ShopItem
    {
        public Category EnumCategory { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public double Price { get; protected set; }
        public int QuantityOnStock { get; protected set; }

        public ShopItem(Category category, string name, string description, double price, int quantityOnStock)
        {
            EnumCategory = category;
            Name = name;
            Description = description;
            Price = price;
            QuantityOnStock = quantityOnStock;
        }
        public ShopItem()
        {

        }

        public static ShopItem FromCSV(string line)
        {
            string[] split = line.Split(",");
            ShopItem shopItem = new ShopItem();
            var cat = Enum.TryParse(split[0], out Category categ);
            if (cat)
            {
                shopItem.EnumCategory = categ;
            }
            else
            {
                shopItem.EnumCategory = Category.None;
            }
            shopItem.Name = split[1];
            shopItem.Description = split[2];
            shopItem.Price = Convert.ToDouble(split[3]);
            shopItem.QuantityOnStock = Convert.ToInt32(split[4]);
            return shopItem;
        }


    }
    public enum Category
    {
        None,
        Frame,
        Wheelset,
        BrakeCaliper,
        Bottle,

    }
}
