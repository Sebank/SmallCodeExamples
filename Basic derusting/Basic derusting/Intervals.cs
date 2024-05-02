using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_derusting
{
    public static class Intervals
    {
        public static int FindNonOverlappingIntervals(List<int[]> intervals)
        {
            Dictionary<int, List<int>> indexOfConflicts = new Dictionary<int, List<int>>();

            for ( int i = 0; i < intervals.Count; i++ )
            {
                for ( int j = i + 1; j < intervals.Count; j++)
                {
                    /* Note that we have three cases, 
                     * when we consider two intervals [a, b], [c, d]
                     * a < b && b < c < d
                     * a < b < c && a < d < c
                     * a < b < c && c < d
                     * Alternatively we can check if both start and end
                     * is before or after start of the other interval
                     */
                    if ( !(intervals[i][0] <= intervals[j][0] &&
                           intervals[i][1] <= intervals[j][0]) 
                         && 
                         !(intervals[i][0] >= intervals[j][1] &&
                           intervals[i][1] >= intervals[j][1])
                       )
                    {
                        if(!indexOfConflicts.TryGetValue(i, out List<int> conflictsForI))
                        {
                            conflictsForI = new List<int>();
                            indexOfConflicts[i] = conflictsForI;
                        }
                        conflictsForI.Add(j);
                        if (!indexOfConflicts.TryGetValue(j, out List<int> conflictsForJ))
                        {
                            conflictsForJ = new List<int>();
                            indexOfConflicts[j] = conflictsForJ;
                        }
                        conflictsForJ.Add(i);
                    }

                }
            }
            return indexOfConflicts.Values.Min(e => e.Count);
        }
    }
}
