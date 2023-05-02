namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing Current instance concept
            //CurrentInstance ci = new CurrentInstance(4);
            //Console.WriteLine(ci.ToString());
            //Console.WriteLine("Inside Main method, {0}", ci);
            //Console.ReadLine();

            //Testing constructor calling another constructor concept alias "Constructor chaining"
            //OneConstructorFromAnother ocfa = new OneConstructorFromAnother(40);
            //Console.ReadLine();

            //Tesing this as an object argument
            //ObjectArgument obarg = new ObjectArgument(10,20, "obarg");
            //ObjectArgument obarg1= new ObjectArgument(30,40, "obarg1");
            //obarg.Display();
            //obarg.Display(obarg1);


            //Testing the Indexer concept
            DeclareIndexer di = new DeclareIndexer();
            di[0] = "Ram";
            di[1] = "Shyam";
            di[2] = "Gopal";

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(di[i] + " ");
            }
        }
    }
}