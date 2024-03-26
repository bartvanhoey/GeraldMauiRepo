using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace SnackbarToastApp
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
            count++;

            string message;
            
            if (count == 1)
                message = $"Clicked {count} time";
            else
                message = $"Clicked {count} times";

            SemanticScreenReader.Announce(message);

            CounterBtn.Text = message;

            // Toast.Make(message, ToastDuration.Long, 30).Show();

            var snackbar = Snackbar.Make(message, () => DisplayAlert("Did you subsribe", "to my chanel yet?", "OK"), "YES!",
                TimeSpan.FromSeconds(10),
                new SnackbarOptions
                {
                    BackgroundColor = Colors.Red,
                    TextColor = Colors.White
                });

            snackbar.Show();
        }
    }

}
