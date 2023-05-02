namespace Pg376Animals
{
    internal partial class Program
    {
        abstract class Canine : Animal
        {
            public bool BelongsToPack { get; protected set; } = false;
        }
    }
}