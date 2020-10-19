using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Eshop.Models;
using System.Linq;

namespace Eshop.Models
{
    public class ItemList
    {
        public List<ShopItem> ItemsList { get; set; }

        public ItemList(string filePath)
        {
            ItemsList = File.ReadAllLines(filePath)
                .Skip(1)
                .Select(v => ShopItem.FromCSV(v))
                .ToList();
        }

        public void GetAvailable()
        {
            ItemsList = ItemsList.Where(i => i.QuantityOnStock > 0).ToList();
        }

        public double GetAverageStock()
        {
            double averageStock = ItemsList.Average(i => i.QuantityOnStock);
            return averageStock;
        }

        public void CheapestFirst()
        {
            ItemsList = ItemsList.OrderBy(i => i.Price).ToList();
        }

        public void IsContaining(string keyword)
        {
            ItemsList = ItemsList.Where(i => i.Name.ToLower().Contains(keyword) || i.Description.ToLower().Contains(keyword)).ToList();
        }
    }
}
