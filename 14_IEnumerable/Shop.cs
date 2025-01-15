using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_IEnumerable
{
    internal class Shop : IEnumerable
    {
        private Item[] items = new Item[0];
        public void AddItem(Item item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            };
        }
        public IEnumerable<Item> GetReverse()
        {
            for (int i = items.Length - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }
        public IEnumerable<Item> GetLimitProduct(int LimitPrice)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Price <= LimitPrice)
                    yield return items[i];
            }
        }
    }
}
