using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Result
    {
        // List of items' ID  which were put in knapsack
        public List<int> itemsId;  
        public int totalWeight;
        public int totalValue;

        public Result()
        {
            itemsId = new List<int>();
            totalWeight = 0;
            totalValue = 0;
        }
        public override string ToString()
        {
            string output = "Items ID included into a knapsack: ";
            output += string.Join(", ", itemsId) + System.Environment.NewLine;
            output += "Total value: " + totalValue + System.Environment.NewLine;
            output += "Total weight: " + totalWeight;
            return output;
          
        }



    }
}
