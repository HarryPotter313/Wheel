using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel
{
    public static class ShoppingCart
    {
        public static Dictionary<int, int> content = new Dictionary<int, int>();
        public static bool ContainsKey(int id) => content.ContainsKey(id);
    }
}
