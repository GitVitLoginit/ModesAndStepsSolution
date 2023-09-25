using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModesAndStepsSolution.Models
{
    internal struct SqlCommandParameter
    {
        public  SqlCommandParameter(string parameterName, string value)
        {
            ParameterName= parameterName;
            Value = value;
        }
        public string ParameterName {  get; set; }
        public object Value { get; set; }
    }
}
