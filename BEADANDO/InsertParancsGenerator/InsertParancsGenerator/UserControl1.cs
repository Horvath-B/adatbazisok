using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertParancsGenerator
{
    public partial class UserControl1 : UserControl
    {
        public BindingList<Vevo> vevok;
        int id = 1;
        public UserControl1()
        {
            InitializeComponent();
            vevoBindingSource.DataSource = vevok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vevo v = new Vevo()
            {
                VevoID = id,
                Nev = textBox2.Text,
                Telefonszam = textBox3.Text,
                Cim = textBox4.Text,
                Maganszemely = checkBox1.Checked
            };
            id++;
            vevok.Add(v);
            vevoBindingSource.DataSource = vevok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in vevok)
                {
                    int msz = 0;
                    if (i.Maganszemely) msz = 1;
                    sw.WriteLine($"INSERT INTO Vevo (vevoid, nev, telefonszam, cim, maganszemely) VALUES ({i.VevoID}, '{i.Nev}', '{i.Telefonszam}', '{i.Cim}', {msz})");
                }

                sw.Close();
            }
        }
    }
}
