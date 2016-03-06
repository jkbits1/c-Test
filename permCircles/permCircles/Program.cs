﻿using System;
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
            int[] pos1 = { 1, 2, 3, 4};
            int[] pos2 = { 5, 6, 7, 8 };
            var first = new List<int>(pos1);
            var second = new List<int>(pos2);

            //var tPart = turnWheel(first, 1);

            WheelPos [] items = {};

            var secLoop = buildWheelLoop(items, second, 
                //0
                second.Count() - 1
                );

            Console.WriteLine("Wheel loop");
            foreach (var pos in secLoop)
            {
                Console.WriteLine(pos);
                //Console.WriteLine(item.First());

                var posVals = pos.TakeWhile(x => true);

                Console.WriteLine("Wheel pos");
                foreach (var val in posVals)
                {
                    Console.Write(val);
                    Console.Write(" ");
                }
            }

            Console.WriteLine("done");

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
            IEnumerable<WheelPos> newPositions = null;

            if (count == 0)
            {
                Console.WriteLine("last pos of loop");

                WheelPos [] listFromPos = { pos };

                newPositions = positions.Concat(listFromPos);

                return newPositions;
            }

            Console.WriteLine("loop pos");

            WheelPos[] turn = { turnWheel(pos, count) };

            newPositions = positions.Concat(turn);                    
            //WheelLoop w = null;
            IEnumerable<WheelPos> w = buildWheelLoop(newPositions, pos, count - 1); ;

            return w;
        }

    }

    
}
