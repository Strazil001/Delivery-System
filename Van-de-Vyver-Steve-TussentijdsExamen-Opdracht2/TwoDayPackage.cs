using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_de_Vyver_Steve_TussentijdsExamen_Opdracht2
{
	class TwoDayPackage: Package
	{
		public TwoDayPackage()
		{

		}
		public TwoDayPackage(string naamverzender, string adresverzender, string naambestemming, string verzenderbestemming, double gewichtinkg, double prijsperkg, double vastekosteur)
		{
			this.VerzendNaam = naamverzender;
			this.Verzendadres = adresverzender;
			this.BestemmingsNaam = naambestemming;
			this.BestemmingsAdres = verzenderbestemming;
			this.Gewicht = gewichtinkg;
			this.PrijsPerKg = prijsperkg;
			this.VasteKost = vastekosteur;
		}
		private double _vastekost;

		public double VasteKost
		{
			get => _vastekost;
			set
			{
				if (value > 0)
				{
					_vastekost = value;
				}
				else
				{
					throw new CustomException("De tekstvakken 'gewicht', 'prijs per kg', 'vaste kost' of 'toeslag per kg' kunnen geen negatieve cijfers bevatten.");
				}
			}
		}
		public override string BerekeningVerzendingsKosten()
		{
			return base.BerekeningVerzendingsKosten() + $"{Environment.NewLine}Vaste Kost: {VasteKost}";
		}
		public override double VerzendingsKosten()
		{
			return base.VerzendingsKosten() + VasteKost;
		}
	}
}
