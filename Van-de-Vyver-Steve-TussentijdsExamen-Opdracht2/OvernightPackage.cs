using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_de_Vyver_Steve_TussentijdsExamen_Opdracht2
{
	class OvernightPackage: Package
	{
		public OvernightPackage()
		{

		}
		public OvernightPackage(string naamverzender, string adresverzender, string naambestemming, string verzenderbestemming, double gewichtinkg, double prijsperkg, double toeslag)
		{
			this.VerzendNaam = naamverzender;
			this.Verzendadres = adresverzender;
			this.BestemmingsNaam = naambestemming;
			this.BestemmingsAdres = verzenderbestemming;
			this.Gewicht = gewichtinkg;
			this.PrijsPerKg = prijsperkg;
			this.ToeslagPerKg = toeslag;
		}
		private double _toeslagPerKg;

		public double ToeslagPerKg
		{
			get => _toeslagPerKg;
			set
			{
				if (value > 0)
				{
					_toeslagPerKg = value;
				}
				else
				{
					throw new CustomException("De tekstvakken 'gewicht', 'prijs per kg', 'vaste kost' of 'toeslag per kg' kunnen geen negatieve cijfers bevatten.");
				}
			}
		}
		public override string BerekeningVerzendingsKosten()
		{
			return base.BerekeningVerzendingsKosten() + $"{Environment.NewLine}Toeslag: {ToeslagPerKg}";
		}
		public override double VerzendingsKosten()
		{
			return base.VerzendingsKosten() + ToeslagPerKg;
		}
	}
}
