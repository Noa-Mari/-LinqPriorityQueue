using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqPriorityQueue
{
    public class PriorityQueue
    {
        List<(int priority, string item)> values = new List<(int priority, string item)>();

        public PriorityQueue()
        {

        }
        public void AddToQueue(int priority, string item)
        {
            values.Add((priority, item));
        }

        public string Extract()
        {
            (int priority, string item) first = values.OrderBy(x => x.priority).First();

            this.values = values.Where(x => x != first).ToList();

            return first.item;

        }

    }
}