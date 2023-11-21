using Bober2.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bober2
{
    internal class EF
    {
        public static Entities context { get; } = new Entities();
    }
}
