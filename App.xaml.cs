namespace Staj_Projesi_Restoran_Yonetimi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new NavigationPage(new mainpage61());
        }

        //public static void Main()
        //{
        //    _ = MauiProgram.CreateMauiApp();
        //}
    }
}