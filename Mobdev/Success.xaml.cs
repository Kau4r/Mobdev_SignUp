namespace Mobdev;

public partial class Success : ContentPage
{
    public Success(string Username)
    {
        InitializeComponent();

        WelcomeLabel.Text = $"Welcome {Username}!";

    }
}