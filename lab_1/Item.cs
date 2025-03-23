using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Item
    {
        // item parametres for knapsack problem
        int id;
        int weight;
        int value;
        float ratio;

        // constructor initializing the parameters
        public Item(int weight, int value, int id)
        {
            this.weight = weight;
            this.value = value;
            this.id = id;
            this.ratio = (float)value/(float)weight;
        }

        // getters
        public int getWeight() { return weight; }
        public int getValue() { return value; }
        public float getRatio() { return ratio; }
        public int getId() { return id; }
    }
}
