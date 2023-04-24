using System.Globalization;


//class Program
//{
//    public static void Main()
//    {

//instrukcje najwyższego poziomu - instrukcje bez jawnego opakowania w funkcję Main


Console.WriteLine("Hello, World!");

//; - średnik oznacza koniec instrukcji

//deklaracja zmiennej lokalnej o typie string (ciąg znaków) i nazwie helloVariable
string helloVariable;
//inicjalizacja zmiennej - pierwsze przypisanie wartości (może być wartością null)
helloVariable = "Hello";

Console.WriteLine(helloVariable);

//deklaracja z inicjalizacją
string worldString = "world";
Console.WriteLine(worldString);

//przypisanie wartości
worldString = "World";
Console.WriteLine(worldString);

Console.WriteLine(helloVariable + worldString);

Console.Write(helloVariable);
Console.WriteLine(worldString);

string input = Console.ReadLine();
Console.WriteLine(input);


string helloOutput;

//łączenie stringów za pomocą +
helloOutput = helloVariable + " " + input;
Console.WriteLine(helloOutput);

//łączenie stringów za pomocą funkcji Concat
helloOutput = helloVariable;
helloOutput = string.Concat(helloOutput, " ", input);
//helloOutput = string.Concat(helloOutput, input);
Console.WriteLine(helloOutput);

//łączenie stringów za pomocą funkcji Format
helloOutput = string.Format("{0} {1}", helloVariable, input);
Console.WriteLine(helloOutput);

//łączenie stringów wykorzystujhąć interpolację (string interpolowany)
helloOutput = $"{helloVariable} {input}! :)";
Console.WriteLine(helloOutput);

//Join - łączy stringi za pomocą wskazanego separatora
Console.WriteLine( string.Join(" _ ", helloVariable, input, "!") );

Console.WriteLine($"helloOuput lengh is {helloOutput.Length}");
Console.WriteLine($"helloOuput lengh is {helloOutput.Count()}");

//zastąpienie części ciągu znaków - czułe na wielkość liter
//helloOutput = helloOutput.Replace("Hello", "Hi");
//Console.WriteLine(helloOutput);

//zastąpienie części ciągu znaków - niezależne od wielkości liter
helloOutput = helloOutput.Replace("hello", "Hi", true, CultureInfo.InvariantCulture); //using System.Globalization
Console.WriteLine(helloOutput);




//    }
//}