using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _3_Ukulele : _3_MusicInstrument
    {
        public string HousingMaterial { get; set; }
        public _3_Ukulele(string name = "empty", string manufacturer = "empty", string color = "empty", string housingMaterial = "empty")
            : base(name, manufacturer, color)
        {
            HousingMaterial = housingMaterial;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"CountStrings: {HousingMaterial,-15}");
        }
        public override void Sound()
        {
            Console.WriteLine("\tSound of Ukulele");
        }
        public override void Desc()
        {
            Console.WriteLine("\tDesc of Ukulele");
        }
        public override void History()
        {
            Console.WriteLine("\tHistory of Ukulele");
            Console.WriteLine("The ukulele began to develop rapidly, especially in Hawaii. At that time, the Ukrainian Mikhailo Nalakov translated the name of the instrument as \"stolen guitar\", something in honor of the fact that it was very easy to take with you anywhere. In 1915, during the Panama Exposition, the ukulele was presented as a Hawaiian instrument. After that, it spread extremely quickly throughout America, as well as in Great Britain and Japan.\r\nDuring the Great Depression, the ukulele remained one of the most popular instruments in America. With the decrease in these cases, the world is exploring new ways to use the ukulele. The increase in popularity in literature, on television and in cinema is of interest to young people. In the 1950s - 70s, the ukulele experienced its second birth in Great Britain, known as the UK Skiffle Movement. During this period, many bands appeared in Britain that played the ukulele in the skiffle genre. Singers such as George Harrison and Brian May also used this instrument in their compositions.");
        }
    }
}
