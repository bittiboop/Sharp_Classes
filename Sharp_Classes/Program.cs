namespace Sharp_Classes;

class Program
{
    //Task 1
    class Multiplication
    {
        public static int GetProduct(int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
    }
    //Task 2
    class CheckFibonacci
    {
        public static bool IsFibonacci(int number)
        {
            int a = 0, b = 1, c = 0;
            if (number == 0 || number == 1)
                return true;
            while (c < number)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c == number;
        }
    }
    //Task 3
    class SortingArray
    {
        public static void SortArrayAscending(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Sorted array in ascending order:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }

        public static void SortArrayDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Sorted array in descending order:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
    //Task 4
    class City
    {
        private string name;
        private string country;
        private int population;
        private int phoneCode;
        private string nameArea;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }
        public string GetCountry()
        {
            return country;
        }
        public void SetPopulation(int population)
        {
            this.population = population;
        }
        public int GetPopulation()
        {
            return population;
        }
        public void SetPhoneCode(int phoneCode)
        {
            this.phoneCode = phoneCode;
        }
        public int GetPhoneCode()
        {
            return phoneCode;
        }
        public void SetNameArea(string nameArea)
        {
            this.nameArea = nameArea;
        }
        public string GetNameArea()
        {
            return nameArea;
        }
    }
    //Task 5
    class Worker
    {
        private string SurnameName;
        private string birthDate;
        private int contactNumber;
        private string email;
        private string position;
        private int description;
        
        public void SetSurnameName(string surnameName)
        {
            SurnameName = surnameName;
        }
        public string GetSurnameName()
        {
            return SurnameName;
        }
        public void SetBirthDate(string birthDate)
        {
            this.birthDate = birthDate;
        }
        public string GetBirthDate()
        {
            return birthDate;
        }
        public void SetContactNumber(int contactNumber)
        {
            this.contactNumber = contactNumber;
        }
        public int GetContactNumber()
        {
            return contactNumber;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetPosition(string position)
        {
            this.position = position;
        }
        public string GetPosition()
        {
            return position;
        }
        public void SetDescription(int description)
        {
            this.description = description;
        }
        public int GetDescription()
        {
            return description;
        }
    }
    //Task 6 
    class Plane
    {
        private string name;
        private string companyName;
        private int year;
        private string type;
        
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        public string GetCompanyName()
        {
            return companyName;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetType(string type)
        {
            this.type = type;
        }
        public string GetType()
        {
            return type;
        }
    }
    //Task 7
    class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int cols;
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[rows, cols];
        }
        public void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int GetMax()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        public int GetMin()
        {
            int min = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
    }
    static void Main(string[] args)
    {
        //Task 1
        Console.WriteLine("Enter the start of the range:");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the end of the range:");
        int end = Convert.ToInt32(Console.ReadLine());
        int product = Multiplication.GetProduct(start, end);
        Console.WriteLine($"The product of numbers from {start} to {end} is: {product}");
        
        //Task 2
        Console.WriteLine("Enter the number to check if it's Fibonacci:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isFibonacci = CheckFibonacci.IsFibonacci(number);
        if (isFibonacci)
        {
            Console.WriteLine($"{number} is a Fibonacci number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Fibonacci number.");
        }
        
        //Task 3
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Choose sorting order (1 for ascending, 2 for descending):");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            SortingArray.SortArrayAscending(array);
        }
        else if (choice == 2)
        {
            SortingArray.SortArrayDescending(array);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
        
        //Task 4
        City city = new City();
        Console.WriteLine("Enter city name:");
        city.SetName(Console.ReadLine());
        Console.WriteLine("Enter country name:");
        city.SetCountry(Console.ReadLine());
        Console.WriteLine("Enter population:");
        city.SetPopulation(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter phone code:");
        city.SetPhoneCode(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter area name:");
        city.SetNameArea(Console.ReadLine());
        Console.WriteLine($"City Name: {city.GetName()}");
        Console.WriteLine($"Country: {city.GetCountry()}");
        Console.WriteLine($"Population: {city.GetPopulation()}");
        Console.WriteLine($"Phone Code: {city.GetPhoneCode()}");
        Console.WriteLine($"Area Name: {city.GetNameArea()}");
        
        //Task 5
        Worker worker = new Worker();
        Console.WriteLine("Enter surname and name:");
        worker.SetSurnameName(Console.ReadLine());
        Console.WriteLine("Enter birth date:");
        worker.SetBirthDate(Console.ReadLine());
        Console.WriteLine("Enter contact number:");
        worker.SetContactNumber(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter email:");
        worker.SetEmail(Console.ReadLine());
        Console.WriteLine("Enter position:");
        worker.SetPosition(Console.ReadLine());
        Console.WriteLine("Enter description:");
        worker.SetDescription(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine($"Surname and Name: {worker.GetSurnameName()}");
        Console.WriteLine($"Birth Date: {worker.GetBirthDate()}");
        Console.WriteLine($"Contact Number: {worker.GetContactNumber()}");
        Console.WriteLine($"Email: {worker.GetEmail()}");
        Console.WriteLine($"Position: {worker.GetPosition()}");
        Console.WriteLine($"Description: {worker.GetDescription()}");
        
        //Task 6
        Plane plane = new Plane();
        Console.WriteLine("Enter plane name:");
        plane.SetName(Console.ReadLine());
        Console.WriteLine("Enter company name:");
        plane.SetCompanyName(Console.ReadLine());
        Console.WriteLine("Enter year of manufacture:");
        plane.SetYear(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter type of plane:");
        plane.SetType(Console.ReadLine());
        Console.WriteLine($"Plane Name: {plane.GetName()}");
        Console.WriteLine($"Company Name: {plane.GetCompanyName()}");
        Console.WriteLine($"Year of Manufacture: {plane.GetYear()}");
        Console.WriteLine($"Type of Plane: {plane.GetType()}");
        
        //Task 7
        Console.WriteLine("Enter number of rows in the matrix:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of columns in the matrix:");
        int cols = Convert.ToInt32(Console.ReadLine());
        Matrix matrix = new Matrix(rows, cols);
        matrix.FillMatrix();
        Console.WriteLine("Matrix:");
        matrix.PrintMatrix();
        Console.WriteLine($"Maximum value in the matrix: {matrix.GetMax()}");
        Console.WriteLine($"Minimum value in the matrix: {matrix.GetMin()}");
        
    }
}