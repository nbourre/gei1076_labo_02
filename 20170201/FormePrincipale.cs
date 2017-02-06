using System;
using System.Drawing;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

using gei1076_tools;

namespace _20170201
{
    public partial class frmPrincipale : Form
    {
        PortSerie ps;

        public frmPrincipale()
        {
            InitializeComponent();

            ps = spc_config.getPS();
        }

        
        
        private Series seriesTension = null;

        private const int tailleTableau = 512;
        private Byte[] tableau = new byte[tailleTableau + 1];
        private const int tailleVy = tailleTableau >> 1;
        private int[] vy = new int[tailleVy];
        private int indice = 0;
        private int decalage = 0;


        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            chtEcran.Titles.Add("Valeur de tension");
            chtEcran.ChartAreas[0].AxisY.Minimum = 0;
            chtEcran.ChartAreas[0].AxisY.Maximum = 3.3;

            if (seriesTension != null) chtEcran.Series.Remove(seriesTension);

            seriesTension = chtEcran.Series.Add("V");
            seriesTension.ChartType = SeriesChartType.FastLine;
            seriesTension.Color = Color.Blue;

            seriesTension.Points.Clear();

            btnStartCapture.DataBindings.Add(new Binding("Enabled", ps, "Ouvert"));

        }

        private void clkMinuterie_Tick(object sender, EventArgs e)
        {
            clkMinuterie.Enabled = false;
            while (ps.DonneesALire() > tailleTableau)
            {
                ps.LireOctets(tableau, decalage, tailleTableau - decalage);
                int i = 0;
                while (i < tailleTableau - 1)
                {
                    if (tableau[i] <= 3)
                    {
                        vy[indice++] = (tableau[i] * 256 + tableau[i + 1]);
                        if (indice >= tailleVy)
                        {
                            indice = 0;
                            Affiche();
                        }
                        i += 2;
                    }
                    else
                        ++i;
                }
                if (i == tailleTableau - 1)
                {
                    tableau[0] = tableau[tailleTableau - 1];
                    decalage = 1;
                }
                else
                    decalage = 0;
            }
            clkMinuterie.Enabled = true;

        }

        private void Affiche()
        {
            for (int i = 0; i < tailleVy; i++)
            {
                if (seriesTension.Points.Count > tailleVy - 1)
                    seriesTension.Points.RemoveAt(0);
                seriesTension.Points.Add(vy[i] * 3.3 / 1024);
            }
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {


            clkMinuterie.Enabled = !clkMinuterie.Enabled;
            
            
            btnStartCapture.Text = clkMinuterie.Enabled ? "Arrêter" : "Démarrer";

            
            
        }
    }
}
