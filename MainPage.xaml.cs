﻿using TaxApp.Models;
using TaxApp.Views;


namespace TaxApp;

public partial class MainPage : ContentPage
{

    
    
    public MainPage()
	{
		InitializeComponent();
        BindingContext = SharedData.Instance.Data;
        
    }

     void OnButtonClicked(object sender, EventArgs args)
    {
        ResultPage result = new ResultPage();

        string selectedValue = picker.SelectedItem?.ToString();
        if (selectedValue == null)
        {
             DisplayAlert("Error", "Bitte wählen Sie einen Prozentsatz", "OK");
            return;
        }
        if (selectedValue == "2.5 Prozent")
        {
            ((TaxCalc)BindingContext).UstProzent = 2.5f;
        }else if(selectedValue == "3.5 Prozent")
        {
            ((TaxCalc)BindingContext).UstProzent = 3.5f;
            
        }else if(selectedValue == "8 Prozent")
        {
            ((TaxCalc)BindingContext).UstProzent = 8f;        
        }

        var lol = ((TaxCalc)BindingContext).BetragBrutto;
        ((TaxCalc)BindingContext).BerechneErgebnis();
        Shell.Current.GoToAsync(nameof(ResultPage));
    }

}

