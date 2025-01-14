using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _3_Violin : _3_MusicInstrument
    {
        public int CountStrings { get; set; }
        public _3_Violin(string name = "empty", string manufacturer = "empty", string color = "empty", int countStrings = 0)
            :base(name, manufacturer, color)
        {
            CountStrings = countStrings;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"CountStrings: {CountStrings,-15}");
        }
        public override void Sound()
        {
            Console.WriteLine("\tSound of Violin");
        }
        public override void Desc()
        {
            Console.WriteLine("\tDesc of Violin");
        }
        public override void History()
        {
            Console.WriteLine("\tHistory of Violin");
            Console.WriteLine("The prototypes of the violin were the Arab rebab and the German rota, the fusion of which formed the violin.\r\n\r\nIn the middle of the 16th century, the modern design of the violin was formed in northern Italy. Until the beginning of the 17th century, the Amati family in Italy was engaged in the manufacture of violins. The instruments were distinguished by excellent material and beautiful form. In general, Italy took a leading position in the manufacture of high-quality violins. At one time, they were engaged in Guarneri and Stradivari, whose instruments are valued at the highest level today.\r\n\r\nIt became a solo instrument in the 17th century. The first works written for it were “Romanesca per violino solo e basso” (Marini from Brescia, 1620) and “Capriccio stravagante” (Farin). The founder of artistic violin playing was A. Corelli, then Torelli, Tartini, Pietro Locatelli.");
        }
    }
}
