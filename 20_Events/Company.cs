using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events
{
    delegate void PositionDelegate(string description); // 1) Визначаємо делегат для події
    internal class Company
    {
        public string Name { get; set; }
        public event PositionDelegate NewPosition; // 2) подія = делегат
        public void AddPosition(string description) // 3) бізнес логіка
        {
            // 4) виклик події
            NewPosition?.Invoke(description);
        }
    }
}
