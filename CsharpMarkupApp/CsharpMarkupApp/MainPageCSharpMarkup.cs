using CommunityToolkit.Maui.Markup;


namespace CsharpMarkupApp;

public class MainPageCSharpMarkup : ContentPage
{
    public MainPageCSharpMarkup()
    {
        var scrollView = new ScrollView();

        var verticalStackLayout = new VerticalStackLayout{
            Spacing = 25,
            Children =
            {
                new Label
                {
                    Text = "Hello World from C#"
                }
            }
        };
    }
}