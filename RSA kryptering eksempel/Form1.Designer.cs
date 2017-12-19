namespace RSA_kryptering_eksempel
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RSAp = new System.Windows.Forms.TextBox();
			this.RSAq = new System.Windows.Forms.TextBox();
			this.udregnRSA = new System.Windows.Forms.Button();
			this.primtalInterval = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RSAn = new System.Windows.Forms.TextBox();
			this.RSAe = new System.Windows.Forms.TextBox();
			this.RSAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.RSAc = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.RSAm = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.RSAPhiAfn = new System.Windows.Forms.TextBox();
			this.RSAPlaintext = new System.Windows.Forms.TextBox();
			this.RSACiphertext = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.RSADekrypteret = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.nulstilKnap = new System.Windows.Forms.Button();
			this.RSAPublicKrypteringsNoegle = new System.Windows.Forms.TextBox();
			this.RSAPrivateKrypteringsNoegle = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// RSAp
			// 
			this.RSAp.Location = new System.Drawing.Point(277, 73);
			this.RSAp.Name = "RSAp";
			this.RSAp.Size = new System.Drawing.Size(100, 20);
			this.RSAp.TabIndex = 0;
			// 
			// RSAq
			// 
			this.RSAq.Location = new System.Drawing.Point(277, 99);
			this.RSAq.Name = "RSAq";
			this.RSAq.Size = new System.Drawing.Size(100, 20);
			this.RSAq.TabIndex = 1;
			// 
			// udregnRSA
			// 
			this.udregnRSA.Location = new System.Drawing.Point(251, 125);
			this.udregnRSA.Name = "udregnRSA";
			this.udregnRSA.Size = new System.Drawing.Size(126, 23);
			this.udregnRSA.TabIndex = 2;
			this.udregnRSA.Text = "Udregn RSA kryptering";
			this.udregnRSA.UseVisualStyleBackColor = true;
			this.udregnRSA.Click += new System.EventHandler(this.udregnRSA_Click);
			// 
			// primtalInterval
			// 
			this.primtalInterval.Location = new System.Drawing.Point(12, 70);
			this.primtalInterval.Multiline = true;
			this.primtalInterval.Name = "primtalInterval";
			this.primtalInterval.Size = new System.Drawing.Size(206, 285);
			this.primtalInterval.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(244, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Vælg to primtal og skriv dem i kasserne";
			// 
			// RSAn
			// 
			this.RSAn.Location = new System.Drawing.Point(277, 190);
			this.RSAn.Name = "RSAn";
			this.RSAn.Size = new System.Drawing.Size(100, 20);
			this.RSAn.TabIndex = 7;
			// 
			// RSAe
			// 
			this.RSAe.Location = new System.Drawing.Point(277, 242);
			this.RSAe.Name = "RSAe";
			this.RSAe.Size = new System.Drawing.Size(100, 20);
			this.RSAe.TabIndex = 8;
			// 
			// RSAd
			// 
			this.RSAd.Location = new System.Drawing.Point(277, 268);
			this.RSAd.Name = "RSAd";
			this.RSAd.Size = new System.Drawing.Size(100, 20);
			this.RSAd.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(248, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "e";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(248, 268);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "d";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(250, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "p";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(248, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "q";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(248, 294);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "c";
			// 
			// RSAc
			// 
			this.RSAc.Location = new System.Drawing.Point(277, 294);
			this.RSAc.Name = "RSAc";
			this.RSAc.Size = new System.Drawing.Size(100, 20);
			this.RSAc.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(248, 320);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(15, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "m";
			// 
			// RSAm
			// 
			this.RSAm.Location = new System.Drawing.Point(277, 320);
			this.RSAm.Name = "RSAm";
			this.RSAm.Size = new System.Drawing.Size(100, 20);
			this.RSAm.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(234, 216);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 13);
			this.label9.TabIndex = 19;
			this.label9.Text = "Φ(n)";
			// 
			// RSAPhiAfn
			// 
			this.RSAPhiAfn.Location = new System.Drawing.Point(277, 216);
			this.RSAPhiAfn.Name = "RSAPhiAfn";
			this.RSAPhiAfn.Size = new System.Drawing.Size(100, 20);
			this.RSAPhiAfn.TabIndex = 20;
			// 
			// RSAPlaintext
			// 
			this.RSAPlaintext.Location = new System.Drawing.Point(451, 70);
			this.RSAPlaintext.Multiline = true;
			this.RSAPlaintext.Name = "RSAPlaintext";
			this.RSAPlaintext.Size = new System.Drawing.Size(205, 152);
			this.RSAPlaintext.TabIndex = 21;
			this.RSAPlaintext.TextChanged += new System.EventHandler(this.RSAPlaintext_TextChanged);
			// 
			// RSACiphertext
			// 
			this.RSACiphertext.Location = new System.Drawing.Point(451, 228);
			this.RSACiphertext.Multiline = true;
			this.RSACiphertext.Name = "RSACiphertext";
			this.RSACiphertext.Size = new System.Drawing.Size(205, 152);
			this.RSACiphertext.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(164, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "Vilkårlig RSA krypteringsalgoritme";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(448, 54);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "Plaintext - ikke krypteret";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(448, 383);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "Ciphertext - krypteret";
			// 
			// RSADekrypteret
			// 
			this.RSADekrypteret.Location = new System.Drawing.Point(662, 70);
			this.RSADekrypteret.Multiline = true;
			this.RSADekrypteret.Name = "RSADekrypteret";
			this.RSADekrypteret.Size = new System.Drawing.Size(147, 310);
			this.RSADekrypteret.TabIndex = 27;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(659, 54);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(116, 13);
			this.label13.TabIndex = 29;
			this.label13.Text = "Ciphertext - dekrypteret";
			// 
			// nulstilKnap
			// 
			this.nulstilKnap.Location = new System.Drawing.Point(277, 358);
			this.nulstilKnap.Name = "nulstilKnap";
			this.nulstilKnap.Size = new System.Drawing.Size(102, 23);
			this.nulstilKnap.TabIndex = 30;
			this.nulstilKnap.Text = "Nulstil kryptering";
			this.nulstilKnap.UseVisualStyleBackColor = true;
			this.nulstilKnap.Click += new System.EventHandler(this.nulstilKnap_Click);
			// 
			// RSAPublicKrypteringsNoegle
			// 
			this.RSAPublicKrypteringsNoegle.Location = new System.Drawing.Point(15, 362);
			this.RSAPublicKrypteringsNoegle.Name = "RSAPublicKrypteringsNoegle";
			this.RSAPublicKrypteringsNoegle.Size = new System.Drawing.Size(203, 20);
			this.RSAPublicKrypteringsNoegle.TabIndex = 32;
			// 
			// RSAPrivateKrypteringsNoegle
			// 
			this.RSAPrivateKrypteringsNoegle.Location = new System.Drawing.Point(15, 388);
			this.RSAPrivateKrypteringsNoegle.Name = "RSAPrivateKrypteringsNoegle";
			this.RSAPrivateKrypteringsNoegle.Size = new System.Drawing.Size(203, 20);
			this.RSAPrivateKrypteringsNoegle.TabIndex = 33;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 434);
			this.Controls.Add(this.RSAPrivateKrypteringsNoegle);
			this.Controls.Add(this.RSAPublicKrypteringsNoegle);
			this.Controls.Add(this.nulstilKnap);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.RSADekrypteret);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.RSACiphertext);
			this.Controls.Add(this.RSAPlaintext);
			this.Controls.Add(this.RSAPhiAfn);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.RSAm);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.RSAc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.RSAd);
			this.Controls.Add(this.RSAe);
			this.Controls.Add(this.RSAn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.primtalInterval);
			this.Controls.Add(this.udregnRSA);
			this.Controls.Add(this.RSAq);
			this.Controls.Add(this.RSAp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox RSAp;
		private System.Windows.Forms.TextBox RSAq;
		private System.Windows.Forms.Button udregnRSA;
		private System.Windows.Forms.TextBox primtalInterval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RSAn;
		private System.Windows.Forms.TextBox RSAe;
		private System.Windows.Forms.TextBox RSAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox RSAc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox RSAm;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox RSAPhiAfn;
		private System.Windows.Forms.TextBox RSAPlaintext;
		private System.Windows.Forms.TextBox RSACiphertext;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox RSADekrypteret;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button nulstilKnap;
		private System.Windows.Forms.TextBox RSAPublicKrypteringsNoegle;
		private System.Windows.Forms.TextBox RSAPrivateKrypteringsNoegle;
	}
}

