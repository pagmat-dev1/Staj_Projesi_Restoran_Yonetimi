﻿using Staj_Projesi_Restoran_Yonetimi.Sayfalar;


namespace Staj_Projesi_Restoran_Yonetimi
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("hakkimizda", typeof(hakkimizda));
            

        }
    }
}