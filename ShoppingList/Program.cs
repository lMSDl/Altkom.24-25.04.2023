
using ShoppingList.Models;
using ShoppingList.Services;

ProductsService productsService = new ProductsService();

bool exit = false;

do
{
    ShowList(productsService);

    int option = ReadInt();

    switch (option)
    {
        case 1:
            AddNewProduct(productsService);
            break;
        case 2:
            RemoveProduct(productsService);
            break;
        case 3:
            exit = true;
            break;
        default:
            Console.WriteLine("Błędna opcja..");
            break;
    }
} while (!exit);


int ReadInt()
{
    int value;
    bool parseResult;
    do
    {
        string input = Console.ReadLine();
        parseResult = int.TryParse(input, out value);
        if (parseResult == false)
        {
            Console.WriteLine("Błędne dane");
        }
    } while (!parseResult);

    return value;
}

void AddNewProduct(ProductsService productsService)
{
    Product product = new Product();

    Console.Write("Podaj nazwę: ");
    product.Name = Console.ReadLine();
    Console.Write("Podaj ilość: ");
    product.Quantity = ReadInt();
    productsService.Add(product);
}

void RemoveProduct(ProductsService productsService)
{
    Console.Write("Podaj pozycję do usunięcia: ");
    int position = ReadInt();
    productsService.Remove(position - 1);
}

void ShowList(ProductsService productsService)
{
    Console.Clear();
    productsService.Show();
    Console.WriteLine();
    Console.WriteLine($"1. Dodaj   2. Usuń   3. Koniec");
}