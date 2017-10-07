using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MadHacks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSave(){
            saveGoal.IsEnabled = true;
        }
    }
}
