﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TruckingCalculator.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        ConvenienceCalculation
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
