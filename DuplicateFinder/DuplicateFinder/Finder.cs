using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFinder
{
    public class Finder
    {
        public int GetDuplicate(int[] inputSequence)
        {
            return inputSequence.GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(x => x.Key)
                                .FirstOrDefault();
        }
    }
}
