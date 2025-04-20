using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SupplyHelper
{
    public class RequestInfoDto
    {
        [JsonPropertyName("categoryNames")]
        public List<string> CategoryNames { get; set; }
        [JsonPropertyName("gostNames")]
        public List<string> GostNames { get; set; }
        [JsonPropertyName("pipeName")]
        public string PipeName { get; set; }
        [JsonPropertyName("sdr")]
        public double SDR { get; set; }
        [JsonPropertyName("thickness")]
        public double Thickness { get; set; }
        [JsonPropertyName("diametr")]
        public double Diametr { get; set; }
    }
}
