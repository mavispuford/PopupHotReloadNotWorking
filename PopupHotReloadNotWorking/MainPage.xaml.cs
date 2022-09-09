using CommunityToolkit.Maui.Views;

namespace PopupHotReloadNotWorking;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
        this.ShowPopup(new TestPopup());
    }
}

