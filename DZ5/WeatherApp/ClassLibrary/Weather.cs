﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibrary
{

    public class WeatherStruct
    {
        public string name { get; set; }
        public Dictionary<string, float> main { get; set; }
        public Dictionary<string, float> wind { get; set; }
        public DataTable weather { get; set; }
    }
}
