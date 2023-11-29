using Microsoft.VisualBasic;
using Staj_Projesi_Restoran_Yonetimi.Sayfalar;
using System.ComponentModel;
using System.Diagnostics;
using Newtonsoft.Json;
using System;
using System.IO;
using Microsoft.Maui.Controls;
using System.Reflection.Emit;
using Newtonsoft.Json.Linq;

namespace Staj_Projesi_Restoran_Yonetimi
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count = count + 2;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("hakkimizda");

        }


        private void bt_Clicked_1(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\umutdrms\\Desktop\\urun.json";
            string json = File.ReadAllText(filePath);
            JObject jsonObj = JObject.Parse(json);
            string urunValue = (string)jsonObj["urun_adi"];
            string urunValue1 = jsonObj["fiyat"].ToString();
            string urunValue2 = jsonObj["porsiyon"].ToString();
            urun.Text = urunValue;
            fiyat.Text = urunValue1;
            porsiyon.Text = urunValue2;



        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("masalar");

        }


        


    }   
}
