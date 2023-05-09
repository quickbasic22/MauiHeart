namespace MauiHeart;

public partial class DynamicHandlers : ContentPage
{
	int Counter = 0;
	public DynamicHandlers()
	{
		InitializeComponent();
	}

	void refreshPage()
	{

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MyAbsolute.Children.Clear();
		Label MyLabel = new Label()
		{
			Text = Counter++.ToString(),
			TextColor = Colors.Purple,
			FontSize = 24.0,
		};
		AbsoluteLayout.SetLayoutBounds(MyLabel, new Rect(0.1, 0.2, 0.05, 0.05));
		AbsoluteLayout.SetLayoutFlags(MyLabel, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.All);

		Button MyButton = new Button()
		{
			Text = Counter.ToString() + " " + "Click to Clear",
			TextColor = Colors.Purple,
			FontSize = 24.0,
			BackgroundColor = Colors.Magenta,
			CornerRadius = 30,
		};
		MyButton.Clicked += Button_Clicked;

        AbsoluteLayout.SetLayoutBounds(MyButton, new Rect(0.1, 0.4, 250, 250));
        AbsoluteLayout.SetLayoutFlags(MyButton, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);

        MyAbsolute.Children.Add(MyLabel);
		MyAbsolute.Children.Add(MyButton);
    }
}