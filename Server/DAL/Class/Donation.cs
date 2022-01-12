using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Donation
    {
        [JsonConstructor]
        public Donation(string name, double pricing,int type, string designation, string conditions, int typeCurrency, double rate)
        {
            Name = name;
            Pricing = pricing;
            Type = type;
            Designation = designation;
            Conditions = conditions;
            TypeCurrency = typeCurrency;
            Rate = rate;
        }
        public string Name { get; set; }
        public double Pricing { get; set; }
        public int Type { get; set; }
        public string Designation { get; set; }
        public string Conditions { get; set; }
        public int TypeCurrency { get; set; }
        public double Rate { get; set; }
    }
}
