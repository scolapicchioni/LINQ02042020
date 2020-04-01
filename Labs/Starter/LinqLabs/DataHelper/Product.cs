﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataHelper
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return $"{ID} - {Name}";
        }
    }
}
