using System;
using ChartExample.Models.Chart;
using ChartExample.ViewComponents;
using Newtonsoft.Json;

namespace ChartExample.Models
{
    public class ChartJsViewModel
    {
        public ChartJs Chart { get; set; }
        public string ChartJson { get; set; }
    }
}