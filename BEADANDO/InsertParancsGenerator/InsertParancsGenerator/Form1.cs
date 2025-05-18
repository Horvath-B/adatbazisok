using System.ComponentModel;

namespace InsertParancsGenerator
{
    public partial class Form1 : Form
    {
        BindingList<Vevo> vevok = new BindingList<Vevo>();
        BindingList<Uzletkoto> uzletkotok = new BindingList<Uzletkoto>();
        BindingList<Meghajtas> meghajtasok = new BindingList<Meghajtas>();
        BindingList<Auto> autok = new BindingList<Auto>();
        BindingList<Vetel> vetelek = new BindingList<Vetel>();
        BindingList<Modell> modellek = new BindingList<Modell>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            uc.vevok = vevok;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new UserControl2();
            uc.uzletkotok = uzletkotok;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 uc = new UserControl3();
            uc.meghajtas = meghajtasok;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl4 uc = new UserControl4();
            uc.autok = autok;
            uc.autok = autok;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControl5 uc = new UserControl5();
            uc.vetelek = vetelek;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in vevok)
                {
                    int msz = 0;
                    if (i.Maganszemely) msz = 1;
                    sw.WriteLine($"INSERT INTO Vevo (vevoid, nev, telefonszam, cim, maganszemely) VALUES ({i.VevoID}, {i.Nev}, {i.Telefonszam}, {i.Cim}, {msz})");
                }

                foreach (var i in uzletkotok)
                {
                    sw.WriteLine($"INSERT INTO Uzletkoto (uzletkotoid, nev, fizetes) VALUES ({i.UzletkotoID}, {i.Nev}, {i.Fizetes})");
                }

                foreach (var i in meghajtasok)
                {
                    sw.WriteLine($"INSERT INTO Meghajtas (meghajtasid, uzemanyag, fajta, tipus, hengerurtartalom, loero) VALUES ({i.MeghajtasID}, {i.Uzemanyag}, {i.Fajta}, {i.Tipus}, {i.Hengerurtartalom}, {i.Loero})");
                }

                foreach (var i in modellek)
                {
                    sw.WriteLine($"INSERT INTO Uzletkoto (modellid, marka, tipus, felszereltseg) VALUES ({i.ModellID}, {i.Marka}, {i.Tipus}, {i.Felszereltseg})");
                }

                foreach (var i in autok)
                {
                    sw.WriteLine($"INSERT INTO Autok (AutoID, Modell, Meghajtas, szin, Ar) VALUES ({i.AutoID}, {i.Modell}, {i.Meghajtas}, {i.Szin}, {i.Ar})");
                }

                foreach (var i in vetelek)
                {
                    sw.WriteLine($"INSERT INTO Vetel (VetelID, Vevo, Uzletkoto, Kocsi, Datum, FizetesiMod) VALUES ({i.VetelID}, {i.Vevo}, {i.Uzletkoto}, {i.Kocsi}, {i.Datum}, {i.FizetesiMod})");
                }

                sw.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserControl6 uc = new UserControl6();
            uc.modellek = modellek;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
