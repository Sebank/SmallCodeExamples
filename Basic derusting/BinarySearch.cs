using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_derusting
{
    public static class BinarySearch
    {
        public static int KthSmallestAmountWithSingleDenominationCombination(int[] ints, int k)
        {
            /* This is a weird one, the goal is to make a sorted list
             * based on multiples of the ints given, without duplicates.
             * We then want to find the k-th smallest element. 
             * 
             * For example ints = [2, 3, 5], k = 7 would result in 
             * [2, 3, 4, 5, 6 (2*3, 3*2), 8, 9, 10, ...]
             * Where the 7'th elm is 9.
             * 
             * Easy solution would be make list of one multiple, 
             * and check if contains when adding from other int. 
             * Alternatively use prime decomposition to imply 
             * which elms are not in list then sort. 
             * 
             * Harder solution, make list of one multiple, 
             * search through with binary search to check if new 
             * val is in list, if not add at given index. 
             */


            return 0;
        }
    }
}
