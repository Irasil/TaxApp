using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp.Models
{

    public class SharedData
    {
        private static readonly Lazy<SharedData> lazy = new(() => new SharedData());

        public static SharedData Instance => lazy.Value;

        public TaxCalc Data { get; set; }

        private SharedData()
        {
            Data = new TaxCalc();
        }
    }
    public class TaxCalc
    {
        public float Betrag { get; set; }
        public float BetragBrutto { get; set; }
        public float BetragNetto { get; set; }
        public float BetragUst { get; set; }
        public bool IstNetto { get; set; } = true;
        public float UstProzent { get; set; }

        public TaxCalc() {  }

       
        public void BerechneErgebnis()
        {

            if (IstNetto)
            {
                BetragBrutto = Betrag * (1 + UstProzent / 100);
                BetragUst = BetragBrutto - Betrag;
                BetragNetto = Betrag;

                
                float roundedValue = (float)Math.Round(BetragBrutto, 2, MidpointRounding.AwayFromZero);

                BetragBrutto = (float)Math.Round(roundedValue * 20) / 20;

            }
            else
            {
                BetragNetto = Betrag / (1 + UstProzent / 100);
                BetragUst = Betrag - BetragNetto;
                BetragBrutto = Betrag;

                float roundedValue = (float)Math.Round(BetragNetto, 2, MidpointRounding.AwayFromZero);

                BetragNetto = (float)Math.Round(roundedValue * 20) / 20;
            }
        }

        
    }
}
