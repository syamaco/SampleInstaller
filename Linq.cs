using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Linq
{
    class Linq
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var items = new List<Item>();

            items.Add(new Item(1, 2, 3, "foo"));
            items.Add(new Item(2, 2, 3, "bar"));
            items.Add(new Item(1, 3, 1, "buz"));

            var t = items.Select((item, i) => new {
                    Id       = "" + item.category + item.field1 + item.field2,
                    category = item.category,
                    field1   = item.field1,
                    field2   = item.field2,
                    name     = item.name,
                    seq      = i
                }).ToDictionary(item => item.Id);

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(t);

            Console.WriteLine(json);
        }
    }

    class Item
    {
        public Item(int category, int field1, int field2, string name)
        {
            this.category = category;
            this.field1 = field1;
            this.field2 = field2;
            this.name = name;
        }

        public int category { get; set; }
        public int field1 { get; set; }
        public int field2 { get; set; }
        public string name { get; set; }
    }
}
