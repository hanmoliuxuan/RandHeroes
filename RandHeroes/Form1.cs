using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;
namespace RandHeroes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> heroeslist = new List<string>();

        private void rand_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i=rand.Next(heroeslist.Count);
            this.name.Text = heroeslist[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHeroes(Application.StartupPath+"/英雄池.txt");
        }
        public void LoadHeroes(string path)
        {
            StreamReader sr = new StreamReader(path);
            int length=int.Parse(sr.ReadLine().ToString());
            Debug.Print(length.ToString());
            for (int i = 0; i <length;i++)
            {
                heroeslist.Add(sr.ReadLine().ToString());
            }
        }
    }
}
