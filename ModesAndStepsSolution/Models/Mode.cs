using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModesAndStepsSolution.Models
{
    public class Mode: ItemBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxBottleNumber { get; set; }
        public int MaxUsedTips { get; set; }

    }
}
