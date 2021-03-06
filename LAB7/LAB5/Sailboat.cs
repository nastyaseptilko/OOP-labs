﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    sealed class Sailboat : Ship
    {
        public Sailboat(double Carrying, string CaptainName, uint CaptainAge, double Delta)
            : base(Carrying, CaptainName, CaptainAge, Delta)
        {
            ToWater();
        }

        public override void Move() => Console.WriteLine("Hold your nose to the wind");
        public override string ToString() => "Sailboat";
    }
}
