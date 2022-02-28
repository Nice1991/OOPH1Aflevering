global using OOPH1Aflevering.Codes;

#region Quiz 1/5
//Console.Write("Angiv hestekræfter: ");
//int? power = Convert.ToInt32(Console.ReadLine());

//Console.Write("Angiv mærke: ");
//string? car = Console.ReadLine();

//Console.Write("Angiv model: ");
//string? brand= Console.ReadLine();


//Audi audi = new(car, brand, power);

//Console.Clear();
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("----------------------------------------------------------");
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($" Bilen er en {audi.Mærke}, {audi.Model}, med {audi.HesteKræfter} hestekrafter");
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("----------------------------------------------------------");
//Console.WriteLine();

//Console.ReadLine();

//  DEL 1/2 : Quiz 1/5
//  1 svar:
//  1 og 4 vil ikke vise fejl.  

//1. MotorKøretøj motorKøretøj = new MotorKøretøj();
//2. MotorKøretøj motorKøretøj = new Bil();
//3. MotorKøretøj motorKøretøj = new Audi();
//4. Audi audi = new Audi();
//5. Audi audi = new Bil();
//6. Audi audi = new MotorKøretøj();

//  2 svar:
//  nej/ja? kun mærke som den arver fra, med mindre man laver et interface, så man arver fra en klasse og bruger den anden klasse som objekt.

//  3 svar:
//  nej parent arver jo ikke noget.

#endregion

#region Quiz 2/5
// 1 svar: 
List<Bil> bil = new()

{
    new Bil { Mærke = "Toyota", Model = "Aygo", Hestekræfter = 60 },
    new Bil { Mærke = "Fiat", Model = "Punto", Hestekræfter = 90 },
    new Bil { Mærke = "Audi", Model = "A6", Hestekræfter = 175 }
};

// 2 svar:
//Bil b1 = bil.FirstOrDefault(a => a.Hestekræfter == 90);
//Bil b2 = bil.FirstOrDefault(a => a.Hestekræfter == 175);

//Console.WriteLine($"{b1.Mærke} {b1.Model}");
//Console.WriteLine($"{b2.Mærke} {b2.Model}");

// Eller brug fordi den indholder where (LINQ)

//List<Bil> biler = bil.Where(a => a.Hestekræfter > 60).ToList();
//foreach (Bil line in bil)
//{
//    if (line.Hestekræfter > 60)
//    {
//        Console.WriteLine(line.Mærke);
//    }
//}

// 3 svar:
//Bil b = bil.FirstOrDefault(a => a.Mærke == "Audi");
//Console.WriteLine($"{b.Mærke}, {b.Model}, {b.Hestekræfter}");

#endregion

#region Quiz 3/5
//  1 svar:
//  Det gør Where. altså (?? = Biler.Where(…);

//  2 svar:
//  ?? = Biler.FirstOrDefault(...); og
//  ?? = Biler.First(...)

//  3 svar: 
//  ?? = Biler.Where(...);

//  4 svar:
//  https://quick-adviser.com/what-does-linq-return-when-the-results-are-empty/#What_does_Linq_return_when_the_results_are_empty
//  Usikker FirstorDefault skulle gerne give en NULL tilbage hvor og First() vil give en exception(Crash)

#endregion

#region Quiz 4/5
//  1 svar:
//  Man skal Bruge abstrakt?. spørg de andre da man kan lave interface der tager fra andre klasser.
//  https://www.codeproject.com/Articles/10072/Simulated-Multiple-Inheritance-Pattern-for-C

#endregion

#region Quiz 5/5
//  1 svar:
//  SetSyn er overloaded. Det er fordi den består af 2 metoder. tror jeg
#endregion



Console.ReadKey();