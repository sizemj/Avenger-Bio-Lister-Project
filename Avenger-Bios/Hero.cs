using System;
using System.Collections.Generic;
using System.Text;
using AvengersBioLister.Models;

namespace AvengersBioLister
{
    public class Hero
    {
        public string Name { get; set; }
        public Biography biography { get; set; }
        public Appearance appearance { get; set; }
        public Work work { get; set; }
        public Connections connections { get; set; }

    }
}
