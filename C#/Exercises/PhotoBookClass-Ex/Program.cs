namespace PhotoBookClass_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine(photoBook.ToString());
            Console.WriteLine(photoBook.GetNumberOfPages());

            PhotoBook photoBook1 = new PhotoBook(24);
            Console.WriteLine(photoBook1.ToString());
            Console.WriteLine(photoBook1.GetNumberOfPages());

            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.ToString());
            Console.WriteLine(bigPhotoBook.GetNumberOfPages());
        }
    }
}