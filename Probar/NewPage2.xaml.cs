namespace Probar;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void OnElementTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage3());
    }

}