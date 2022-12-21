using System.Globalization;

namespace CsevegesGUI
{
    
        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Beszelgetes
        {
            public DateTime Kezdet;
            public DateTime Veg;
            public string Kezdemenyezo;
            public string Fogado;
            public TimeSpan osszIdo => Veg - Kezdet;

            public Beszelgetes(string sor)
            {
                var dbok = sor.Split(';');
                Kezdet = DateTime.ParseExact(dbok[0], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
                Veg = DateTime.ParseExact(dbok[1], "yy.MM.dd-HH:mm:ss", CultureInfo.InvariantCulture);
                Kezdemenyezo = dbok[2];
                Fogado = dbok[3];
            }
        }
        List<Beszelgetes> BeszelgetesList = new List<Beszelgetes>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using StreamReader sr = new(@"csevegesek.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                BeszelgetesList.Add(new Beszelgetes(sr.ReadLine()));
            }
            
            foreach (var item in BeszelgetesList.OrderBy(x => x.Fogado))
            {
                if (!FogadoCMB.Items.Contains(item.Fogado))
                {
                    FogadoCMB.Items.Add(item.Fogado);
                }
            }
            foreach (var item in BeszelgetesList.OrderBy(y => y.Kezdemenyezo))
            {
                if (!KezdemenyezoCMB.Items.Contains(item.Kezdemenyezo))
                {
                    KezdemenyezoCMB.Items.Add(item.Kezdemenyezo);
                }
            }
            KezdemenyezoCMB.SelectedIndex = 0;
            FogadoCMB.SelectedIndex = FogadoCMB.Items.Count - 1;
        }

        private void KezdemenyezoCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTB.Clear();
            string kezdemenyezo = (string)KezdemenyezoCMB.SelectedItem;
            string fogado = (string)FogadoCMB.SelectedItem;
            int id = 1;
            foreach (var item in BeszelgetesList)
            {
                if (item.Kezdemenyezo == kezdemenyezo && item.Fogado == fogado)
                {
                    if (id > 1) RTB.Text += ("\n");
                    RTB.Text += ($"{id++}. {item.Kezdet.ToString("yy.MM.dd-HH:mm:ss")} --> {item.Veg.ToString("yy.MM.dd-HH:mm:ss")}");
                }
            }
            if (RTB.Text == "") RTB.Text = ("Nem történt beszélgetés.");
        }

        private void FogadoCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RTB.Clear();
            string kezdemenyezo = (string)KezdemenyezoCMB.SelectedItem;
            string fogado = (string)FogadoCMB.SelectedItem;
            int id = 1;
            foreach (var item in BeszelgetesList)
            {
                if (item.Kezdemenyezo == kezdemenyezo && item.Fogado == fogado)
                {
                    if (id > 1) RTB.Text += ("\n");
                    RTB.Text += ($"{id++}. {item.Kezdet.ToString("yy.MM.dd-HH:mm:ss")} --> {item.Veg.ToString("yy.MM.dd-HH:mm:ss")}");
                }
            }
            if (RTB.Text == "") RTB.Text = ("Nem történt beszélgetés.");
        }
    }
}