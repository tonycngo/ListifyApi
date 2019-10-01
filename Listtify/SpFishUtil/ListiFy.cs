using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpFishUtil
{
    public class ListiFy
    {
        private readonly IEnumerable<int> _range;

        public ListiFy()
        {
        }

        public ListiFy(int start, int end)
        {
            _range = Enumerable.Range(start, end);
        }

        public int this[int index]
        {
            get { return _range.ToArray()[index]; }
        }
    }
}
