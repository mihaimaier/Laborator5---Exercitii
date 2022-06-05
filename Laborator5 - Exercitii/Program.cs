using System;

namespace Laborator5___Exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 5 - Exercitii

            //Exercitiu1();
            //Exercitiu2();
            //Exercitiu3();
            //Exercitiu4();
            //Exercitiu5();
            //Exercitiu6();
            //Exercitiu7();
            //Exercitiu8();

            // Sa nu uitati sa salvati in mod frecvent (Ctrl+S) pentru a nu pierde munca
            Console.ReadLine();
        }

        static void Exercitiu1()
        {
            //Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura.

            string input;
            string gasimSirul;
            Console.Write("Introduceti un sir de caractere:");
            input = Console.ReadLine();

            Console.Write("Introduceti un subsir care va fi gasit in sir: ");
            gasimSirul = Console.ReadLine();

            int index = input.IndexOf(gasimSirul);

            if (index < 0)
                Console.WriteLine("Subsirul nu a fost gasit in sirul dat \n");

            else
                Console.WriteLine("Am gasit '{0}' in sirul de caractere '{1}' pe pozitia {2}", gasimSirul, input, index);
        }

        static void Exercitiu2()
        {
            //Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom.

            string inputString, reverseString = string.Empty;
            Console.Write("Introduceti un sir de caractere: ");
            inputString = Console.ReadLine();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverseString += inputString[i].ToString();
            }
            if (reverseString == inputString)
            {
                Console.WriteLine("Sirul este Polindrom! Cuvantul introdus a fost {0} si cuvantul scris invers este: {1}", inputString, reverseString);
            }
            else
            {
                Console.WriteLine("Sirul nu este Polindrom! Cunvantul introdus a fost {0} si cuvantul scris invers este: {1}", inputString, reverseString);
            }
        }

        static void Exercitiu3()
        {
            //Scrieti un program care va numara toate aparitiile unui caracter intr - un sir de caractere.
            //Atat caracterul cautat cat si sirul de caracter vor fi citite de la tastatura.

            char caracter;
            string caractere;
            int i, frecventa = 0, flag = 0;

            Console.WriteLine("Introduceti un sir de caractere: ");
            caractere = Console.ReadLine();

            Console.WriteLine("Introduceti un caracter: ");
            caracter = char.Parse(Console.ReadLine());

            for (i = 0; i < caractere.Length; i++)
            {
                if (caractere[i] == caracter)
                {
                    flag = 1;
                    Console.WriteLine("Caracterul apare pe pozitia: " + (i + 1));
                    frecventa++;
                }
            }
            if (flag == 1)
                Console.WriteLine("Caracterul : {0} apare de {1} ori in sirul introdus: \n", caracter, frecventa);
            else
                Console.WriteLine("Caracterul nu a fost gasit");
        }

        static void Exercitiu4()
        {
            //Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr - un string citit de la tastatura, ignorand caseing-ul literelor.

            Console.WriteLine("Introduceti un sir de caractere: ");
            string caractere = Console.ReadLine();

            string caracteremici = caractere.ToLower();

            int[] charCount = new int[256];
            int length = caracteremici.Length;

            for (int i = 0; i < length; i++)
            {
                charCount[caracteremici[i]]++;
            }

            int numarMaxim = -1;
            char caracter = ' ';
            for (int i = 0; i < length; i++)
            {
                if (numarMaxim < charCount[caracteremici[i]])
                {
                    numarMaxim = charCount[caracteremici[i]];
                    caracter = caracteremici[i];
                }
            }
            Console.WriteLine("Caracterul cu cele mai multe aparitii este: {0}", caracter);
            Console.WriteLine("Caracterul a apartut de {0} ori. ", numarMaxim);
        }

        static void Exercitiu5()
        {
            //Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
            //sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.

            Console.WriteLine("Introduceti un sir de caractere: ");
            string caractere = Console.ReadLine();
            string litereMari = UppercasePrimaLitera(caractere);

            Console.WriteLine("Rezultatul este: " + litereMari);

            Console.ReadKey();
        }
        static string UppercasePrimaLitera(string caracter)
        {
            //Daca tot sirul de caractere I scris cu litere mari schimba in litere mici
            caracter = caracter.ToLower();
            char[] matritaCaractere = caracter.ToCharArray();

            // Schimbam prima litera din lowercase in Uppercase
            if (matritaCaractere.Length >= 1)
            {
                if (char.IsLower(matritaCaractere[0]))
                {
                    matritaCaractere[0] = char.ToUpper(matritaCaractere[0]);
                }
            }
            // Ne uitam prin sirul de caractere daca sunt spatii.
            //Schimbam in litera mare fiecare litera mica dupa un spatiu.
            for (int i = 1; i < matritaCaractere.Length; i++)
            {
                if (matritaCaractere[i - 1] == ' ')
                {
                    if (char.IsLower(matritaCaractere[i]))
                    {
                        matritaCaractere[i] = char.ToUpper(matritaCaractere[i]);
                    }
                }
            }
            return new string(matritaCaractere);
        }

        static void Exercitiu6()
        {
            //Screiti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura.

            string caractere;
            int i, lungime, vocala, consoana;

            Console.WriteLine("Introduceti un sir de caractere: ");
            caractere = Console.ReadLine();

            vocala = 0;
            consoana = 0;
            lungime = caractere.Length;

            for (i = 0; i < lungime; i++)
            {
                if (caractere[i] == 'a' || caractere[i] == 'e' || caractere[i] == 'i' || caractere[i] == 'o' || caractere[i] == 'u' || caractere[i] == 'A' || caractere[i] == 'E' || caractere[i] == 'I' || caractere[i] == 'O' || caractere[i] == 'U')
                {
                    vocala++;
                }
                else if ((caractere[i] >= 'a' && caractere[i] <= 'z') || (caractere[i] >= 'A' && caractere[i] <= 'Z'))
                {
                    consoana++;
                }
            }
            Console.WriteLine("Numarul total de vocale este: {0}", vocala);
            Console.WriteLine("Numarul total de consoane este: {0}", consoana);
        }

        static void Exercitiu7()
        {
            //Scrieti un program care va citi doua siruri de caractere de la tastatura si va verifica daca cele doua siruri de caractere sunt anagrame.

            //O anagrama unui sir este un alt sir care contine aceleasi caractere, doar ordinea caracterelor poate fi diferita.

            Console.WriteLine("Introduceti primul sir de caractere ");
            string sir1 = Console.ReadLine();

            Console.WriteLine("Introduceti al doilea sir de caractere: ");
            string sir2 = Console.ReadLine();

            //Convertim sirul in matrice de caractere, schimba sirul in litere mici.

            char[] matritaCaractere1 = sir1.ToLower().ToCharArray();
            char[] matritaCaractere2 = sir2.ToLower().ToCharArray();

            //Sortam amandoua matritele de caractere.

            Array.Sort(matritaCaractere1);
            Array.Sort(matritaCaractere2);

            //Convertim matritele inapoi in siruri de caractere si folosim o variabila noua.

            string sirNou1 = new string(matritaCaractere1);
            string sirNou2 = new string(matritaCaractere2);

            //Comparam amandoua siruri de caractere si daca amandoua siruri sunt aceleasi inseama ca cele doua siruri sunt anagrame.
            //Daca amandoua siruri de caractere nu sunt aceleasi, inseamna ca cele doua siruri nu sunt anagrame.

            if (sirNou1 == sirNou2)
                Console.WriteLine("Cele doua siruri de caractere sunt anagrame.");
            else
                Console.WriteLine("Cele doua siruri de caractere nu sunt anagrame.");
            Console.ReadLine();
        }

        static void Exercitiu8()
        {
            //Scrieti un program care va citi de la tastatura un numar n de elevi. 
            //Elevii vor avea nume, prenume precum si un numar de note m specific fiecarui elev si citit si el de la tastatura.
            //Notele fiecarui elev vor fi la randul lor citite de la tastatura.
            //Programul va afisa informatiile elevului cu media cea mai mare nume, prenume ,medie generala.

            int numarElevi = 0, i = 0, m = 0, notaMare = 0;
            string nume = "", numeNotaMare = "";
            string prenume = "", prenumeNotMare = "";

            Console.WriteLine("Numar de elevi: ");

            numarElevi = Convert.ToInt32(Console.ReadLine());
            {
                for (i = 1; i <= numarElevi; i++)
                {
                    Console.WriteLine("Introduceti Nume: ");
                    nume = Console.ReadLine();
                    Console.WriteLine("Introduceti Prenume: ");
                    prenume = (Console.ReadLine());
                    Console.WriteLine("Introduceti Nota: ");
                    m = Convert.ToInt32(Console.ReadLine());

                    if (m > notaMare)
                    {
                        notaMare = m;
                        numeNotaMare = nume;
                        prenumeNotMare = prenume;
                    }
                }
                Console.WriteLine("Studentul Nume: {0} Prenume: {1} are cea mai mare nota de: {2}", numeNotaMare, prenumeNotMare, notaMare);
            }
        }
    }
}



