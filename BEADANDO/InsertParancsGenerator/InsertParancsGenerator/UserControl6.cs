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
    public partial class UserControl6 : UserControl
    {
        public BindingList<Modell> modellek;
        int id = 1;
        public UserControl6()
        {
            InitializeComponent();
            modellBindingSource.DataSource = modellek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modell m = new()
            {
                ModellID = id,
                Marka = textBox1.Text,
                Tipus = textBox3.Text,
                Felszereltseg = textBox4.Text
            };
            id++;
            modellek.Add(m);
            modellBindingSource.DataSource = modellek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in modellek)
                {
                    sw.WriteLine($"INSERT INTO Uzletkoto (modellid, marka, tipus, felszereltseg) VALUES ({i.ModellID}, {i.Marka}, {i.Tipus}, {i.Felszereltseg})");
                }

                sw.Close();
            }
        }
    }
}
