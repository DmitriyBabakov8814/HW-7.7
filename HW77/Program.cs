
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace oop
{

    abstract class Products
    {
        public int Cost;
        public List<string> Choise = new List<string>();
        private static string[] arr = { "Видеокарты", "Процессоры", "Оперативная память" };
        public static Products ShowCategory()
        {
            while (true)
            {
                Console.WriteLine("Cписок всех категорий товара");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, arr[i]);
                }
                Console.WriteLine("Введите номер интересующей вас категории");
                string k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        return new VideoCards();
                    case "2":
                        return new Processors();
                    case "3":
                        return new Ramemory();
                    default:
                        Console.WriteLine("Некорректное число, попробуйте снова");
                        break;
                }
            }
        }
        public abstract void PerformAction();
        protected void kproducts()
        {

            if (this is VideoCards)
            {
                Console.WriteLine("Вы выбрали категорию: Видеокарты\nВведите название видеокарты для добавления в корзину");
                string[] arr = { "RTX 4060 - 500$ ", "RTX 4070 - 600$", "RTX 4080 - 700$" };
                int[] costofproduct = { 500, 600, 700 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, arr[i]); // показывает каталог категории 
                }

                string choise = Console.ReadLine(); // выбранный товар
                int lot = 0; // кол-во товара 
                Console.WriteLine("Введите количество видеокарт, которое вы хотите приобрести");
                while (true) // цикл для проверки кол-ва выбранного товара
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out lot) || lot <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите положительное целое число.");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    string input = choise;
                    switch (input)
                    {
                        case "RTX 4060":
                            Cost += 500 * lot;
                            Choise.Add(choise);
                            break;
                        case "RTX 4070":
                            Cost += 600 * lot;
                            Choise.Add(choise);
                            break;
                        case "RTX 4080":
                            Cost += 700 * lot;
                            Choise.Add(choise);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод. Введите название видеокарты из списка");
                            input = Console.ReadLine();
                            choise = input;
                            break;
                    }
                    if (Choise.Count > 0)
                    {
                        break;
                    }
                }

                Console.WriteLine("Вы добавили товар {0} в корзину, в количестве {1} штук\nСумма вашей корзины составляет: {2}$", choise, lot, Cost);

            }
            else if (this is Processors)
            {
                Console.WriteLine("Вы выбрали категорию: Процессоры\nВведите название процессора (I7, R7, I3) для добавления в корзину");
                string[] arr = { "R7 5700X - 200$ ", "I7 12700F - 300$", "I3 10100F - 70$" };
                int[] costofproduct = { 200, 300, 70 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, arr[i]); // показывает каталог категории 
                }

                string choise = Console.ReadLine(); // выбранный товар
                int lot = 0; // кол-во товара 
                Console.WriteLine("Введите количество процессоров, которое вы хотите приобрести");
                while (true) // цикл для проверки кол-ва выбранного товара
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out lot) || lot <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите положительное целое число.");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    string input = choise;
                    switch (input)
                    {
                        case "R7":
                            Cost += 200 * lot;
                            Choise.Add(choise);
                            break;
                        case "I7":
                            Cost += 300 * lot;
                            Choise.Add(choise);
                            break;
                        case "I3":
                            Cost += 70 * lot;
                            Choise.Add(choise);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод. Введите название процессора из списка");
                            input = Console.ReadLine();
                            choise = input;
                            break;
                    }
                    if (Choise.Count > 0)
                    {
                        break;
                    }
                }

                Console.WriteLine("Вы добавили товар {0} в корзину, в количестве {1} штук\nСумма вашей корзины составляет: {2}$", choise, lot, Cost);
            }
            else
            {
                Console.WriteLine("Вы выбрали категорию: Оперативная память\nВведите название оперативной памяти для добавления в корзину");
                string[] arr = { "Dexp 32gb - 100$ ", "Adata 8gb- 40$", "Patriot 16gb - 70$" };
                int[] costofproduct = { 100, 40, 70 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, arr[i]); // показывает каталог категории 
                }

                string choise = Console.ReadLine(); // выбранный товар
                int lot = 0; // кол-во товара 
                Console.WriteLine("Введите количество плашек памяти, которое вы хотите приобрести");
                while (true) // цикл для проверки кол-ва выбранного товара
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out lot) || lot <= 0)
                    {
                        Console.WriteLine("Некорректный ввод. Введите положительное целое число.");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    string input = choise;
                    switch (input)
                    {
                        case "Dexp":
                            Cost += 100 * lot;
                            Choise.Add(choise);
                            break;
                        case "Adata":
                            Cost += 40 * lot;
                            Choise.Add(choise);
                            break;
                        case "Patriot":
                            Cost += 70 * lot;
                            Choise.Add(choise);
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод. Введите название памяти из списка");
                            input = Console.ReadLine();
                            choise = input;
                            break;
                    }
                    if (Choise.Count > 0)
                    {
                        break;
                    }
                }

                Console.WriteLine("Вы добавили товар {0} в корзину, в количестве {1} штук\nСумма вашей корзины составляет: {2}$", choise, lot, Cost);
            }

        }
    }

    class VideoCards : Products
    {
        public override void PerformAction()
        {
            kproducts();
        }
    }

    class Processors : Products
    {
        public override void PerformAction()
        {
            kproducts();
        }
    }

    class Ramemory : Products
    {
        public override void PerformAction()
        {
            kproducts();
        }
    }

    abstract class Delivery
    {
        protected string Name, Surname, PhoneNumber, Email;
        protected string Address;
        public string DeliveryName
        {
            get { return Name; }
        }

        public string DeliveryAddress
        {
            get { return Address; }
        }

        public string DeliverySurname
        {
            get { return Surname; }
        }

        public string DeliveryPhoneNumber
        {
            get { return PhoneNumber; }
        }

        public string DeliveryEmail
        {
            get { return Email; }
        }

        public Delivery(string Name, string Surname, string PhoneNumber, string Email)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
        public abstract void TypeOfDel();

    }

    class HomeDelivery : Delivery
    {
        public HomeDelivery(string Name, string Surname, string PhoneNumber, string Email) : base(Name, Surname, PhoneNumber, Email)
        {

        }
        public override void TypeOfDel()
        {
            Console.WriteLine("Введите адрес доставки");
            string HomeAddress = Console.ReadLine();
            Address = HomeAddress;
        }
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string Name, string Surname, string PhoneNumber, string Email)
        : base(Name, Surname, PhoneNumber, Email)
        { }
        public override void TypeOfDel()
        {
            string[] PickPointAddress = new string[] { "Московская 10", "Ленина 87", "Советская 29" };
            Console.WriteLine("Выберите номер адреса доставки из предложенных ");
            for (int i = 0; i < PickPointAddress.Length; i++)
            {
                Console.WriteLine(i + 1 + " - " + PickPointAddress[i]);
            }
            while (true)
            {
                string choiseaddres = Console.ReadLine();
                if (int.TryParse(choiseaddres, out int choice) && choice >= 1 && choice <= 3)
                {
                    switch (choiseaddres)
                    {
                        case "1":
                            Address = PickPointAddress[0];
                            break;
                        case "2":
                            Address = PickPointAddress[1];
                            break;
                        case "3":
                            Address = PickPointAddress[2];
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно введен адрес, попробуйте снова (введите цифру от 1 до 3)");
                }
            }
        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery(string Name, string Surname, string PhoneNumber, string Email)
        : base(Name, Surname, PhoneNumber, Email)
        { }
        public override void TypeOfDel()
        {
            string[] ShopAddress = new string[] { "Советская 11", "Труда 47", "Ленина 24" };
            Console.WriteLine("Выберите номер адреса доставки из предложенных ");
            for (int i = 0; i < ShopAddress.Length; i++)
            {
                Console.WriteLine(i + 1 + " - " + ShopAddress[i]);
            }
            while (true)
            {
                string choiseaddres = Console.ReadLine();
                if (int.TryParse(choiseaddres, out int choice) && choice >= 1 && choice <= 3)
                {
                    switch (choiseaddres)
                    {
                        case "1":
                            Address = ShopAddress[0];
                            break;
                        case "2":
                            Address = ShopAddress[1];
                            break;
                        case "3":
                            Address = ShopAddress[2];
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно введен адрес, попробуйте снова (введите цифру от 1 до 3)");
                }
            }
        }
    }

    class Order<TDelivery> : Products where TDelivery : Delivery
    {
        public TDelivery delivery;
        public Order(Products product)
        {
            this.Cost = product.Cost;
            this.Choise = product.Choise;
        }
        public override void PerformAction()
        {
            Console.WriteLine($"Вот информация о вашем заказе\nИмя: {delivery.DeliveryName}, Фамилия: {delivery.DeliverySurname}, Телефон: {delivery.DeliveryPhoneNumber}, Email: {delivery.DeliveryEmail}");
            Console.WriteLine($"Общая стоимость заказа: {Cost}$");
            Console.WriteLine("Список товаров в корзине:");
            foreach (var choise in Choise)
            {
                Console.WriteLine($"- {choise}");
            }
            Console.WriteLine("Адрес вашей доставки: {0}", delivery.DeliveryAddress);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите номер телефона:");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введите email:");
            string Email = Console.ReadLine();
            Products currentProduct = Products.ShowCategory();
            currentProduct.PerformAction();
            Console.WriteLine("Выберите тип доставки из предложенных\n1 - Доставка на дом\n2 - Доставка в магазин\n3 - Доставка в постомат");
            int input = 0;
            while (true)
            {
                string temp = Console.ReadLine();
                if (!int.TryParse(temp, out input) || input < 1 || input > 3)
                {
                    Console.WriteLine("Некорректный ввод");
                }
                else
                {
                    break;
                }
            }
            if (input == 1)
            {
                Delivery delivery = new HomeDelivery(Name, Surname, PhoneNumber, Email);
                delivery.TypeOfDel();
                Order<Delivery> order = new Order<Delivery>(currentProduct)
                {
                    delivery = delivery,
                };
                order.PerformAction();
            }
            else if (input == 2)
            {
                Delivery delivery = new ShopDelivery(Name, Surname, PhoneNumber, Email);
                delivery.TypeOfDel();
                Order<Delivery> order = new Order<Delivery>(currentProduct)
                {
                    delivery = delivery,
                };
                order.PerformAction();
            }
            else
            {
                Delivery delivery = new PickPointDelivery(Name, Surname, PhoneNumber, Email);
                delivery.TypeOfDel();
                Order<Delivery> order = new Order<Delivery>(currentProduct)
                {
                    delivery = delivery,
                };
                order.PerformAction();
            }
        }
    }
}


