namespace Staj_Projesi_Restoran_Yonetimi;

public partial class mainpage61 : ContentPage
{
    public mainpage61()
    {

        InitializeComponent();

    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (username == "admin" && password == "1234")
        {

            await Navigation.PushAsync(new MainPage());

        }
        else
        {

            await DisplayAlert("Uyarý", "Geçersiz kullanýcý adý veya þifre", "Tamam");

        }
    }
}