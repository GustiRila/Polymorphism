﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog says: Guk-guk");
        }
    }
}
