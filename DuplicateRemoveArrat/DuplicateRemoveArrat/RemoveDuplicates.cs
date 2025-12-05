using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemoveArrat
{
    public class RemoveDuplicates
    {
        public int RemoveDuplicatesFromArray(int[] nums)
        {
            var uniqueElements = nums.Distinct().ToArray();

            int k = uniqueElements.Length;

            for (int i = 0; i < k; i++)
            {
                nums[i] = uniqueElements[i];
            }

            return k;
        }
    }
}
