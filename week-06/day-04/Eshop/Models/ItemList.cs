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


    }
}
