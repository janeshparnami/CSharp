namespace Pg360
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Related to a different concept
            //TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            //IClown tallGuyInterfaceReference = new TallGuy() { Height = 90, Name = "Janesh" };
            //Console.Write(tallGuyInterfaceReference.FunnyThingIHave);
            //tallGuyInterfaceReference.Honk();
            ////THis does not work because the reference is of an interface.
            ////tallGuyInterfaceReference.TalkAboutYourself();

            //tallGuy.TalkAboutYourself();
            //Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            //tallGuy.Honk();

            //Interface references and inheriting interfaces
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            if(fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareLittleChildren();
            }
        }
    }
}