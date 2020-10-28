using System;
using System.Linq;

namespace Practics
{
    public class UtitilityHelper
    {

        public int[] ConvertToInt(string orderIDs)
        {
            return orderIDs.Split("0", StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => Convert.ToInt32(c)).ToArray();
        }
    }
}
