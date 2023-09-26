using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModesAndStepsSolution.Models
{
    public class ItemBase
    {
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
        public bool IsNew { get; set; }

    }
}
