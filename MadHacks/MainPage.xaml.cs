using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MadHacks
{
    public partial class MainPage : ContentPage
    {
        int step_goal;
        int mon_goal;
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSaveFit(){
            saveFitGoal.IsEnabled = true;
            string fit = fitnessGoal.Text;
            if (fit.Contains(",")){
                fit = fit.Replace(",", "");
            }
            step_goal = int.Parse(fit);
        }

        void OnSaveMoney(){
            saveMonGoal.IsEnabled = true;
            string money = budgetGoal.Text;
            if (money.Contains(","))
			{
                money = money.Replace(",", "");
			}
            if (money.Contains("$"))
			{
                money = money.Replace("$", "");
			}
            mon_goal = int.Parse(money);
        }

        async void OnNext() {
            await Navigation.PushAsync(new DisplayPage());
        }
    }
}
