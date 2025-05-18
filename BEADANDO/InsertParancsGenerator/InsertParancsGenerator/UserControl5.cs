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
    public partial class UserControl5 : UserControl
    {
        public BindingList<Vetel> vetelek;
        int id = 1;
        public UserControl5()
        {
            InitializeComponent();
            vetelBindingSource.DataSource = vetelek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in vetelek)
                {
                    sw.WriteLine($"INSERT INTO Vetel (VetelID, Vevo, Uzletkoto, Kocsi, Datum, FizetesiMod) VALUES ({i.VetelID}, {i.Vevo}, {i.Uzletkoto}, {i.Kocsi}, {i.Datum}, {i.FizetesiMod})");
                }

                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vetel v = new Vetel()
            {
                VetelID = id,
                Vevo = int.Parse(textBox1.Text),
                Uzletkoto = int.Parse(textBox2.Text),
                Kocsi = int.Parse(textBox3.Text),
                Datum = textBox4.Text,
                FizetesiMod = textBox5.Text
            };
            id++;
            vetelek.Add(v);
            vetelBindingSource.DataSource = vetelek;
        }
    }
}
