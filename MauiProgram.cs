namespace Staj_Projesi_Restoran_Yonetimi
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            _ = builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    _ = fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    _ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            //#if DEBUG
            //		builder.Logging.AddDebug();
            //#endif

            return builder.Build();
        }

        public static void Main(string[] args)
        {
            // CreateMauiApp metodunu çağırarak uygulamayı başlatın
            _ = CreateMauiApp();
        }
    }
}