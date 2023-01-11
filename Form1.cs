using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */

		void Odatolt(double fok, double méret, Color szín)
		{
			using (new Rajzol(false))
			{
				Jobbra(fok);
				Előre(méret);
				Tölt(szín, false);
				Hátra(méret);
				Balra(fok);
			}


		}
		void Haromszog(double meret, Color szin)
		{
			Tollat(le);
			for (int i = 0; i < 3; i++)
			{
				Előre(meret);
				Jobbra(120);
			}
			Odatolt(30, meret / 2, szin);

		}

		void Teglalap(double a, double b)
		{
			Ismétlés(2, delegate
			{
				Előre(a);
				Jobbra(90);
				Előre(b);
				Jobbra(90);
			});

			Odatolt(45, (a<b ? a/2 : b/2), Color.Yellow);
		}

		void Hatszog(double meret)
		{
			for (int i = 0; i < 6; i++)
			{
				Előre(meret);
				Jobbra(60);
			}

			Odatolt(60, meret, Color.Green);
		}

		void Korong(double b)
		{
			double a = b / 2;
			for (int i = 0; i < 3; i++)
			{
				Teglalap(a, b);
				Előre(a);
				Jobbra(30);
				Haromszog(b, Color.Red);
				Előre(b);
				Jobbra(30);
				Teglalap(a, b);
				Előre(a);
				Jobbra(30);
				Haromszog(b, Color.Blue);
				Előre(b);
				Jobbra(30);
			}
			Jobbra(90);
			Előre(b);
			Odatolt(0, a, Color.Green);
			Hátra(b);
			Balra(90);
		}



		void Korongsor(int db, double meret)
		{
			for (int i = 0; i < db; i++)
			{
				Korong(meret);
				Jobbramenetel(meret);
			}
			for (int i = 0; i < db; i++)
			{
				Balramenetel(meret);
			}
		}

		void Mozaik(int sordb, int oszlopdb, double meret)
		{

		}

		void Jobbramenetel(double meret)
		{ 

		}

		void Balramenetel(double meret)
		{

		}

		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			// Teleport(közép.X, közép.Y+150, észak);

			Korong(100);

		}
	}
}
