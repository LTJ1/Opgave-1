﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module19
{
    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }

    }
}
