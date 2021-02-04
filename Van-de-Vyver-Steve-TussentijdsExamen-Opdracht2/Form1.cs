using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Van_de_Vyver_Steve_TussentijdsExamen_Opdracht2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnBereken_Click(object sender, EventArgs e)
		{
			if (rbTwoDay.Checked)
			{
				try
				{
					TwoDayPackage twoDayPackage = new TwoDayPackage(txtVerzenderNaam.Text, txtVerzenderAdres.Text, txtBestemmingNaam.Text, txtBestemmingAdres.Text, double.Parse(txtGewichtInKg.Text), double.Parse(txtPrijsPerKg.Text), double.Parse(txtToeslagOfVasteKost.Text));
					txtTeBetalen.Text = twoDayPackage.VerzendingsKosten().ToString();
					MessageBox.Show(twoDayPackage.BerekeningVerzendingsKosten(), "Vrachtbrief");
				}
				catch (FormatException fex)
				{
					MessageBox.Show(fex.Message);
				}
				catch (CustomException cex)
				{
					MessageBox.Show(cex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else if(rbOvernight.Checked)
			{
				try
				{
					OvernightPackage overnightPackage = new OvernightPackage(txtVerzenderNaam.Text, txtVerzenderAdres.Text, txtBestemmingNaam.Text, txtBestemmingAdres.Text, double.Parse(txtGewichtInKg.Text), double.Parse(txtPrijsPerKg.Text), double.Parse(txtToeslagOfVasteKost.Text));
					txtTeBetalen.Text = overnightPackage.VerzendingsKosten().ToString();
					MessageBox.Show(overnightPackage.BerekeningVerzendingsKosten(), "Vrachtbrief");
				}
				catch (FormatException fex)
				{
					MessageBox.Show(fex.Message);
				}
				catch (CustomException cex)
				{
					MessageBox.Show(cex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnEinde_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void rbTwoDay_CheckedChanged(object sender, EventArgs e)
		{
			if (rbTwoDay.Checked)
			{
				lblSoortZending.Text = "Vaste Kost";
			}
		}

		private void rbOvernight_CheckedChanged(object sender, EventArgs e)
		{
			if (rbOvernight.Checked)
			{
				lblSoortZending.Text = "Toeslag per kg";
			}
		}
	}
}
