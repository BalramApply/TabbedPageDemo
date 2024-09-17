namespace TabbedPageDemo;

public partial class BluePage : ContentPage
{
	public BluePage()
	{
		InitializeComponent();
		BackgroundColor = Colors.Blue;
		Title = "Blue Page";
		Content = new VerticalStackLayout
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Children = {
				new Label {HorizontalOptions = LayoutOptions.Center,
				VerticalOptions= LayoutOptions.Center,
				Text = "Blue Page", TextColor = Colors.White,
				FontFamily = "OpenSans_Semibold",
				FontSize = 40, FontAttributes = FontAttributes.Bold,
				}
			}
		};
	}
}