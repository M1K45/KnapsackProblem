using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

[assembly:
InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]
namespace lab_1
{
    public class Problem // this class represents an instance of knapsack problem
    {
        // number of items 
        int numItems;

        // list of items 
        List <Item> items; 

        // for the needs of the project the values range is specyfied
        int minValue = 1;
        int maxValue = 10;
        
        // constructor creating the list of items with random weight and value
        public Problem (int n, int seed)
        {
            items = new List <Item> ();
            this.numItems = n;
            Random random = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                Item a = new Item(random.Next(minValue, maxValue), random.Next(minValue, maxValue), i);
                items.Add(a);

            }      
        }

        // Overriden method ToString() for returning the problem instance as a string 
        // using Console.WriteLine method
        public override string ToString()
        {
            string text = string.Empty;
           foreach (Item a in items)
            {
                text += ("Id: " + a.getId() + " Weight: " + a.getWeight().ToString()
                    + " Value: " + a.getValue().ToString() + System.Environment.NewLine);
            } 
           return text;
        }

       // Method using to solve the problem 
        public Result Solve(int capacity) { 
            if (capacity <= 0)
            {
                throw new ArgumentException("Weight of the backpack needs to be more than 0.");
            }
            // An instance of result 
            Result result = new Result();
            
            var sortedList = items.OrderByDescending(o =>  o.getRatio()).ToList();

            foreach (Item a in sortedList) {
                if (a.getWeight() <= capacity)
                {
                    result.itemsId.Add(a.getId());
                    result.totalValue += a.getValue();
                    result.totalWeight += a.getWeight();
                    capacity -= a.getWeight();
                }
                // if there is no more room, algorithm is finished
                else continue;
            }
            // there can be a option when the loop ends and there is still room in a knapsack
            // or it is perfeclty close
            return result;

        }

        


    }
}
