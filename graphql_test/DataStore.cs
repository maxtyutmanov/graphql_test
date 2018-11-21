using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphql_test
{
    public class DataStore
    {
        private class Item
        {
            public string ExchangeCode { get; set; }

            public int Year { get; set; }

            public DateTime Date { get; set; }

            public string Description { get; set; }

            public string Type { get; set; }

            public Item(string exchangeCode, int year, DateTime date, string description, string type)
            {
                ExchangeCode = exchangeCode;
                Year = year;
                Date = date;
                Description = description;
                Type = type;
            }
        }

        private readonly List<Item> _items;

        public DataStore()
        {
            _items = new List<Item>()
            {
                new Item("MISX", 2018, new DateTime(2018, 1, 1), "New Year", "trading"),
                new Item("MISX", 2018, new DateTime(2018, 1, 1), "New Year", "settlement"),
                new Item("MISX", 2018, new DateTime(2018, 1, 7), "XMAS", "trading"),
                new Item("XCME", 2018, new DateTime(2018, 12, 25), "XMAS", "settlement")
            };
        }

        public List<Holiday> GetHolidays(string exchangeCode, int year, string type)
        {
            return _items.Where(i => i.ExchangeCode == exchangeCode && i.Year == year && i.Type == type).Select(i => new Holiday()
            {
                Date = i.Date,
                Description = i.Description
            }).ToList();
        }
    }
}
