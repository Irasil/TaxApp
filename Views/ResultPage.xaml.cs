using TaxApp.Models;

namespace TaxApp.Views;

public partial class ResultPage : ContentPage
{
    public TaxCalc taxCalc { get; set; } = new TaxCalc();

    public ResultPage()
	{
		InitializeComponent();
        BindingContext = SharedData.Instance.Data;
    }
     void OnClicked(object sender, EventArgs args)
    {
        Shell.Current.GoToAsync("../../MainPage");
        //Wie Betrag auf Null setzen?
    }
}