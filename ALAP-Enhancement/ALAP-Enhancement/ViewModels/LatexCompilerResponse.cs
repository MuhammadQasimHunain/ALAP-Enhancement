﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALAP_Enhancement.ViewModels
{
    public class LatexCompilerResponse
    {
        public string FileName { get; set; }
        public bool Status { get; set; }
        public string LogFileName { get; set; }
    }
}