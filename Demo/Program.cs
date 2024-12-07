namespace Demo
{

    class person()
    {
        public int id;
        public string name;
        public int age;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region If / Switch numeric type 1 
            //Console.WriteLine("please enter the number of monthe in th first quarter ");
            //int monthNum = int.Parse(Console.ReadLine());

            //if (monthNum == 1) {
            //    Console.WriteLine("January");
            //}

            //else if (monthNum == 2)
            //{
            //    Console.WriteLine("feburary");
            //}
            //else if (monthNum == 3)
            //{
            //    Console.WriteLine("march");


            //}
            //else
            //{

            //    Console.WriteLine("invalud month number in the first condition ");
            //}
            //switch (monthNum)
            //{
            //    case 1:
            //        Console.WriteLine("january");
            //        break;
            //    case 2:
            //        Console.WriteLine("february");
            //        break;
            //    case 3:
            //        Console.WriteLine("march");
            //        break;
            //    default:
            //        Console.WriteLine("invalid Month number in first quarter");
            //        break;
            //}
            #endregion

            #region  If / Switch numeric type 2

            //Console.WriteLine("pLEASE EBTER YOUR AGE");
            //int age;
            //int.TryParse(Console.ReadLine(), out age);

            //if (age > 22)
            //{
            //    Console.WriteLine("your age is > 22 ");
            //}
            //else if (age< 22)
            //{
            //    Console.WriteLine("your age is < 22 ");
            //}
            //else 
            //{
            //    Console.WriteLine("your age is = 22 ");
            //}

            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("your age is > 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("your age is < 22");
            //        break;
            //    default:
            //        Console.WriteLine("your age is = 22");
            //        break;
            //}

            #endregion

            #region video 3 If / switch string type

            Console.WriteLine("please enter a name ");
            string name = Console.ReadLine();

            //if (name == "Mariam")
            //{
            //    Console.WriteLine("Hello Mariam");

            //}
            //else if (name == "Omar")
            //{
            //    Console.WriteLine("Hello Omar");

            //}
            //else if (name == "Omina")
            //{
            //    Console.WriteLine("Hello Omina");

            //}
            //else if (name == "Mohammed")
            //{
            //    Console.WriteLine("Hello Mohammed");

            //}
            //else if (name == "kareem")
            //{
            //    Console.WriteLine("Hello Kareem");

            //}

            switch (name)
            {
                case "Mariam":
                    Console.WriteLine("Hello Mariam");
                    break;
                case "Omar":
                    Console.WriteLine("Hello Omar");
                    break;
                case "Omina":
                    Console.WriteLine("Hello Omina");
                    break;
                case "Mohammed":
                    Console.WriteLine("Hello Mohammed");
                    break;
                case "Kareem":
                    Console.WriteLine("Hello Kareem");
                    break;

            }


            #endregion

            #region Swich and go to 
            //Console.WriteLine("please enter your salary [3000] ,[2000],[1000] ");
            //int salary = int.Parse(Console.ReadLine());

            //switch (salary) 
            //{ 
            //    case 3000:
            //        Console.WriteLine("option 3 ");
            //        //Console.WriteLine("option 2");
            //        //Console.WriteLine("option 1");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("option 2");
            //        goto case 1000;

            //    case 1000:

            //        Console.WriteLine("option 1");
            //        break;

            //    default:
            //        Console.WriteLine("invalid");
            //        break;




            //}

            #endregion

            #region Swich in c#7 

            object input;
            input = new object();
            input = 4;//Boxing 
            input = new person() { id = 12, name = "Joo" };

            switch (input)

            {
                case int localInput when localInput > 5 && localInput < 20:   //local input is a copy of input 
                    Console.WriteLine($"int input{localInput}");
                    break;
                case double localInput:
                    Console.WriteLine($"double  input{localInput}");
                    break;
                case person localInput:
                    Console.WriteLine($"Person input{localInput}");
                    break;

                default:
                    Console.WriteLine($"unknown input");
                    break;  
            }

            #endregion

            #region swich c#8 


  

             string message;

            // switch (option)
            // {
            //     case  "1" :
            //         message = "Option 1";
            //         break;
            //     case "2":
            //         message = "Option 2";
            //         break;
            //     case "3":
            //         message = "Option 3";
            //         break;
            //     default:
            //         message = "invalid";
            //         break ;



            // }

            // message = option switch
            // {
            //     "1" => "option 1",
            //     "2" => "option 1",
            //     "3" => "option 1",
            //     _ => "option 1"
            // }; ;

            //person person1 = new person() { id = 100, name = "Mariam", age = 22 };

            //switch (person1)
            //{
            //    case { id: 100, name: "Mariam", age: 22 }:
            //        Console.WriteLine("your name is Mariam and your age is 22");
            //        break;
            //    case { id: 200, name: "Joo", age: 30 }:
            //        Console.WriteLine("your name is Joo and your age is 30");
            //        break;
            //    default:
            //        Console.WriteLine("you are 8areeb");
            //        break;

            //}

            //message = person1 switch
            //{
            //    { id: 100, name: "Mariam", age: 22 } => "your name is Mariam and your age is 22 ",
            //    { id: 200, name: "Joo", age: 30 } => "your name is Joo and your age is 30",
            //    _ => "you are 8areeb"
            //};
            //Console.WriteLine(message);

            #endregion

            #region  swich in  c#9 


            //person person1 = new person() { id = 100, name = "Joo", age = 22 };

            //switch (person1)
            //{
            //    case { id: 100, name: "Joo", age:> 22 and > 50 }:
            //        Console.WriteLine("your name is Joo and your age is 22");
            //        break;
            //    case { id: 200, name: "Joo", age: 30 }:
            //        Console.WriteLine("your name is Joo and your age is 30");
            //        break;
            //    case { age: < 20 and < 40 }:
            //        Console.WriteLine("your age is between 20 and 40");
            //        break;
            //    default:
            //        Console.WriteLine("you are 8areeb");
            //        break;

            //}

            //message = person1 switch
            //{
            //    { id: 100, name: "Joo", age: 22 } => "your name is Joo and your age is 22 ",
            //    { id: 200, name: "Maro", age: 30 } => "your name is Maro and your age is 30",
            //    _ => "you are 8areeb"
            //};
            //Console.WriteLine(message);

            #endregion


            #region loop statments 

            Console.WriteLine(1 + 100);
            Console.WriteLine(2 + 100);
            Console.WriteLine(3 + 100);
            Console.WriteLine(4 + 100);
            Console.WriteLine(5 + 100);
            Console.WriteLine(6 + 100);
            Console.WriteLine(7 + 100);
            Console.WriteLine(8 + 100);
            Console.WriteLine(9 + 100);
            Console.WriteLine(10 + 100);

            Console.WriteLine("*******************************************");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }



            #endregion

            #region  for each

            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);


            }
            Console.WriteLine("*********************************************");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }

            #endregion

            #region  while - do while 
            int number;
            bool flag;
            do
            {
                Console.WriteLine("please enter an even number ");
                flag = int.TryParse(Console.ReadLine(), out number);

            } while (number % 2 == 1 || !flag);


            #endregion

            #region String 

            ////string name;
            //////clr 4 bytes in stack and 0 in heap
            ////name = new string("Joo");
            ////name =" Joo";
            //////Clr will allocated 5 * 2 places in heap 
            ////Console.WriteLine(name);
            ////Console.WriteLine(name.GetHashCode());

            ////string name2 = "Joo";
            ////Console.WriteLine(name2.GetHashCode()); // will refer the same place in heap


            string name1 = "Joo", name2 = "<Joo2>";

            Console.WriteLine(name1);
            Console.WriteLine(name1.GetHashCode());

            Console.WriteLine(name2);
            Console.WriteLine(name2.GetHashCode());

            name2 = name1;

            Console.WriteLine("after =");

            Console.WriteLine(name1);
            Console.WriteLine(name1.GetHashCode());

            Console.WriteLine(name2);
            Console.WriteLine(name2.GetHashCode());

            name1 = "Joo Ahmed";

            Console.WriteLine("after change");
            Console.WriteLine(name1);
            Console.WriteLine(name1.GetHashCode());

            Console.WriteLine(name2);
            Console.WriteLine(name2.GetHashCode()); 






            #endregion


            #region string builder 




            //StringBuilder name1 = new StringBuilder("Joo");

            //StringBuilder name2 = new StringBuilder("Maro");

            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());

            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());

            //name2 = name1;

            //Console.WriteLine("after =");

            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());

            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());

            //name1.Append("Mohammed");

            //Console.WriteLine("after append");
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());

            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode()); // will change

            // StringBuilder message = new StringBuilder();
            // message.Append("Hello, ");
            // Console.WriteLine(message);
            //Console.WriteLine( message.GetHashCode());

            // message.Append("World, ");
            // Console.WriteLine(message);
            // Console.WriteLine(message.GetHashCode());


            // message.AppendLine("Hello");
            // message.AppendLine("Joo");
            // Console.WriteLine(message);
            // message.Insert(0, "first");
            // Console.WriteLine(message);
            // message.Remove(0, 5);
            // Console.WriteLine(message);
            // message.Replace("H", "M");
            // Console.WriteLine(message);
            // message.Clear();


            #endregion


            #region  1D array
            //int[] numbers;
            ////no memory in heap yet , referse to null 
            //// Clr allocated 4 bytes in stack and 0 in heap

            //numbers = new int [4]; // 16 bytes in heap 

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] Numbers1 = new int[] { 10, 20, 30, 40 };

            //int[] Numbers2 = new int[] { 10, 20, 30, 40 };

            //Numbers1[4] = 50; //out of range

            //int[] Numbers3 = { 10, 20, 30, 40 }; //only inline 


            ////int[] Numbers4;
            ////Numbers4 = { 10,20,30,40}

            //for (int i = 0; i < Numbers3.Length; i++)
            //{

            //    Console.WriteLine(Numbers1[i]);
            //}

            //Console.WriteLine($"array dimestions =>{Numbers3.Rank} ");




            #endregion

            #region  2D arrays 
            int[,] marks = new int[3, 5];//clr will allocate 3 * 5 * 4 in heap                                   


            marks[0, 0] = 90;
            marks[0, 1] = 88;
            marks[0, 2] = 99;
            marks[0, 3] = 100;
            marks[0, 4] = 88;


            marks[1, 0] = 90;
            marks[1, 1] = 88;
            marks[1, 2] = 99;
            marks[1, 3] = 100;
            marks[1, 4] = 88;

            marks[2, 0] = 90;
            marks[2, 1] = 88;
            marks[2, 2] = 99;
            marks[2, 3] = 100;
            marks[2, 4] = 88;

            bool flag1;
            int grade;

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($"please enter the greades for student number {i + 1} ");
                for (int j = 0; j < marks.GetLength(1);)

                {
                    Console.WriteLine($"please enter the greades for subject number {j + 1} ");

                    //flag = int.TryParse (Console.ReadLine(), out grade); 
                    //if (flag)
                    //{
                    //    j++;
                    //    marks[i,j] = grade;
                    //}

                    j = int.TryParse(Console.ReadLine(), out grade) ? ++j : j; // will fail in case of Getlength

                    marks[i, j] = grade;



                }
                Console.WriteLine("-------------------------------------------------------");
            }

            Console.WriteLine(marks.Length);
            Console.WriteLine(marks.Rank);




            #endregion

        }


    }




    
}
