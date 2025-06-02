using Microsoft.Extensions.Hosting;
using System;

namespace PiesSandra.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; }
        public decimal Сost { get; }
        public string Description { get; }
        public string ImagePath { get; }

        public Product(string name, decimal сost, string description, string imagePath)
        {
            Id = instanceCounter;
            Name = name;
            Сost = сost;
            Description = description;
            ImagePath = imagePath;

            instanceCounter++;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Сost}";
        }
    }
}
