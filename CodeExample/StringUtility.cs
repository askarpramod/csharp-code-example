using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    public static class StringUtility
    {
        /// <summary>
        /// Given an array of strings ["eat","tea","tan","ate","nat","bat"], group the anagrams together. Result can be returned in any order, as example: [["bat"],["nat","tan"],["ate","eat","tea"]]
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0) return new List<IList<string>>();

            Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();

            foreach (string s in strs)
            {
                // Sort each string
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                string sorted = new string(charArray);

                // Add to dictionary
                if (!anagramMap.ContainsKey(sorted))
                {
                    anagramMap[sorted] = new List<string>();
                }
                anagramMap[sorted].Add(s);
            }

            // Return the values of the dictionary as a list of lists
            return new List<IList<string>>(anagramMap.Values);
        }
    }
}

