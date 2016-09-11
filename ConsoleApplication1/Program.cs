using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate double GetSum(double num1, double num2);

namespace ConsoleApplication1
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public Animal() // Constructor defined , VS will use this one instead the default  
        {
            this.height = 0;
            this.weight = 0;
            this.name = "no name";
            this.sound = "no sound";
        }


        // the constructors names must be similar , but must have different arguments and type of the arguments
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numofanimals++;   //for every animal object which was created

        }


        GetSum sum = delegate (double num1, double num2)
        {
            return num1 + num2;
        };


        static int numofanimals = 0;    // static variables are accessible from all the objects of the class

        public static int getnumofanimals()
        {
            return numofanimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and like to say  {3} ", name, height, weight, sound);

        }

        public int getsum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }
        public double getsum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            // ccomment
            /*
            comment
            */
            // kind of variables
            bool t = true; // variable verdadrea , bandera
            char caracter = 'c';
            int number = 9;
            long longnumber = 1231231;
            decimal decimalnumber = decimal.MaxValue;
            float floatnumber = float.MaxValue;
            double doublenumber = double.MaxValue;
            var iwillknowyouareastring = "carl";


            Console.WriteLine("Hello !");
            Console.Write("What is your name ? ");
            Console.WriteLine(caracter + " " + longnumber + " " + decimalnumber + " " + floatnumber + " " + doublenumber);
            string name = Console.ReadLine();
            Console.WriteLine("tap enter to exit " + name);
            // get the variable type           
            Console.WriteLine("another name is a {0}", iwillknowyouareastring.GetTypeCode());
            //--------------------------------------------------------Maths-----------------------
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));
            //-------------------------------------------------------------Maths ends--------------------



            // Converting double to int as an example-----------------------------------------------
            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine("Pi onto integer is : " + intPi);


            //--------------------------------------------------------------------------------------

            // some another maths operations------------------------------------------------------------

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));

            //------------------------------------------------------------------------------------------

            // generate random numbers --------------------------------- 

            Random rand = new Random();    // tipe of number random
            Console.WriteLine("Random number between 1 and 10 :" + (rand.Next(1, 10)));
            //---------------------------------------------



            // rlational operators --------------------------------- <> <= >= == !=
            //Logical operators --------------------------------------- && || ^ !
            // If Statement
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            //------------------------------------------------------


            // asignating boolean value if condition--------------------------------

            bool canDrive = age >= 16 ? true : false;
            //int canDrive = age >= 16 ? 1 : 0;

            Console.WriteLine("can drive ? " + canDrive);



            //---------------------------------------------------------------------
            //---------------------------bucle switch---------------------

            switch (age)
            {
                case 0:
                    Console.WriteLine("infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Go to elementary school");
                    // saltear codigo
                    goto Cute;
                    break;
                default:
                    Console.WriteLine("nada");
                    break;

            }
        Cute:
            Console.WriteLine("que");

            int ban = 0;
            // --------------------------------------------------Bucle while--------------------------------------
            while (ban < 10)
            {
                Console.WriteLine(ban);
                if (ban == 7)
                {
                    break;
                }

                ban++;
            }

            ban = 0;
            // --------------------------------------------------Bucle Do while--------------------------------------
            do
            {
                Console.WriteLine(ban);
                if (ban == 7)
                {
                    break;
                }

                ban++;
            } while (ban < 10);

            //-----------------------------------------------------Bucle For----------------------------------------
            for (i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.WriteLine(" the count just came to 9");
                    break;
                }
            }
            // -------------------------------------------Bucle foreach------------------------

            string randomchar = "this is a string with a random word or phrase";
            int Acount = 0;
            foreach (char a in randomchar)
            {
                if (a == 'a')
                {
                    Acount++;
                }

            }
            Console.WriteLine("there are " + Acount + " letters 'a' in the string");

            //----------------------------------------- some string functions------------------

            string xamplestring = " A bunch of random words ";

            Console.WriteLine("is empty :" + String.IsNullOrEmpty(xamplestring));
            Console.WriteLine("is white space :" + String.IsNullOrWhiteSpace(xamplestring));
            Console.WriteLine("String lenght :" + xamplestring.Length);
            Console.WriteLine("index of bunch on the string is :" + xamplestring.IndexOf("bunch"));
            // subcaena
            Console.WriteLine("the second word on the string is :" + xamplestring.Substring(3, 5)); // 5 carac contando desde el 3
            string xamplestring2 = " A bunch of random words ";
            Console.WriteLine(" sample strings are equal ? :" + xamplestring.Equals(xamplestring2)); // comparacion true false
            Console.WriteLine("string stars with \" A bunch \" ? :" + xamplestring.StartsWith(" A bunch"));
            Console.WriteLine("string ends with \" words \" ? :" + xamplestring.EndsWith("words "));
            // Trim
            xamplestring = xamplestring.Replace("words", "pussys");   // TrimEnd or TrimStart
            Console.WriteLine(xamplestring + "-----------changing some words on the string");
            Console.WriteLine(xamplestring.Remove(0, 4) + "-----------removing some chars on the string");



            //-----------------------------------------Creating String Arrays-------------------
            string[] names = new string[3] { "walter", "harry", "mongo" };


            Console.WriteLine("name list : \n" + String.Join("\n", names));


            // mostrar valores de determinada forma
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr.ToString());


            // string builders---------------------------------------------------------------


            StringBuilder sb = new StringBuilder();

            sb.Append("this is the fisrt sentence");
            sb.AppendFormat("my name is {0} and i live in {1}", "Derek", "Pennsylvania");

            sb.Replace("a", "e");

            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());

            //--------------------------------------------------
            //arrays
            int[] array;
            int[] array2 = new int[5];
            int[] array3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(array3.Length);
            Console.WriteLine("this is the first number on the array : " + array3[0]);

            for (i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, array3[i]);
            }

            i = 0;
            foreach (int num in array3)
            {
                Console.WriteLine(i + ":" + num);
                i++;
            }


            Console.WriteLine("where is 4?: is on the " + Array.IndexOf(array3, 4) + "th position");

            //-----------------------------------------------------------------------------------------------

            // mult array----------------------------------------------------------------------


            int[,] multarray = new int[5, 3]; // two dimensional array or matrix 2x2

            int[,] multarray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } }; //  defining a 2 dimensional array values


            foreach (int num in multarray2)
            {
                Console.WriteLine(num);  // will print all the matrix values like if it would be a normal array (just one dimension)
            }


            for (i = 0; i < multarray2.GetLength(0); i++)
            {
                for (int x = 0; x < multarray2.GetLength(1); x++)
                {
                    // accessing to every value on the double dimension array
                    Console.WriteLine("{0} | {1} : {2}", i, x, multarray2[i, x]);  // printing each double par on the double dimension array
                }
            }

            // listing-----------------------------------------------------------------------------------------------
            // its like an ArrayList on Java

            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(15);
            numList.Add(20);
            numList.Add(32);

            //Cleanning up the List 
            //numList.Clear();



            // Creating a List from an array
            int[] randarray = { 1, 2, 3, 4, 5 };

            List<int> numList2 = new List<int>(randarray);


            numList.Insert(1, 10);

            numList.Remove(5);


            for (i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }


            Console.WriteLine("4 is in index : " + numList2.IndexOf(4));
            Console.WriteLine("5 is on the List?: " + numList2.Contains(5));   // it returns a true or false value


            List<string> str = new List<string>(new string[] { "Tom", "Paul" });

            Console.WriteLine(str[1]);

            // ------------------------------------------------------Try/catch sentences-------------------


            try
            {
                Console.WriteLine("divide 10 by");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can t divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //throw new InvalidOperationException("Operation failed");

            }
            catch (Exception ex)   // for any exeption
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }



            // --------------------------------------------------Classes and objects ----------------------------------

            //   ---------------------------Using the animal class defined at the beginning of the code 

            Animal spot = new Animal(15, 10, "Spot", "woof"); // Creates a new animal (object)

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);
            Console.WriteLine("number of animals: " + Animal.getnumofanimals());   // call a get function (static method) to bring the number of animals we just create
            Console.WriteLine(spot.toString());  //prints the entire object


            // using getsum with integers and double numbers

            Console.WriteLine(spot.getsum(num2: 1.4, num1: 2.7));   // parameters specified

            // new object

            Animal grover = new Animal     // new animal 
            {
                name = " grover",
                height = 16,
                weight = 18,
                sound = "grrr"
            };


            // creating a sub object from a subclass

            Dog dog = new Dog();


            Console.WriteLine(dog.toString());

            dog = new Dog(20, 1, "Otto", "im gay ", "everything he founds on the ground");  // defining a new dog with the whole variables

            Console.WriteLine(dog.toString());

            //--------------------------------------- using the abstract classes-----------------------------

            Shape rect = new Rectangle(5, 5);
            Shape trian = new Triangle(5, 5);


            Console.WriteLine("The area of the rectangle is:" + rect.area());
            Console.WriteLine("The area of the triangle is:" + trian.area());

            Rectangle rect2 = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("Adding one rectangle to another:" + rect2.area());



            //-------------------------------------------Using the generic class

            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";
            superman.ShowData();

            KeyValue<int, string> tv = new KeyValue<int, string>(0, "");    // changing parameters

            tv.key = 12345;
            tv.value = "samsung";
            tv.ShowData();

            //---------------------------------------------Using Temperature (enum CLass)----------------

            Temperature temp = Temperature.Boil;


            switch (temp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("On Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Warming");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Boiling");
                    break;
            }

            //----------------------------------------------------Using structs-----------------------------

            Customers c = new Customers();
            c.createcus("Bob", 15.50, 15);
            c.showCust();


            // --------------------------------------Delegating functions (upstairs)---------------------------


            Animal o = new Animal();
            Console.WriteLine("5+19= " + o.getsum(5, 19));


            // defining a mathematic funtion
            Func<int, int, int> getsum = (x, y) => x + y;
            // invoking the function sum
            Console.WriteLine("5+3=" + getsum.Invoke(5, 3));


            // List

            List<int> numlist = new List<int> { 5, 10, 15, 20, 25 };

            List<int> oddnumbs = numlist.Where(n => n % 2 == 0).ToList();

            foreach(int num in oddnumbs)
            {
                Console.WriteLine(num + ",");
            }
            //------------------------------------------------------------------------------------------------------------


            // -------------------------------------------Using text and text funtions ----------------------------



            // writting on a txt file

            string[] custs = string[] { "Tom  ","Paul", "Alvert"};

            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach(string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }


            // printing the names on the array by reading the whole file line to line
            string custname = "";

            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while((custname = sr.ReadLine())!= null)
                {
                    Console.WriteLine(custname);
                }
            }




                // ----------------------------------------------end of tuto-----------------------------------------------
                Console.ReadLine();

        }

    }
    class Dog : Animal  // dog class , inheritor of animal class
    {
        public string favfood { get; set; }

        public Dog() : base()   // base use the superclass  "Animal" for the subclass "Dog"
        {
            this.favfood = "no favorite food";
        }

        public Dog(double height, double weight, string name, string sound, string favfood) : base(height, weight, name, sound)
        {
            this.favfood = favfood;
        }
        new public string toString()  //overriding the "tostring()" method
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and like to say  {3} and it eats {4}", name, height, weight, sound, favfood);

        }
    }
    //-------------------------------------------Creating an abstract class-------------------------------------
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hi");
        }
    }
    //---------------------------------------------------Creating an interface---------------------------------
    public interface ShapeItem   // every method on the interface is abstract
    {
        double area();
    }

    class Rectangle : Shape
    {
        private double lenght;
        private double width;

        public Rectangle(double num1, double num2)
        {
            lenght = num1;
            width = num2;
        }
        public override double area()   // we must override the "area()" method because it is already defined
        {
            return lenght * width;
        }

        public static Rectangle operator+(Rectangle rect1, Rectangle rect2)
        {
            double rectlenght = rect1.lenght + rect2.lenght;
            double rectwidth = rect1.width + rect2.width;


            return new Rectangle(rectlenght, rectwidth);

        }
    }
    class Triangle : Shape
    {
        private double thebase;
        private double height;

        public Triangle(double num1, double num2)
        {
            thebase = num1;
            height = num2;
        }
        public override double area()   // we must override the "area()" method because it is already defined
        {
            return (height * thebase)/2;
        }
    }


    class KeyValue<Tkey, TValue>   //-------------------------------------Using generic classes
    {
        public Tkey key { get; set; }
        public TValue value { get; set; }


        public KeyValue(Tkey k, TValue v)
        {
            key = k;
            value = v;
        }
        public void ShowData()
        {
            Console.WriteLine("{0} is {1} " ,this.key, this.value);
        }
    }

    public enum Temperature //---------------------------------------------enum Class ------------------------
        // Enum class is like a variable which can take a different bunch of possible values
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    struct Customers
    {
        private string name;
        private double balance;
        private int id;


        public void createcus(string n , double b , int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("balance : " + balance);
            Console.WriteLine("id : " + id);
        }
    }
}
