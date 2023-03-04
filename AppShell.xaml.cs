using TaxApp.Views;

namespace TaxApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute($"{nameof(MainPage)}/{nameof(ResultPage)}", typeof(ResultPage));
    }

    
}
