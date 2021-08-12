using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (input!= "end")
            {
                string[] data = input.Split();
                string serialNumber = data[0];
                string ItemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item currentItem = new Item();
                currentItem.Name = ItemName;
                currentItem.Price = itemPrice;
                Box box = new Box();
                box.Item = currentItem;
                box.ItemQuantity = itemQuantity;
                box.SerialNumber = serialNumber;
                box.BoxPrice = itemQuantity * currentItem.Price;
                boxes.Add(box);
                input = Console.ReadLine();
            }
            List<Box> sortedList = boxes.OrderByDescending(o => o.BoxPrice).ToList();
            foreach ( Box box in sortedList)
            {
                Console.WriteLine($"{box.SerialNumber} \n-- {box.Item.Name} - ${box.Item.Price :f2}: {box.ItemQuantity}\n-- ${box.BoxPrice :f2}");
                
              
            }
        }

        
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}
