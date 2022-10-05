namespace MauiAppDemo;

[QueryProperty(nameof(NavigationData), NavigationDataParam)]
public partial class MainPage2 : ContentPage
{
    public const string NavigationDataParam = "NavigationDataParam";

    public MainPage2()
    {
        InitializeComponent();
    }

    public string NavigationData { get; set; }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        Label1.Text = $"Navigation data: {NavigationData ?? "Missing"}";
    }

    private async void OnNavigateClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//MainPage");
    }
}