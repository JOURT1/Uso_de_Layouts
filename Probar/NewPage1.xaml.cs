namespace Probar;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage2());
    }
}