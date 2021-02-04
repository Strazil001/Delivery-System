using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Van_de_Vyver_Steve_TussentijdsExamen_Opdracht2
{
	class Package
	{
		public Package()
		{

		}
		public Package(string naamverzender, string adresverzender, string naambestemming, string verzenderbestemming, double gewichtkg, double prijskg)
		{
			this.VerzendNaam = naamverzender;
			this.Verzendadres = adresverzender;
			this.BestemmingsNaam = naambestemming;
			this.BestemmingsAdres = verzenderbestemming;
			this.Gewicht = gewichtkg;
			this.PrijsPerKg = prijskg;
		}
		private string _bestemmingsAdres;

		public string BestemmingsAdres
		{
			get => _bestemmingsAdres;
			set => _bestemmingsAdres = value;
		}
		private string _bestemmingsNaam;

		public string BestemmingsNaam
		{
			get => _bestemmingsNaam;
			set => _bestemmingsNaam = value;
		}
		private double _gewicht;

		public double Gewicht
		{
			get => _gewicht;
			set
			{
				if (value > 0)
				{
					_gewicht = value;
				}
				else
				{
					throw new CustomException("De tekstvakken 'gewicht', 'prijs per kg', 'vaste kost' of 'toeslag per kg' kunnen geen negatieve cijfers bevatten.");
				}
			}
		}
		private double _prijsPerKg;

		public double PrijsPerKg
		{
			get => _prijsPerKg;
			set 
			{
				if (value > 0)
				{
					_prijsPerKg = value;
				}
				else
				{
					throw new CustomException("De tekstvakken 'gewicht', 'prijs per kg', 'vaste kost' of 'toeslag per kg' kunnen geen negatieve cijfers bevatten.");
				}
			}
		}
		private string _verzendAdres;

		public string Verzendadres
		{
			get => _verzendAdres;
			set => _verzendAdres = value;
		}
		private string _verzendNaam;

		public string VerzendNaam
		{
			get => _verzendNaam;
			set => _verzendNaam = value;
		}
		public virtual string BerekeningVerzendingsKosten()
		{
			return $"Gegevens Verzending{Environment.NewLine}Verzender: {VerzendNaam}{Environment.NewLine}Bestemmeling: {BestemmingsAdres}{Environment.NewLine}Gewicht: {Gewicht}{Environment.NewLine}Te Betalen: {Gewicht} X {PrijsPerKg} = {VerzendingsKosten()}";
		}
		public virtual double VerzendingsKosten()
		{
			double totaal = Gewicht * PrijsPerKg;
			return totaal;
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
