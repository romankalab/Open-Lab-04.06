using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var lis = new List<int> { };
            foreach (var element in numbers)
                if (element % 2 == 0)
                    lis.Add(element);
            return lis.ToArray();
        }
    }
}
