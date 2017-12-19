using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace RSA_kryptering_eksempel
{


	public partial class Form1 : Form
	{

		char[] RSA = new char[46]
			{' ','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','Æ','Ø','Å',',','.','?','!','"','-','1','2','3','4','5','6','7','8','9','0'};


		Boolean primtalBooleanp = true;
		Boolean primtalBooleanq = true;
		double p = 0;
		double q = 0;
		double n = 0;
		double e = 2;
		double d = 2;
		double c = 0;
		double m = 0;
		double phiAfn = 0;
		int taellerPlaintext = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			findPrimtal();
		}

		void findPrimtal()
		{
			double z = 0;
			double prim = 1;
			for (double j = 1; j <= 1000; j++)
			{
				prim = 1;
				for (double i = 2; i < j; i++)
				{
					z = j % i;
					if (z == 0)
						prim = 0;
				}
				if (prim == 1)
				{
					primtalInterval.Text += " " + Convert.ToString(j);
				}
			}
		}

		private void udregnRSA_Click(object sender, EventArgs e)
		{
			if (RSAp.Text == "") MessageBox.Show("Skriv primtal i kasse p");
			if (RSAq.Text == "") { MessageBox.Show("Skriv primtal i q"); goto hopOver; }

			tjekPrimtal();
			if (primtalBooleanq == false || primtalBooleanp == false) goto hopOver;

			RSANoegle();
			hopOver:;
		}

		void tjekPrimtal()
		{
			int taeller = 0;
			string[] primtalString = primtalInterval.Text.Split(' ');
			int[] primtal = new int[primtalString.Length];

			while (taeller < (primtalString.Length - 1))
			{
				taeller++;
				primtal[taeller] = Convert.ToInt16(primtalString[taeller]);
			}
			taeller = 0;

			while (Convert.ToDouble(RSAp.Text) != primtal[taeller])
			{
				taeller++;

				if (taeller > (primtal.Length - 1))
				{
					MessageBox.Show("p er ikke et primtal mellem 1 og 1000");
					RSAp.Text = "";
					primtalBooleanp = false;
					break;
				}
				if (Convert.ToDouble(RSAp.Text) != primtal[taeller]) primtalBooleanp = true;
			}
			taeller = 0;

			while (Convert.ToDouble(RSAq.Text) != primtal[taeller])
			{
				taeller++;

				if (taeller > (primtal.Length - 1))
				{
					MessageBox.Show("q er ikke et primtal mellem 1 og 1000");
					RSAq.Text = "";
					primtalBooleanq = false;
					break;
				}
				if (Convert.ToDouble(RSAq.Text) != primtal[taeller]) primtalBooleanq = true;
			}
			taeller = 0;
		}

		void findRSAe()
		{
			double GCD(double a, double b) //https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor 
			{
				if (b == 0) return a;

				double r = a % b;

				return GCD(b, r);
			}

			while (e < phiAfn)
			{
				if (GCD(e, phiAfn) == 1) break; //http://www.geeksforgeeks.org/rsa-algorithm-cryptography/ 
				else e++;
			}
		}

		void RSAReset()
		{
			p = 0;
			q = 0;
			n = 0;
			e = 2;
			d = 2;
			c = 0;
			m = 0;
			phiAfn = 0;

			RSAPlaintext.Text = "";
			RSACiphertext.Text = "";
			RSADekrypteret.Text = "";
			RSAPhiAfn.Text = "";
			RSAn.Text = "";
			RSAe.Text = "";
			RSAd.Text = "";
			RSAc.Text = "";
			RSAm.Text = "";
		}

		void RSANoegle()
		{
			q = Convert.ToDouble(RSAq.Text);
			p = Convert.ToDouble(RSAp.Text);
			n = (p * q);
			phiAfn = (p - 1) * (q - 1);
			findRSAe();
			while (d < phiAfn && d * e % phiAfn != 1) d++;

			RSAPhiAfn.Text = Convert.ToString(phiAfn);
			RSAn.Text = Convert.ToString(n);
			RSAe.Text = Convert.ToString(e);
			RSAd.Text = Convert.ToString(d);
			RSAc.Text = "m^" + Convert.ToString(e) + " mod " + Convert.ToString(n);
			RSAm.Text = "c^" + Convert.ToString(d) + " mod " + Convert.ToString(n);
			RSAPublicKrypteringsNoegle.Text = "Public Key:" + "{ " + Convert.ToString(e) + "," + Convert.ToString(n) + "}";
			RSAPrivateKrypteringsNoegle.Text = "Private Key:" + "{ " + Convert.ToString(d) + "," + Convert.ToString(n) + "}";
		}

		private void nulstilKnap_Click(object sender, EventArgs e)
		{
			RSAReset();
		}

		void RSAKrypter()
		{
			RSAPlaintext.CharacterCasing = CharacterCasing.Upper;

			int taellerFindBogstav = 0;
				
			char[] plaintextArray = RSAPlaintext.Text.ToCharArray();
			taellerPlaintext = plaintextArray.Length-1;

			while (plaintextArray[taellerPlaintext] != RSA[taellerFindBogstav]) taellerFindBogstav++;

			m = taellerFindBogstav;

			c = ((Math.Pow(m, e)) % n);
			m = ((Math.Pow(c, d)) % n);

			RSADekrypteret.Text += Convert.ToString(m);
			RSACiphertext.Text += Convert.ToString(c);
			RSAc.Text = Convert.ToString(m) + "^" + Convert.ToString(e) + " mod " + Convert.ToString(n);
			RSAm.Text = Convert.ToString(c) + "^" + Convert.ToString(d) + " mod " + Convert.ToString(n);
		}

		private void RSAPlaintext_TextChanged(object sender, EventArgs e)
		{
			RSAKrypter();
		}
	}
}