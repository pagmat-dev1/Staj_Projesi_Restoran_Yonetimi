namespace Staj_Projesi_Restoran_Yonetimi.Sayfalar;
using System;
using System.Threading.Tasks;
using Staj_Projesi_Restoran_Yonetimi.Fonksiyonlar;

public partial class Masalar : ContentPage
{
	public Masalar()
	{
		InitializeComponent();
	}
   
    public async Task Masa1_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("");


    }
}