using System.Globalization;


//class Program
//{
//    public static void Main()
//    {


int value = int.Parse(Console.ReadLine());

// == - porównanie wartości
if(value == 0)
{
    Console.WriteLine($"Wartość {value} jest równa 0");
}

// != - różne
else if (value != 0)
{
    Console.WriteLine($"Wartość {value} jest różna od 0");
}



if (value > 0)
{
    Console.WriteLine($"Wartość {value} jest większa 0");
}
else 
{
    Console.WriteLine($"Wartość {value} jest mniejsza lub równa 0");
}

Console.WriteLine("---");

// || - logiczne lub
if (value > 0 || value < 0) {
    Console.WriteLine($"Wartość {value} jest mniejsza lub większa od 0");
}

// && - logiczne i
if (value > 5 && value < 10)
{
    Console.WriteLine($"Wartość {value} jest z przedziału (5;10)");
}

// >= - większe-równe, <= - mniejsze-równe 
if (value >= 5 && value <= 10)
{
    Console.WriteLine($"Wartość {value} jest z przedziału <5;10>");
}

// ! - negacja
if (!(value > 5 && value <= 10))
{
    Console.WriteLine($"Wartość {value} jest spoza przedziału <5;10>");
}



Console.WriteLine("---");


if (value > 0)
{
    Console.WriteLine($"Wartość {value} jest większa 0");
}
else if (value < 0)
{
    Console.WriteLine($"Wartość {value} jest mniejsza 0");
}
else
{
    Console.WriteLine($"Wartość {value} jest równa 0");
}

//switch przyjmuje parametr, który jest porównywany z listą przypadków
switch (value)
{
    case > 0:
        Console.WriteLine($"Wartość {value} jest większa 0");
        break;
    case < 0:
        Console.WriteLine($"Wartość {value} jest mniejsza 0");
        break;

        //default jest opcjonalny i wywoływany gdy nie znaleziono innego dopasowania
    default:
        Console.WriteLine($"Wartość {value} jest równa 0");
        break;
}


Console.WriteLine("Jak masz na imię?");
string input = Console.ReadLine();

switch(input)
{
    case "":
        Console.WriteLine("Szkoda, że nie chcesz podać swojego imienia...");
        break;
    case "Alexa":
        Console.WriteLine("Hej! Masz na imię tak jak asystent Amazona??");
        break;
    default:
        Console.WriteLine($"Cześć {input}! Jak się masz?");
        break;
}




void Numbers()
{

    int a = 11;
    int b = 4;

    int c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
    c = a / b; // część dziesiętna jest ucinana
    Console.WriteLine($"{a} / {b} = {c}");
    c = a % b; // reszta z dzielenia
    Console.WriteLine($"{a} % {b} = {c}");


    float aa = 11f;
    float bb = 4.0f;
    float cc = aa + bb;
    Console.WriteLine($"{aa} + {bb} = {cc}");
    cc = aa - bb;
    Console.WriteLine($"{aa} - {bb} = {cc}");
    cc = aa * bb;
    Console.WriteLine($"{aa} * {bb} = {cc}");
    cc = aa / bb;
    Console.WriteLine($"{aa} / {bb} = {cc}");

    // kolejność działań zgodna z zasadami matematyki
    cc = 1f * a / b;
    Console.WriteLine($"{a} / {bb} = {cc}");

    c = a + a * a;
    Console.WriteLine($"{a} + {a} * {a} = {c}");
    c = (a + a) * a;
    Console.WriteLine($"({a} + {a}) * {a} = {c}");


    Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
    Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
    Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

    Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
    Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
    Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

    //dzielenie przez float/double/decimal daje wynik o wyższej precyzji
    Console.WriteLine(5 / 3.3f);
    Console.WriteLine(5 / 3.3d);
    Console.WriteLine(5 / 3.3m);

    //zaokrąglanie domyślnie wykorzustyje "financial rounding"
    Console.WriteLine(Math.Round(2.5));
    Console.WriteLine(Math.Round(3.5));

    //zaokrąglanie klasyczne
    Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));



    int intMax = int.MaxValue;
    long longMax = long.MaxValue;


    //longMax = intMax;
    //chcąć przypisać wartość o wyższej precyzji do zmiennej o niższej musimy zastosować rzutowanie
    intMax = (int)longMax;
    Console.WriteLine(intMax);

    float floatValue = int.MaxValue;

    Console.WriteLine(floatValue);

    floatValue = (float)double.MaxValue;
    Console.WriteLine(floatValue);


    //parsowanie/konwersja string na int
    string value = Console.ReadLine();
    int intVal = int.Parse(value);
    int result = intVal * 2;

    Console.WriteLine($"{intVal} * 2 = {result}");

    //parsowanie/konwersja string na float
    value = Console.ReadLine();
    float floatVal = float.Parse(value);
    float floatResult = floatVal * 2;

    Console.WriteLine($"{floatVal} * 2 = {floatResult}");
}


void Strings()
{ 
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

}


//    }
//}