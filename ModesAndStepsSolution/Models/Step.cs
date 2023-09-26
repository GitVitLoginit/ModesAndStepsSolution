using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModesAndStepsSolution.Models
{
    public class Step: ItemBase
    {
        public int Id { get; set; }
        public int ModeId { get; set; }
        public string Timer { get; set; }
        public string Destination { get; set; }
        public string Speed { get; set; }
        public string Type { get; set; }
        public string Volume { get; set; }
    }
}
