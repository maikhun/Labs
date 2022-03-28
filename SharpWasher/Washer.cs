using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    internal class Washer
    {
        public void Wash(IWashable obj)
        {
            obj.IsDirty = false;
        }
    }
}
