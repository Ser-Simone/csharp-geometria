using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeometry
{
	internal class Rettangolo
	{
		private int baseRettangolo;
		private int altezzaRettangolo;
		

	   // ----------- ISTANZA -----------
		public Rettangolo(int baseRettangolo, int altezzaRettangolo)
		{
			this.baseRettangolo = baseRettangolo;
			this.altezzaRettangolo = altezzaRettangolo;
		}

		// ---------- METODI -------------
		public int calcolaArea()
		{
			int Area = 0;
			Area = baseRettangolo * altezzaRettangolo;
			return Area;
		}
		public double calcolaPerimetro ()
		{
			double Perimetro = 0;
			Perimetro = (baseRettangolo + altezzaRettangolo) * 2;
			return Perimetro;
		}
		public void StampaRettangolo()
		{
			Console.WriteLine("----- Rettangolo -------");
			Console.WriteLine("base: " + baseRettangolo + " cm");
			Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
			Console.WriteLine("Perimetro: " + calcolaPerimetro() + " cm");
			Console.WriteLine("Area: " + calcolaArea() + " cm");
			Console.WriteLine("------------------");

		}
		public void Disegna()
		{

			Console.Write("  ");
			for (int i = 0; i<baseRettangolo; i++)
			{
				Console.Write("--");
			}
			Console.WriteLine("  ");
			for (int i = 0; i < altezzaRettangolo; i++)
			{
				Console.WriteLine(" | ");
			}
		}
	}
}
