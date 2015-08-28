using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int[] scoreByFrame = new int[10];
            int strikeCount = 0;
            int turkeyCount = 0;

            var input = args[0];
            
            Console.Write("{0} was input",input);
            Dictionary<int, string[]> map = new Dictionary<int, string[]>();
            var frames = input.Split('-');
            if (frames.Count() != 10) throw new InvalidOperationException("Input must have 10 frames");
            for(int i = 0; i < frames.Count(); i++)
            {
                map.Add(i, frames[i].Split());
            }
            foreach(var key in map.Keys)
            {
                if(map[key].Count()==1)
                {
                    strikeCount++;
                    if (strikeCount > 3)
                    {
                        turkeyCount++;
                    }

                }
            }
        }
    }
}
