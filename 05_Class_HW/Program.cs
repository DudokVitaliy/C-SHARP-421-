namespace _05_Class_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyWebSite myWebSite = new MyWebSite() { SiteName = "zzzzzz", SiteUrl = "xxxxxxxxx", SiteDescription = "vvvvvvvvv", SiteIP = "bbbbbbb" };
            //MyWebSite myWebSite1 = new MyWebSite();
            //Console.WriteLine(myWebSite);
            //Console.WriteLine(myWebSite1);
            //MyWebSite filled = new MyWebSite();
            //filled.FillInfo();
            //Console.WriteLine(filled);

            Magazine magazine = new Magazine();
            magazine.FillInfo();
            Console.WriteLine(magazine);
            magazine.Description = "new descr";
            magazine.Year = 1;
            Console.WriteLine(magazine);
        }
    }
}
