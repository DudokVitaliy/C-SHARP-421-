using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _3_Trombone : _3_MusicInstrument
    {
        public int CountStrings { get; set; }
        public _3_Trombone(string name = "empty", string manufacturer = "empty", string color = "empty", int countStrings = 0)
            : base(name, manufacturer, color)
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
            Console.WriteLine("\tSound of Trombone");
        }
        public override void Desc()
        {
            Console.WriteLine("\tDesc of Trombone");
        }
        public override void History()
        {
            Console.WriteLine("\tHistory of Trombone");
            Console.WriteLine("The direct predecessors of the trombone were the European low (bass) trumpets. As a result of improvement, they gradually took on a curved shape. And already in the 15th century, the instrument had a sliding slide and a narrow bell, which was also called a slide trumpet (zugtrompete). Initially, the slide was single, and at the beginning of the 16th century, it was double, which allowed the chromatic scale to be played. Thus, the trombone was the first brass instrument to become a chromatic instrument and has not undergone significant evolution since its inception. The mechanics and methods of playing it are practically the same as 400 years ago.");
        }
    }
}
