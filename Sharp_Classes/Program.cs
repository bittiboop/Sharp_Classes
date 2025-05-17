namespace Sharp_Classes;

class Program
{
    // Task 1
    class Square
    {
        public static void DrawSquare(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
    //Task 2
    class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            string strNumber = number.ToString();
            char[] arr = strNumber.ToCharArray();
            Array.Reverse(arr);
            string reversedNumber = new string(arr);
            return strNumber == reversedNumber;
        }
    }
    //Task 3
    class FilterArray
    {
        public static int[] Filter(int[] originalArray, int[] filterArray)
        {
            List<int> result = new List<int>();
            foreach (int item in originalArray)
            {
                if (!filterArray.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
    //Task 4
    class Website
    {
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        public void SetName(string name) 
        { 
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPath(string path)
        {
            this.path = path;
        }
        public string GetPath()
        {
            return path;
        }
        public void SetDescription(string description)
            {
                this.description = description;
            }

        public string GetDescription()
        { 
            return description;
        }

        public void SetIpAddress(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }
    }
    //Task 5
    class Journal
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public string GetPhone()
        {
            return phone;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
    }
    //Task 6
    class Shop
    {
        private string name;
        private string address;
        private string description;
        private string phone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public string GetPhone()
        {
            return phone;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
    }
    static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Enter the side length of the square:");
        int sideLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the symbol to draw the square:");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Square.DrawSquare(sideLength, symbol);
        
        // Task 2
        Console.WriteLine("Enter a number to check if it's a palindrome:");
        int number = int.Parse(Console.ReadLine());
        bool isPalindrome = Palindrome.IsPalindrome(number);
        if (isPalindrome)
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
        
        // Task 3
        Console.WriteLine("Enter the original array (comma-separated):");
        int[] originalArray = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        Console.WriteLine("Enter the filter array (comma-separated):");
        int[] filterArray = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int[] filteredArray = FilterArray.Filter(originalArray, filterArray);
        Console.WriteLine("Filtered array:");
        foreach (int item in filteredArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        
        //Task 4
        Website website = new Website();
        Console.WriteLine("Enter the website name:");
        website.SetName(Console.ReadLine());
        Console.WriteLine("Enter the website path:");
        website.SetPath(Console.ReadLine());
        Console.WriteLine("Enter the website description:");
        website.SetDescription(Console.ReadLine());
        Console.WriteLine("Enter the website IP address:");
        website.SetIpAddress(Console.ReadLine());
        Console.WriteLine($"Website Name: {website.GetName()}");
        Console.WriteLine($"Website Path: {website.GetPath()}");
        Console.WriteLine($"Website Description: {website.GetDescription()}");
        Console.WriteLine($"Website IP Address: {website.GetIpAddress()}");
        
        // Task 5
        Journal journal = new Journal();
        Console.WriteLine("Enter the journal name:");
        journal.SetName(Console.ReadLine());
        Console.WriteLine("Enter the year of establishment:");
        journal.SetYear(int.Parse(Console.ReadLine()));
        Console.WriteLine("Enter the journal description:");
        journal.SetDescription(Console.ReadLine());
        Console.WriteLine("Enter the contact phone:");
        journal.SetPhone(Console.ReadLine());
        Console.WriteLine("Enter the email:");
        journal.SetEmail(Console.ReadLine());
        Console.WriteLine($"Journal Name: {journal.GetName()}");
        Console.WriteLine($"Year of Establishment: {journal.GetYear()}");
        Console.WriteLine($"Journal Description: {journal.GetDescription()}");
        Console.WriteLine($"Contact Phone: {journal.GetPhone()}");
        Console.WriteLine($"Email: {journal.GetEmail()}");
        
        //Task 6
        Shop shop = new Shop();
        Console.WriteLine("Enter the shop name:");
        shop.SetName(Console.ReadLine());
        Console.WriteLine("Enter the shop address:");
        shop.SetAddress(Console.ReadLine());
        Console.WriteLine("Enter the shop description:");
        shop.SetDescription(Console.ReadLine());
        Console.WriteLine("Enter the contact phone:");
        shop.SetPhone(Console.ReadLine());
        Console.WriteLine("Enter the email:");
        shop.SetEmail(Console.ReadLine());
        Console.WriteLine($"Shop Name: {shop.GetName()}");
        Console.WriteLine($"Shop Address: {shop.GetAddress()}");
        Console.WriteLine($"Shop Description: {shop.GetDescription()}");
        Console.WriteLine($"Contact Phone: {shop.GetPhone()}");
        Console.WriteLine($"Email: {shop.GetEmail()}");
        
    }
}