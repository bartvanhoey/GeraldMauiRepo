using Plugin.LocalNotification;
using Plugin.LocalNotification.AndroidOption;

namespace LocalPushNotificationApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
        {
            await LocalNotificationCenter.Current.RequestNotificationPermission();
        }
        
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "Subscribe to my channel",
            Subtitle = "Hello",
            Description = "It's me",
            BadgeNumber = 42,
            Schedule = new NotificationRequestSchedule()
            {
                NotifyTime = DateTime.Now.AddSeconds(5),
                NotifyRepeatInterval = TimeSpan.FromSeconds(15)
            },
            // Android = new AndroidOptions()
            // {
            //     
            // };
        };

        await LocalNotificationCenter.Current.Show(request);


    }
}