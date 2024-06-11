using Microsoft.Maui.Controls;

namespace QuizRapido1_PM2;

public partial class ResultPage : ContentPage
{
	public ResultPage(double result)
	{
        InitializeComponent();
        ResultLabel.Text = $"Resultado: {result}";
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}