using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace permCircles
{
    using WheelPos = IEnumerable<int>;
    //using WheelLoop = IEnumerable<>;

    class Program
    {
        static void Main (string[] args)
        {
            int [] pos = {1,2,3,4};
            List<int> first = new List<int>(pos);

            var tPart = turnWheel(first, 1);

            WheelPos [] items = {};

            var newItems = buildWheelLoop(items, tPart, 0);

            int i = 0;
        }

        //static List<int> turnWheel (List<int> wheelPos, int chunk) {
        static WheelPos turnWheel (WheelPos wheelPos, 
                                            int chunk) {
            IEnumerable<int> takePart = wheelPos.Take(chunk);
            IEnumerable<int> dropPart = wheelPos.Skip(chunk);

            WheelPos newPos = dropPart.Concat(takePart);

            //return newPos.ToList();
            return newPos;
        }

        // static WheelLoop buildWheelLoop 
        static IEnumerable<WheelPos> buildWheelLoop 
            (IEnumerable<WheelPos> positions, WheelPos pos, int count) {

            if (count == 0)
            {
                WheelPos [] listFromPos = { pos };

                var newPositions = positions.Concat(listFromPos);

                return newPositions;

                //positions.Concat(listFromPos);

                //return positions;

            }




            //WheelLoop w = null;
            IEnumerable<WheelPos> w = null;

            return w;
        }

    }

    
}
