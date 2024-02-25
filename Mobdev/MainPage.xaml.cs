namespace Mobdev
{
    public partial class MainPage : ContentPage
    {
        bool success = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SignUpButtonClicked(object sender, EventArgs e) {
            string firstName = FirstNameEntry.Text;
            string lastName = LastNameEntry.Text;
            string userName = Username.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(confirmPassword) || password != confirmPassword )
            {
                await DisplayAlert("Passwords Do Not Match.", " ", "OK");
            }
            else if(success)
            {
                await Navigation.PushAsync(new Success(userName));
            }
            else
            {
                await DisplayAlert("Requirements not met", " ", "OK");
            }
        }

        /*
        private async void OnAlreadyHaveAccountTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        */
        private void TestPassword(Object sender,TextChangedEventArgs args)
        {
            Entry entry = sender as Entry;
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string number = "0123456789";
            bool flag = true ,uc=false,lc=false,num=false;
            flag = entry.Text.Length < 8 ? false : flag;
            for (int i = 0; i < entry.Text.Length ; i++)
            {
                char currentChar = entry.Text[i];
                uc |= upper.Contains(currentChar); 
                lc |= lower.Contains(currentChar); 
                num |= number.Contains(currentChar);
            }
            if (flag && uc && lc && num)
            {
                passval.IsVisible = false;
                success = true;
            }
            else
            {
                passval.IsVisible = true;
                success = false;
            }
        }
    }
}

