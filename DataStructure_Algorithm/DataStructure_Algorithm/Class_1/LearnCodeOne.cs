using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Class_1
{
    public class LearnCodeOne
    {
        public async Task<Dictionary<int, int>> ValuePairs()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            List<int> Datacode = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < Datacode.Count; i++)
            {
                if (Datacode[i] == 3)
                {
                    keyValuePairs.Add(i, Datacode[i]);
                    return keyValuePairs;
                }
            }
            return keyValuePairs;
        }
    }
}