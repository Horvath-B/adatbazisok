using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace InsertParancsGenerator
{
    public partial class UserControl3 : UserControl
    {
        public BindingList<Meghajtas> meghajtas;
        int id = 1;
        public UserControl3()
        {
            InitializeComponent();
            meghajtasBindingSource.DataSource = meghajtas;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Meghajtas m = new Meghajtas()
            {
                MeghajtasID = id,
                Uzemanyag = textBox1.Text,
                Fajta = textBox2.Text,
                Tipus = textBox3.Text,
                Hengerurtartalom = int.Parse(textBox4.Text),
                Loero = int.Parse(textBox5.Text)
            };
            id++;
            meghajtas.Add(m);
            meghajtasBindingSource.DataSource = meghajtas;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in meghajtas)
                {
                    sw.WriteLine($"INSERT INTO Meghajtas (meghajtasid, uzemanyag, fajta, tipus, hengerurtartalom, loero) VALUES ({i.MeghajtasID}, '{i.Uzemanyag}', '{i.Fajta}', '{i.Tipus}', {i.Hengerurtartalom}, {i.Loero})");
                }

                sw.Close();
            }
        }
    }
}
