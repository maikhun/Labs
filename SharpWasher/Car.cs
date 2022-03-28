using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    public interface IWashable
    {
        bool IsDirty { get; set; }
    }
    internal class Car
    {
        public string Model { get; set; }
        public bool IsDirty { get; set; }
    }
}
