using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// mysql data használata
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GUI___WindowsForms
{
    class Adatbazis
    {
        //két osztályt berakni osztályváltozóba
        MySqlCommand SqlCommand = null;
        MySqlConnection connection = null;


        //konstruktor létrehozása paraméterek nélkül- pipákat kiszedni
        public Adatbazis()
        {
            //kapcsolat létrehozása
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "munkasok";

            //
            connection = new MySqlConnection(builder.ConnectionString);

            //adatkapcsolat tesztelése, kapcsolat ellenőrzése
            try
            {
                //kapcsolat nyitása és zárása metódus készítése - metódus generálása lent
                kapcsolatNyit();

                SqlCommand = connection.CreateCommand();

                kapcsolatZar();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }


        //ezt a form1.csben generáltattuk le a villanykortével
        internal List<Dolgozo> getAllDolgozo()
        {
            List<Dolgozo> dolgozos = new List<Dolgozo>();
            SqlCommand.CommandText = "SELECT * FROM `dolgozok`";
            kapcsolatNyit();
            using (MySqlDataReader dr = SqlCommand.ExecuteReader())
            {

                //whileban olvassuk ki az adatokat
                while (dr.Read())
                {
                    //egy egy rekord feldogozása történik.. azaz rekordonként.
                    Dolgozo dolgozo = new Dolgozo(dr.GetString("nev"), dr.GetString("neme"), dr.GetString("reszleg"), dr.GetInt32("belepesev"), dr.GetInt32("ber"));

                    //hozzáadás
                    dolgozos.Add(dolgozo);
                }
            }

            return dolgozos;
        }


        //kapcsolatZár metódus .....ha a kapcsolat nem egyenlő kapcsolat kapcsolat closed akkor
        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }   
        }



        //kapcsolatNyit metódus
        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
    }
}
