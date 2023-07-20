using System.Collections;

internal class Program
{
    private static void Main(string[] args) 
    {

        //-----------------         11.07.2023   -----------------------------------------

        //Console.WriteLine("Hello, C#!");
        //Console.Write("Hilal");
        //Console.WriteLine("Nur");
        //Console.WriteLine("Hello, C#!");
        //writeline: alt satıra iner
        //write: yan yana yazar


        //-----------------INT STRING ------------------------------------------------
        int a;
        int b = 100;
        String kelime;

        Console.WriteLine("Sayı giriniz:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Kullanıcıdan alınan sayı a: {0}, sayı b: {1}", a, b);

        Console.WriteLine("Bir kelime giriniz:");
        kelime = Console.ReadLine();
        Console.WriteLine("Kullanıcıdan alınan kelime: " + kelime);


        //---------------------ARRAYE GIRIS--------------------------------------------
        //MAX DEGER BULMA
        int max1 = 0;
        int max2 = 0;
        int grade;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("ogrenci notunu giriniz: ");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade > max1)
            {
                max2 = max1;
                max1 = grade;
            }
            else if (grade > max2)
            {
                max2 = grade;
            }
        }
        Console.WriteLine("en yuksek not : {0}, en yuksek 2. not: {1} ", max1, max2);


        //--------------------ARRAY---------------------------------------------
        int[] evenNums = new int[5];
        evenNums[0] = 2;
        evenNums[1] = 4;
        evenNums[2] = 5;
        //evenNums[6] = 12;  //Throws run-time exception IndexOutOfRange

        Console.WriteLine(evenNums[0]);  //prints 2
        Console.WriteLine(evenNums[1]);  //prints 4
        Console.WriteLine(evenNums[4]);


        //-------------------------ARRAY----------------------------------------
        int[] evenNums = { 2, 4, 6, 8, 10 };
        string[] cities = { "Mumbai", "London", "New York" };

        foreach (var item in evenNums)
            Console.WriteLine(item);

        foreach (var city in cities)
            Console.WriteLine(city);


        //---------------------ARRAY--------------------------------------------
        //int[] nums = new int[5] { 10, 15, 16, 8, 6 };

        //console.writeline(nums.max());
        //console.writeline(nums.min());
        //console.writeline(nums.sum());
        //console.writeline(nums.average());


        //-----------------------ARRAY------------------------------------------
        int[] nums = new int[5] { 10, 15, 16, 8, 6 };

        Console.WriteLine("sort");
        Array.Sort(nums); // sorts array 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nums[i]);
        }

        Console.WriteLine("reverse");
        Array.Reverse(nums); // sorts array in descending order
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nums[i]);
        }

        Console.WriteLine("foreach");
        Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array

        Console.WriteLine("binary search");
        Array.BinarySearch(nums, 5);// binary search 
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }


        //-------------SAYI TAHMIN OYUNU--------------

        Console.WriteLine("Sayı tahmin oyununu hangi modda oynamak istersiniz? (1/2):");

        Console.WriteLine("1. Modu seçerseniz belirlenen en fazla deneme sayısı kadar tahminde bulunabilirsiniz. örn:10tahmin");
        Console.WriteLine("2. Modu seçerseniz seçilen sayıyı bulana kadar tahminde bulunabilirsiniz");

        int mod = Convert.ToInt32(Console.ReadLine());

        OyunaBasla(mod);

        static void OyunaBasla(int mod)
        {
            Console.WriteLine("Mod {0} seçildi", mod);

            Random random = new Random();
            int sayi = random.Next(0, 100);
            int tahmin;
            int deneme = 0;

            Console.WriteLine("1den 100e kadar herhangi bir sayı tahmininde bulunabilirsiniz");

            do
            {
                Console.WriteLine("Tahmininiz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                deneme++;

                if (tahmin < sayi)
                {
                    Console.WriteLine("seçilen sayı tahmininizden daha büyük ");
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("seçilen sayı tahmininizden daha küçük ");
                }
                else
                {
                    Console.WriteLine("TEBRİKLER !!!! Seçilen sayıyı buldunuz");
                    Console.WriteLine("deneme sayısı: " + deneme);
                    return;
                }

                if (mod == 1 && deneme == 15)
                {
                    Console.WriteLine("Mod 1 için deneme hakkınız sona erdi.");
                    return;
                }

            } while (true);


        }






        //----------------                      12.07.23              --------------------------------------
        //farklı projeler yapıldı




        //----------------                      13.07.23              --------------------------------------

        //          ARRAYLIST

        var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

        ////Access individual item using indexer
        //int firstElement = (int)arlist[0]; //returns 1
        //string secondElement = (string)arlist[1]; //returns "Bill"
        //                                          //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

        //using var keyword without explicit casting
        var firstElement = arlist[0]; //returns 1
        var secondElement = arlist[1]; //returns "Bill"
                                       //var fifthElement = arlist[5]; //Error: Index out of range

        //update elements
        arlist[0] = "Steve";
        arlist[1] = 100;
        arlist[3] = "hilal";
        //arlist[5] = 500; //Error: Index out of range

        arlist.Add(500);

        foreach (var item in arlist)
            Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

        for (int i = 0; i < arlist.Count; i++)
            Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5, 


        Console.WriteLine(arlist.Contains(300)); // true
        Console.WriteLine(arlist.Contains("Bill")); // true
        Console.WriteLine(arlist.Contains(10)); // false
        Console.WriteLine(arlist.Contains("Steve")); // false


        //      LIST
        var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

        //get all students whose name is Bill
        var result = from s in students
                     where s.Name == "Bill"
                     select s;

        foreach (var student in result)
            Console.WriteLine(student.Id + ", " + student.Name);



        //// LIST - Insert     
        var numbers = new List<int>() { 10, 20, 30, 40 };

        numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

        foreach (var num in numbers)
            Console.Write(num);





        //      STACK


        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        foreach (var item in myStack)
            Console.Write(item + ","); //prints 4,3,2,1, 





        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

        while (myStack.Count > 0)
            Console.WriteLine(myStack.Pop() + ",");

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);




        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);// prints 4

        if (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Peek()); // prints 4
            myStack.Pop();
            Console.WriteLine(myStack.Peek()); // prints 4
        }

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);// prints 4




        //              QUEUE

        Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        foreach (var id in callerIds)
            Console.WriteLine(id); //prints 1234




        Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

        if (strQ.Count > 0)
        {
            Console.WriteLine(strQ.Peek()); //prints H
            Console.WriteLine(strQ.Peek()); //prints H
        }

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5




        //          SORTED LIST

        SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

        Console.WriteLine("---Initial key-values--");

        foreach (KeyValuePair<int, string> kvp in numberNames)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

        numberNames.Add(6, "Six");
        numberNames.Add(2, "Two");
        numberNames.Add(4, "Four");

        Console.WriteLine("---After adding new key-values--");

        foreach (var kvp in numberNames)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);



        SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

        Console.WriteLine(numberNames[1]); //output: One
        Console.WriteLine(numberNames[2]); //output: Two
        Console.WriteLine(numberNames[3]); //output: Three
                                           //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

        numberNames[2] = "TWO"; //updates value
        numberNames[4] = "Four"; //adds a new key-value if a key does not exists





        //              DICTIONARY

        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        Console.WriteLine(cities["UK"]); //prints value of UK key
        Console.WriteLine(cities["USA"]);//prints value of USA key
                                         //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

        //use ContainsKey() to check for an unknown key
        if (cities.ContainsKey("France"))
        {
            Console.WriteLine(cities["France"]);
        }

        //use TryGetValue() to get a value of unknown key
        string result;

        if (cities.TryGetValue("France", out result))
        {
            Console.WriteLine(result);
        }

        //use ElementAt() to retrieve key-value pair using index
        for (int i = 0; i < cities.Count; i++)
        {
            Console.WriteLine("Key: {0}, Value: {1}",
                                                    cities.ElementAt(i).Key,
                                                    cities.ElementAt(i).Value);
        }





        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        cities["UK"] = "Liverpool, Bristol"; // update value of UK key
        cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                               //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

        if (cities.ContainsKey("France"))
        {
            cities["France"] = "Paris";
        }






        //              HASHTABLE



        Hashtable numberNames = new Hashtable();
        numberNames.Add(1, "One"); //adding a key/value using the Add() method
        numberNames.Add(2, "Two");
        numberNames.Add(3, "Three");

        //The following throws run-time exception: key already added.
        //numberNames.Add(3, "Three"); 

        foreach (DictionaryEntry de in numberNames)
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

        //creating a Hashtable using collection-initializer syntax
        var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        foreach (DictionaryEntry de in cities)
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);





    }
}

