using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MadHacks
{
    public partial class MainPage : ContentPage
    {
        int goal;
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSave(){
            saveGoal.IsEnabled = true;
            goal = int.Parse(fitnessGoal.ToString());
        }
    }
}
