﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryClown
{
    class Program
    {
        static void Main(string[] args)
        {
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());
            
            IClown fingersTheClown = new ScaryScary("big red nose", 14);

            fingersTheClown.Honk();

            if (fingersTheClown is ScaryScary scaryClown)
                scaryClown.ScareLittleChildren();

            if(fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareAdults();
            }
        }
    }
}
