﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Campaign  // Entity class for campaigns
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public float DiscountAmount { get; set; }
    }
}
