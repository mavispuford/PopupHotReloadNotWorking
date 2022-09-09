using CommunityToolkit.Maui.Views;

namespace PopupHotReloadNotWorking;

public partial class TestPopup : Popup
{
    public TestPopup()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        Close();
    }
}

