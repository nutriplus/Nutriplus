using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Measurements
    {
        public int Id { get; set; }
        public int Client { get; set; }
        public float Weight { get; set; }
        public float FatPercentage { get; set; }
        public float Bmi { get; set; }
        
    }
}