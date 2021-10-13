using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.LeetCode
{
    public class TwoSum
    {
        public  static int[] Sum(int[] nums, int target)
        {

            int[] result = new int[2];
            bool isFind = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {

                result[0] = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == result[0])
                    {
                        isFind = true;
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }

                if (isFind)
                    break;
            }

            return result;
        }

    }
}
