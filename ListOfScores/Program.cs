using System;
using System.Collections.Generic;

namespace ListOfScores
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new List<int>();
            //generic list of type-int... calling constructors?
            scores.Add(42);
            scores.Add(98);
            scores.Add(66);
            scores.Add(5);
            scores.Add(100);
            // we want to add all the ints of the generic list

            var fixedScores = scores.ToArray();
            var genericFixedScore = new List<int>(fixedScores);

            var Total = 0;
            //make a variable first!
            //foreach for when we have a collection of things and we want to look at some of them
            //need 'var' and 'in' in foreach loop. make up var and put the collection after 'in'
            foreach (var item in scores)
            {
                Total += item;
                //have to put cw on outside because we want all of the items. 
                //Put cw on inside of loop if we want individual items to show.
            }
            Console.WriteLine($"Total is {Total}.");


        }
    }
}
