using Basic_derusting;

string input = "the sky is blue";

Console.WriteLine("reverse Words: " + stringManipulation.ReverseWordInString(input));
Console.WriteLine("reverse Vowels: " + stringManipulation.ReverseVowelsInString(input));

Console.WriteLine(stringManipulation.GreatestCommonSequenceInString("ABABAB", "ABAB"));

Console.WriteLine("find non overlapping intervals: " + Intervals.FindNonOverlappingIntervals([[1, 2], [2, 3], [3, 4], [1, 3]]));