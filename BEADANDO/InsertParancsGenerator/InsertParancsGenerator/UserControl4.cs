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
    public partial class UserControl4 : UserControl
    {
        public BindingList<Auto> autok;
        int id = 1;
        public UserControl4()
        {
            InitializeComponent();
            autoBindingSource.DataSource = autok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto a = new()
            {
                AutoID = id,
                Modell = int.Parse(textBox1.Text),                
                Meghajtas = int.Parse(textBox2.Text),
                Szin = textBox5.Text,
                Ar = int.Parse(textBox3.Text)
            };
            id++;
            autok.Add(a);
            autoBindingSource.DataSource = autok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in autok)
                {
                    sw.WriteLine($"INSERT INTO Autok (AutoID, Modell, Meghajtas, szin, Ar) VALUES ({i.AutoID}, {i.Modell}, {i.Meghajtas}, {i.Szin}, {i.Ar})");
                }

                sw.Close();
            }
        }
    }
}
