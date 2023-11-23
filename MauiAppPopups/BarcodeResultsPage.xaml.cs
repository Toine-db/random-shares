using CommunityToolkit.Maui.Views;

namespace MauiAppPopups;

public partial class BarcodeResultsPage : Popup
{
    public BarcodeResultsPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, System.EventArgs e)
    {
        this.Close();
    }
}