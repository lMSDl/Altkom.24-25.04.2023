//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa. Namepsace używany w "using"
namespace Models
{
    //public - modyfikator dostępu - oznacza, że z klasy możemy korzystać wszędzie
    //class - szablon opisujący zachowania i cechy obiektów (instancji klas), które są wytwarzane na jej podstawie 
    //nazwa klasy (pełna nazwa klasy: namespace + nazwa klasy)
    public class Item
    {
        // zmianna globalna / pole klasy (field)
        //brak modyfikatora dostępu == private - oznacza dostęp tylko dla elementów danej klasy
        // pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody getter setter
        private int value;

        //getter do pobierania wartości pola Value - metoda zwracająca typ zgodny z typem pola
        //schemat sygnatury metody: <modyfikator dostępu> <typ zwracany> <nazwa funkcji>(<opcjonalne parametry>)
        public int GetValue()
        {
            //return instrukcja zwracająca wynik metody - typ obiektu zwracanego musi być zgodny z sygnaturą metody
            return value;
        }

        //setter do ustawienia wartości pola value - metoda przyjmuje jako poarametr wartość, która zostanie wpisana do pola
        public void SetValue(int value)
        {
            //this oznacza odniesienie się do klasy - dzięki czemu możemy rozróżnić pole od parametru metody
            this.value = value;
        }

        //metoda - zachowanie klasy
        //void - metoda nic nie zwraca
        public void CountToValue()
        {
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(i);
            }
        }


        //Property

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //możliwość zmiany modyfikatora dostępu dla gettera lub settera
        public string Description { /*private*/ get; set; }


        //full-property
        private int quantity;
        public int Quantity
        {
            //getter wbudowany w property
            get 
            { 
                return quantity;
            }
            //setter wbudowany w property - posiada niejawny parametr o nazwie value
            set
            {
                if(value < 0)
                    quantity = 0;
                else
                    quantity = value;
            }
        }


        //metody mogą przyjmować parametry z domyślnymi wartościami. Wtedy te parametry stają sie opcjonalne. Muszą się one znajdować na końcu listy parametrów. 
        public void WriteText(string text = "no content", int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        // result to parametr wyjściowy oznaczony słowen kluczonym out. Parametr wyjściowy MUSI być zainicjowany przed opuszczeniem funkcji.
        public bool Modulo(int a, int b, out int result)
        {
            int tempResult = a % b;

            if (tempResult == 0)
                result = default;
            else
                result = tempResult;

            return tempResult != 0;
        }
    }
}
