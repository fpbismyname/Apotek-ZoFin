﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZoFin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Register(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BerandaPage());
        }
        private void Button_Clicked_Back_Register(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}