using Staj_Projesi_Restoran_Yonetimi.Sayfalar;

namespace Staj_Projesi_Restoran_Yonetimi
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count += 2;

            CounterBtn.Text = count == 1 ? $"Clicked {count} time" : $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Hakkimizda());


            //await Shell.Current.GoToAsync("Hakkimizda");


        }

        //private void bt_Clicked_1(object sender, EventArgs e)
        //{
        //    string filePath = "C:\\Users\\umutdrms\\Desktop\\urun.json";
        //    string json = File.ReadAllText(filePath);
        //    JObject jsonObj = JObject.Parse(json);
        //    string urunValue = (string)jsonObj["urun_adi"];
        //    string urunValue1 = jsonObj["fiyat"].ToString();
        //    string urunValue2 = jsonObj["porsiyon"].ToString();
        //    urun.Text = urunValue;
        //    fiyat.Text = urunValue1;
        //    porsiyon.Text = urunValue2;

        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Masalar());

            //await Shell.Current.GoToAsync("Masalar");
        }
    }
}
