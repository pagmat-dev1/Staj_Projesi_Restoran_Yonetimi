namespace Staj_Projesi_Restoran_Yonetimi.Sayfalar;
using System;

public partial class Masalar : ContentPage
{
    public Masalar()
    {
        InitializeComponent();


    }

    private async void Masa1_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ConnectionString");
        //await Navigation.PushAsync(new ConnectionString());
    }
}

