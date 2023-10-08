using System;
using System.Net.Http.Headers;

using MagazinElectronice;

class program
{
    static void Main(string[] args)
    {
 
        int pret = 0;

        Produs produs = new Produs(pret);

        int numarProduse = Produs.GetNrProduse(); // fiind o variabila statica pot sa o accesez doar cu clasa nu cu copia clasei 
        // TOATE PRODUSELE DIN MAGAZIN 
        Bec bec = new Bec(25);

        Televizor tv = new Televizor("SLIM", "SAMSUNG", 10000);

        Televizor tv1 = new Televizor("SLIM", "LG", 10000);

        int numarTv = Televizor.GetnumarProduseTelevizoare();

        Telefon telefon = new Telefon("TOUCHSCREEN", "IPHONE", 1700);

        int numarTelefon = Telefon.GetNumarTelefoane();

        Telefon telefon1 = new Telefon("TOUCHSCREEN", "MOTOROLA", 1700);

        Telefon telefon2 = new Telefon("BUTOANE", "NOKIA", 1700);

        bool iesire = false;
        while (!iesire)
        {

            Console.WriteLine("Meniu:");
            Console.WriteLine("1.Ati  intrat in magazin ?");
            Console.WriteLine("2. Achizitionare produs ");
            Console.WriteLine("3.Ati plecat din magazin ?");
            Console.WriteLine("4.Cate produse sunt in stoc per total in magazin");

            Console.WriteLine("Selectati optiunea pe care o doriti !!!");
            string optiune = Console.ReadLine();

            string raspuns = "";
            switch (optiune)
            {
                case "1":
                    Console.WriteLine("Confirmare intrare in magazin DA/NU");


                    raspuns = Console.ReadLine();
                    raspuns = raspuns.ToUpper();
                    if (raspuns == "DA")
                    {
                        bec.Aprinde();
                        tv.Porneste();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "2":

                    Console.WriteLine("Ce doriti sa achizitionati ?");
                    string optiuni = Console.ReadLine();
                    optiuni = optiuni.ToUpper();

                    CasaDeMarcat vanzari = new CasaDeMarcat();


                    switch (optiuni)
                    {
                        case "TELEVIZOR":

                            Console.WriteLine($"In magazin sunt pe stoc {numarTv} televizoare");

                            Console.WriteLine("Tastati de la ce producator doriti=");
                            string marca = Console.ReadLine();
                            marca = marca.ToUpper();

                            switch (marca)
                            {
                                case "SAMSUNG":

                                    Console.WriteLine($"Televizorul are marca {tv.Producator} , modelul = {tv.Model} si pretul de = {tv.Pret}");
                                    Console.WriteLine("Doriti sa achizitionati produsul (DA/NU) ?");
                                    string raspuns1 = Console.ReadLine();
                                    raspuns1 = raspuns1.ToUpper();
                                    if (raspuns1 == "DA")
                                    {
                                        vanzari.IncasareProdus(tv);

                                        Console.WriteLine($"Pe stoc mai sunt {numarTv - 1} televizoare ");

                                    }
                                    break;

                                case "LG":
                                    Console.WriteLine($"Televizorul are marca {tv1.Producator} , modelul = {tv1.Model} si pretul de = {tv1.Pret}");
                                    Console.WriteLine("Doriti sa achizitionati produsul (DA/NU) ?");
                                    string raspuns2 = Console.ReadLine();
                                    raspuns2 = raspuns2.ToUpper();
                                    if (raspuns2 == "DA")
                                    {
                                        vanzari.IncasareProdus(tv1);

                                        Console.WriteLine($"Pe stoc mai sunt {numarTv - 1} televizoare ");

                                    }

                                    break;

                                default:
                                    Console.WriteLine(marca + "nu se afla in stoc sau nu exista in magazin");
                                    break;

                            }
                            break;


                        case "TELEFON":

                            Console.WriteLine($"In magazin sunt pe stoc {numarTelefon} telefoane ");

                            Console.WriteLine("Tastati de la ce producator doriti=");
                            string marcaTelefon = Console.ReadLine();
                            marcaTelefon = marcaTelefon.ToUpper();

                            switch (marcaTelefon)
                            {
                                case "IPHONE":
                                    Console.WriteLine($"Telefonul are marca {telefon.Producator},modelul = {telefon.Model} si pretul de = {telefon.Pret} RON");
                                    Console.WriteLine("Doriti sa achizitionati produsul ?");
                                    string raspuns3 = Console.ReadLine();
                                    raspuns3 = raspuns3.ToUpper();
                                    if (raspuns3 == "DA")
                                    {
                                        vanzari.IncasareProdus(telefon);

                                        Console.WriteLine($"Pe stoc mai sunt {numarTelefon - 1} telefoane ");
                                    }

                                    break;
                                case "MOTOROLA":
                                    Console.WriteLine($"Telefonul are marca {telefon1.Producator},modelul = {telefon1.Model} si pretul de = {telefon1.Pret} RON");
                                    Console.WriteLine("Doriti sa achizitionati produsul ?");
                                    string raspuns4 = Console.ReadLine();
                                    raspuns4 = raspuns4.ToUpper();
                                    if (raspuns4 == "DA")
                                    {
                                        vanzari.IncasareProdus(telefon1);

                                        Console.WriteLine($"Pe stoc mai sunt {numarTelefon - 1} telefoane ");
                                    }

                                    break;
                                case "NOKIA":
                                    Console.WriteLine($"Telefonul are marca {telefon2.Producator},modelul = {telefon2.Model} si pretul de = {telefon2.Pret} RON");
                                    Console.WriteLine("Doriti sa achizitionati produsul ?");
                                    raspuns4 = Console.ReadLine();
                                    raspuns4 = raspuns4.ToUpper();
                                    if (raspuns4 == "DA")
                                    {
                                        vanzari.IncasareProdus(telefon2);

                                        Console.WriteLine($"Pe stoc mai sunt {numarTelefon - 1} telefoane ");
                                    }
                                    break;
                                default:
                                    Console.WriteLine(marcaTelefon + "Nu este pe stoc sau nu exista in magazin");
                                    break;

                            }
                            break;


                        case "3":
                            if (raspuns == "NU")
                            {
                                bec.Stinge();
                                tv.Opreste();
                            }
                            break;


                        case "4":
                            Console.WriteLine("In magazin sunt " + numarProduse + " produse");
                            break;
                    }
                    break;

            }
        }
    }
}



