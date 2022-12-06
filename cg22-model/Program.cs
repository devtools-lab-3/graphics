using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cg22_model.Models;
using cg22_model.Models.ColorSpacesSpaces;

namespace cg22_model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pixel1 = new FloatPixel(0, 0.2f, 0.3f);
            var pixel2 = HSV.ToRGBSinglePixel(pixel1);

            System.Console.WriteLine($"{pixel2.Component1}\n{pixel2.Component2}\n{pixel2.Component3}");
        }
    }
}
