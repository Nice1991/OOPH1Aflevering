//Projekt_3, 1
global using OOPH1Aflevering.Codes1;
global using OOPH1Aflevering.Codes2;
global using System.ComponentModel;
#region QuizTest
//MotorKøretøj motorKøretøj = new MotorKøretøj();
//MotorKøretøj motorKøretøj = new Bil();
//MotorKøretøj motorKøretøj = new Audi();
//Audi audi = new Audi();
//Audi audi = new Bil();
//Audi audi = new MotorKøretøj()

//Console.Write("Angiv hestekræfter: ");
//int power = Convert.ToInt32(Console.ReadLine());

//Console.Write("Angiv mærke: ");
//string brand = Console.ReadLine();

//Console.Write("Angiv model: ");
//string model = Console.ReadLine();

//Bil bilen = new Bil { Mærke = brand, Model = model, HesteKræfter = power };

//Console.Clear();
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("----------------------------------------------------------");
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"Bilen er en {bilen.Mærke} {bilen.Model} med {bilen.HesteKræfter} hestekrafter.");
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("----------------------------------------------------------");
//Console.WriteLine();

//Console.ReadLine();
#endregion
#region Quiz
//Del 1.
//Spørgsmål 1:
//1 og 4 kan istantieres uden fejl.

//Spørgsmål 2:
//Ja, med yderligere kode.

//Spørgsmål 3:
//Nej.

//Del 2.
//Spørgsmål 1:
//List < Bil > bil = new()
//{
//    new Bil { Mærke = "Toyota", Model = "Aygo", HesteKræfter = 60 },
//    new Bil { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
//    new Bil { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
//};

//Spørgsmål 2:
//Bil b1 = bil.FirstOrDefault(a => a.HesteKræfter == 90);
//Bil b2 = bil.FirstOrDefault(a => a.HesteKræfter == 175);

//Console.WriteLine($"{b1.Mærke} {b1.Model}");
//Console.WriteLine($"{b2.Mærke} {b2.Model}");

// eller where LINQ

//List<Bil> biler = bil.Where(a => a.Hestekræfter > 60).ToList();
//foreach (Bil line in bil)
//{
//    if (line.Hestekræfter > 60)
//    {
//        Console.WriteLine(line.Mærke);
//    }
//}

//Spørgsmål 3:
//Bil b = Biler.FirstOrDefault(a => a.Mærke == "Audi");
//Console.WriteLine($"{b.Mærke}{b.Model}{b.HesteKræfter}");

//Del 3.
//Spørgsmål 1:
//?? = Biler.Where(...);

//Spørgsmål 2:
//?? = Biler.FirstOrDefault(...);
//?? = Biler.First(...)

//Spørgsmål 3:
//?? = Biler.Where(...);

//Spørgsmål 4:
//?? = Biler.First(...);

//Del 4.
//Spørgsmål 1:
//Abstrakt

//Del 5.
//Spørgsmål 1:
//Vi kan se at SetSyn har to metoder, deraf er den overloadet.
#endregion
if (Convert.ToString(Environment.OSVersion).Contains("Windows"))
{
    Console.SetWindowSize(61, 30);
}
SchoolingCategory school = new();
List<TECPerson> persons = new();
Course t = new(school);
returpunktstart:
while (true)
{
    //Start Menu
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Vælg uddannelseslinje");
    Console.WriteLine("1: Programmering");
    Console.WriteLine("2: Support");
    Console.WriteLine("3: Infrastruktur\n");
    Console.Write("Vælg 1, 2 eller 3: ");
returpunktmenu:
    var choice = Console.ReadKey(true);
    switch (choice.Key)
    {
        // Tast funktion for menuen. 
        case ConsoleKey.D1:
            t.SchoolingName = SchoolingCategory.Programmeringslinje;
            t.SetCourses();
            break;
        case ConsoleKey.D2:
            t.SchoolingName = SchoolingCategory.Supporterlinje;
            t.SetCourses();
            break;
        case ConsoleKey.D3:
            t.SchoolingName = SchoolingCategory.Infrastrukturlinje;
            t.SetCourses();
            break;
        default:
            goto returpunktmenu;
    }
    Console.Clear();
    //Udskriver tekst med passende farve på de udvalgte ord til skærm.
    if (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.D2 || choice.Key == ConsoleKey.D3)
    {
        Console.WriteLine(t.ToString());
        Console.WriteLine("------------------------------------------------------------");
        Console.Write("Fag og lærer tilhørende ");
        if (t.SchoolingName == SchoolingCategory.Programmeringslinje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Programmeringslinjen");
        }
        else if (t.SchoolingName == SchoolingCategory.Supporterlinje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Supporterlinjen");
        }
        else if (t.SchoolingName == SchoolingCategory.Infrastrukturlinje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Infrastrukturlinjen");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" er highlighted.");
        Console.WriteLine("------------------------------------------------------------");
        string temp2 = null;
        //Sorterer listen af fag og udskriver til skærm, med de udvalgte fag farvet.
        t.Courses.Sort();
        foreach (string temp in t.Courses)
        {
            if (t.SchoolingName == SchoolingCategory.Programmeringslinje && temp.Contains("Programmering"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                temp2 = temp.Replace("_", " ");
                Console.WriteLine(temp2);
            }
            else if (t.SchoolingName == SchoolingCategory.Supporterlinje && temp.Contains("Server"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                temp2 = temp.Replace("_", " ");
                Console.WriteLine(temp2);
            }
            else if (t.SchoolingName == SchoolingCategory.Infrastrukturlinje && temp.Contains("Netværk"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                temp2 = temp.Replace("_", " ");
                Console.WriteLine(temp2);
            }
            else
            {
                temp2 = temp.Replace("_", " ");
                Console.WriteLine(temp2);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Sorterer listen af lærere og udskriver til skærm, med den udvalgte lærer farvet.
        Console.WriteLine("------------------------------\nLærer:\n------------------------------");
        t.Teachers.Sort();
        foreach (var lærerNavn in t.Teachers)
        {
            if (t.SchoolingName == lærerNavn.Uddannelseslinje)
            {
                if (lærerNavn.FullName == "Niels Olesen")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(lærerNavn.FullName);
                }
                else if (lærerNavn.FullName == "Bo Hansen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(lærerNavn.FullName);
                }
                else if (lærerNavn.FullName == "Ole Nielsen")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(lærerNavn.FullName);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(lærerNavn.FullName);
            }
        }
        Console.WriteLine("------------------------------\n");
        goto returpunktstart;
    }
}