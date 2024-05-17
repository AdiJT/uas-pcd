using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PCD
{
    public class HsvColorRange
    {
        public int[] Low { get; set; } = new int[3];
        public int[] High { get; set; } = new int[3];

        public HsvColorRange(int[] low, int[] high)
        {
            if(low.Length != 3 || high.Length != 3)
                throw new ArgumentException("Length not equal 3", nameof(low) + " or " + nameof(high));

            this.Low = low;
            this.High = high;
        }
    }
}
