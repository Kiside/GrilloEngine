namespace GrilloEngineEditor.GameProject;

public class EngineHub : ContentPage
{
	public EngineHub()
	{
		var label = new Label
		{
			Text = "Grillo Engine",
			Padding = new Thickness(20),
			VerticalTextAlignment = TextAlignment.Center,
			FontSize = 32
		};

		Content = new Grid()
		{
			RowDefinitions =
			{
				new RowDefinition { Height = new GridLength(50)}
			},
			Children =
			{
				label
			}
		};

		Grid.SetRow(label, 0);
		Grid.SetColumn(label, 0);
	}
}