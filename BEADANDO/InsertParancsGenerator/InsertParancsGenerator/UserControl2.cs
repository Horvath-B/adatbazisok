using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace InsertParancsGenerator
{
    public partial class UserControl2 : UserControl
    {
        public BindingList<Uzletkoto> uzletkotok;
        int id = 1;
        public UserControl2()
        {
            InitializeComponent();
            uzletkotoBindingSource.DataSource = uzletkotok;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Uzletkoto u = new()
            {
                UzletkotoID = id,
                Nev = textBox3.Text.ToString(),
                Fizetes = int.Parse(textBox4.Text)
            };
            id++;
            uzletkotok.Add(u);
            uzletkotoBindingSource.DataSource = uzletkotok;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if (sfg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new(sfg.FileName);

                foreach (var i in uzletkotok)
                {
                    sw.WriteLine($"INSERT INTO Uzletkoto (uzletkotoid, nev, fizetes) VALUES ({i.UzletkotoID}, {i.Nev}, {i.Fizetes})");
                }

                sw.Close();
            }
        }
    }
}
