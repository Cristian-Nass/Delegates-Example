namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo phpto)
        {
            System.Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo phpto)
        {
            System.Console.WriteLine("Apply contrast");
        }
        public void Resize(Photo phpto)
        {
            System.Console.WriteLine("Resoze Photo");
        }

    }
}
