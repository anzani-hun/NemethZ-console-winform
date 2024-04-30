using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___WindowsForms
{
    public partial class Form1 : Form
    {
        //dinamikus lista létrehozása
        List<Dolgozo> dolgozok = new List<Dolgozo>();


        //adatbázis osztályt példányosítása, amiben a műveletek fognak végrehajtódni:
        Adatbazis db = new Adatbazis();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaFrissitese();          //generáltatjuk le alúlra
        }

        private void listaFrissitese()
        {
            listBox_dolgozok.Items.Clear();

            //osszes dolgozó lekérése:   és itt ezt generáltassuk le ||| és az adatbázis.cs-be generálja le
            dolgozok = db.getAllDolgozo();

            //tömbbe pakoljuk
            listBox_dolgozok.Items.AddRange(dolgozok.ToArray());
        }
    }
}
