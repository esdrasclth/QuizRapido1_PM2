using Microsoft.Maui.Controls;
using System;

namespace QuizRapido1_PM2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOperationClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Number1.Text, out double num1) && double.TryParse(Number2.Text, out double num2))
            {
                string operation = (string)((Button)sender).CommandParameter;
                double result = 0;

                switch (operation)
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "subtract":
                        result = num1 - num2;
                        break;
                    case "multiply":
                        result = num1 * num2;
                        break;
                    case "divide":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            await DisplayAlert("Error", "No se puede dividir por cero", "OK");
                            return;
                        }
                        break;
                }

                await Navigation.PushAsync(new ResultPage(result));
            }
            else
            {
                await DisplayAlert("Error", "Por favor, introduce números válidos.", "OK");
            }
        }
    }

}
