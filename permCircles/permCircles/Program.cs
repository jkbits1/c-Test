using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace permCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] pos = {1,2,3,4};
            List<int> first = new List<int>(pos);

            var tPart = turnWheel(first, 1);

            int i = 0;


        }

        static List<int> turnWheel(List<int> wheelPos, int chunk) {
            IEnumerable<int> takePart = wheelPos.Take(chunk);
            IEnumerable<int> dropPart = wheelPos.Skip(chunk);

            IEnumerable<int> newPos = dropPart.Concat(takePart);

            return newPos.ToList();
        }

    }

    
}
