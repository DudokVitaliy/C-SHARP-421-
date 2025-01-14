using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _3_Cello : _3_MusicInstrument
    {
        public string StringMaterial { get; set; }
        public _3_Cello(string name = "empty", string manufacturer = "empty", string color = "empty", string stringMaterial = "empty")
            : base(name, manufacturer, color)
        {
            StringMaterial = stringMaterial;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"CountStrings: {StringMaterial,-15}");
        }
        public override void Sound()
        {
            Console.WriteLine("\tSound of Cello");
        }
        public override void Desc()
        {
            Console.WriteLine("\tDesc of Cello");
        }
        public override void History()
        {
            Console.WriteLine("\tHistory of Cello");
            Console.WriteLine("The history of the cello coincides with the history of the violin. The ancestor of both instruments is the viola. In the history of music, a fairly strong belief has been established that this instrument traces its lineage to the ancient \"foot viola\", known as the viola da gamba. In contrast to the gamba, some varieties of the viola, and in particular, the viole d'amour, had a number of consonant \"harmonic\" strings under the fingerboard, tuned exactly to the main ones. The real \"bass viola\" with six strings did not have these consonant strings.\r\n\r\nHowever, one variety of the bass viola - the viola bastarda, received these \"consonant strings\", which happened much later and was never included in the rule for the gamba.\r\n\r\nThe appearance of the cello dates back to the turn of the 15th and early 16th centuries as a result of the long development of folk bowed instruments. Initially, it was used as a bass instrument in various ensembles, to accompany or sing a performance on an instrument of a higher register (violin, flute, etc.).\r\n\r\nUntil the 2nd half of the 17th century, it was called violoncino, Basso di Viola da braccio (Italian), Basse de violon (French), Ba Viol de Braccio (German), etc. There were numerous varieties of the cello. The instruments were made in different sizes (often large) and usually had the tuning U1, F, c, g (the most common tuning was a tone lower than the modern one).\r\n\r\nOne of the earliest references to the modern tuning is given (regarding the Bass Geig de Braccio) by M. Praetorius (\"Syntagma musicum\", Bd II, 1619). In the 16th-17th centuries, 5- and 6-string instruments of this type were also found.\r\n\r\nIn the history of the cello, only two famous masters who designed the cello are mentioned: Gasparo da Salo and Paolo Maggini.\r\n\r\nThey lived at the turn of the 16th - 17th centuries and the first of them was popularly credited with the honor of \"inventing\" the modern violin with four strings tuned in fifths, improving the violone, or viola double bass, and finally, creating the cello. The first masters who built the cello did not yet clearly represent the correct path in the development of the modern cello.\r\n\r\nThe modern form of the instrument was already added by Antonio Stradivari.\r\n\r\nIn the 17th-18th centuries in Italy, through the efforts of outstanding musical masters of the Italian schools (Niccolò Amati, Giuseppe Guarneri, Antonio Stradivari, Carlo Bergonzi, Domenico Montagniano, etc.), a classical model of the cello with a finally established body size was created.\r\n\r\nOnly at the beginning of the 18th century was the modern size of the cello firmly established (body length 750-768 mm; scale, i.e., the vibrating part of the string, - 690-705 mm). Great success in making the cello was achieved by the Russian master I. A. Batov (1767-1841) and modern masters E. A. Vitachek, T. F. Pidgirsky, G. N. Morozov, H. M. Frolov, Ya. I. Kosolapov, L. A. Gorshchikov. Also known are excellent cellos by French (J. B. Vilhem, M. Laber), German, Czech and Polish masters.\r\n\r\nAt the end of the 17th century, the first solo works for the cello appeared - sonatas and risquercari by Giovanna Gabriella. Apparently, the name \"cello\" was first used in the collection of sonatas by G. C. Arresta for 2 and 3 voices with the addition of a cello part, published in Venice in 1665. (\"con la parte del Violoncello a beneplacito\").\r\n\r\nBy the middle of the 18th century, the cello began to be used as a concert instrument, thanks to a brighter, fuller sound and an improving performance technique, finally replacing the viola da gamba from musical practice. The cello has become widespread as a solo instrument, a group of cellos is used in string and symphony orchestras, the cello is an obligatory member of a string quartet, in which it is the lowest (except for the double bass, which is sometimes used in it) of the instruments in terms of sound, and is also often used in other compositions of chamber ensembles. In the orchestral score, the cello part is written between the viola and double bass parts. The final affirmation of the cello as one of the leading instruments in music occurred in the 20th century through the efforts of the outstanding musician Pablo Casals. The development of schools of performance on this instrument led to the emergence of numerous virtuoso cellists who regularly perform solo concerts.");
        }
    }
}
