using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_1
{
    public class PC
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorFrequency { get; set; }
        public int RAMSize { get; set; }
        public int HDDSize { get; set; }
        public int VGASize { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}; Name: {Name}; ProcessorType: {ProcessorType}; ProcessorFrequency: {ProcessorFrequency}; RAMSize: {RAMSize}; HDDSize: {HDDSize}; VGASize: {VGASize}; Price: {Price}; Quantity: {Quantity}.";
        }
    }
}
