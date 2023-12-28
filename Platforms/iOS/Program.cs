using UIKit;

namespace Staj_Projesi_Restoran_Yonetimi.Platforms.iOS
{
    public class Program
    {
        // This is the main entry point of the application.
        private static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}