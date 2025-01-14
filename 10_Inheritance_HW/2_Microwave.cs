using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _2_Microwave : _2_Device
    {
        public double Width { get; set; } = 0;
        public string Coating { get; set; } = "empty";
        public _2_Microwave(string name = "empty", string brand = "empty", string color = "empty", double width = 0, string coating = "empty")
            : base(name, brand, color)
        {
            Width = width;
            Coating = coating;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Width:: {Width}cm\t\tCoating:: {Coating}");
        }
        public override void Sound()
        {
            Console.WriteLine("This sound of MICROWAVE!");
        }
        public override void Desc()
        {
            Console.WriteLine("\tMicrowave Description:\nIn a microwave oven, only the product itself is heated. Food is heated under the influence of high-frequency waves. Microwaves, passing inside the product, effectively polarize water molecules. Under the influence of radiation, molecules are built along the lines of force of the electromagnetic field. The directed movement of molecules causes an increase in the temperature of the product throughout its volume. Microwaves, which penetrate the depth of the product by 2 - 3 cm, heat up water molecules. Already heated areas of the object transfer heat further and in this way the entire volume is heated.");
        }
    }
}
