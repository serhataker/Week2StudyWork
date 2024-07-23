using System;
using System.ComponentModel.Design;

namespace Week2WorkStudy
{


    class Week2WS
    {

        static void Main(string[] args)
        {
            #region Question/1 give the text write the console with cw
            Console.WriteLine("Hello");
            Console.WriteLine("How Are You?");
            Console.WriteLine("I am Fine");
            Console.WriteLine("Are You Fine?");
            #endregion

            #region Question/2 give 2 two variables and write to the console with cw
            int a = 12; string b = "Hello";
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");
            #endregion

            #region Question/3 create the random variables and write to the console with cw
            Random Random = new Random();
            int Rnd = Random.Next();
            Console.WriteLine($"Random Value:{Rnd}");
            #endregion

            #region Question/4 create the random variables and divide by 3 overall value  write to the console with cw
            Random Random1 = new Random();
            int Rand = Random1.Next();
            int OverAll = Rand % 3;
            Console.WriteLine($"Random Value:{Rand} divide by 3 OverAll:{OverAll}");
            #endregion

            #region Question/5 Ask the user how old are you if he/she>18 write + else -
            Console.WriteLine("How Old Are You");
            int Age = Convert.ToInt16(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
            #endregion

            #region Question/6 Write to the sceen 10 "When you live life current like Vodafone i don't pull like Turkcell everywhere"
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("When you live life current like Vodafone i don't pull like Turkcell everwhere");

            }
            #endregion

            #region Question/7 input two string and replace each other number1 to number2
            string Name3;
            Console.WriteLine("Please input the Acttress names");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Please input the Acttress names");
            string Name2 = Console.ReadLine();

            Name3 = Name1;
            Name1 = Name2;
            Name2 = Name3;
            Console.WriteLine($"1. Input Names:{Name1} 2.Input Names:{Name2}"); // "Bu bir deneme metindir."
            #endregion

            #region Question/8 Dont give the return value method
            BenDegerDondurmem();
            void BenDegerDondurmem()
            {
                Console.WriteLine("I don't return the value, i don't have anything return, please dont assignt to me variable. ");
            }
            #endregion

            #region Question/9 input to the 2 numbers and sum them returns method
            int Sum2 = Sum2Numbers(12, 13);
            Console.WriteLine(Sum2);
            int Sum2Numbers(int A, int B)
            {
                return A + B;
            }
            #endregion

            #region Question/10 input bool variables and retrun the string value

            Console.WriteLine("Please send to me True or false value");
            string UI = Console.ReadLine();

            if (UI.ToUpper() == "TRUE" || UI.ToUpper() == "FALSE")
            {
                bool boolValue = bool.Parse(UI); // replace the string value to boolean
                string Ans = BoolDegisken(boolValue);//  call the method
                Console.WriteLine($"Return Value: {Ans}");
            }
            else
            {
                Console.WriteLine("please  'true' or 'false' value input.");
            }


            static string BoolDegisken(bool Name)
            {

                return Name.ToString();
            }
            #endregion

            #region Question/11 input the 3 variables and retrun max variable 


            Console.WriteLine("Please send to me first value");
            int x = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please send to me second value");
            int y = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please send to me third value");
            int z = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Max number:{MaxFind(x, y, z)}");


            static int MaxFind(int x, int y, int z)
            {
                if (x > y && x > z)
                    return x;
                else if (y > x && y > z)
                    return y;
                else
                    return z;
            }
            #endregion

            #region Question/12 take the user input the endless variables these variables and retrun max variable 


            Console.WriteLine("Please send to value:");
            int maxNumber = MaxNumberFound();
            Console.WriteLine($"Max Number:{maxNumber}"); 
          


            static int MaxNumberFound()
            {
                int max = int.MinValue;
                while (true)
                {
                    string val1 = Console.ReadLine();

                    if (val1 == "e")
                    {
                        break;
                    }
                    int number;
                    bool isNumber = int.TryParse(val1, out number);
                    if (isNumber)
                    {

                        if (number > max)
                        {
                            max = number;
                        }

                        else
                        {
                            Console.WriteLine("inavlid value please input the 'e' over.");
                        }

                    }
                }
                    return max;
                
            }

            #endregion
            #region Question/ 13 Change the two variable

            Console.WriteLine("Please enter value1:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Please enter value2:");
            string name2 = Console.ReadLine();

            ChangeName(ref name1, ref name2);

            Console.WriteLine($"After change names: {name1}, {name2}");



            void ChangeName(ref string name1, ref string name2)
            {
                string temp = name2;
                name2 = name1;
                name1 = temp;
            }

            #endregion

            #region Question/ 14 Enter The number is it double true or false?

            Console.WriteLine("Please send to the number");
            int number = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(SingleDouble(number));

            Boolean SingleDouble(int Number)
            {
               if(Number % 2==0)

                { return  true; 
                
                 
                }
               else { return false;
                
                }
            }

            #endregion

            #region Question/ 15 It is take the user speed and time it is calculated the way to go


            Console.WriteLine("Please send to the your speed:");
          int speed1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Please send to the your drive time:");
            int time1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your estimate:{Waytogo(speed1,time1)} KM");

            int  Waytogo(int speed, int time)
            {

                int value = speed * time;
                return value;
                
            }

            #endregion

            #region Question/ 16  Send to the radius and calculate the circle

            Console.WriteLine("Please send to the me your radius:");
           double radius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of ​​the circle:{Circle(radius1)}");

           static double Circle(double r)
            {
                double pi = Math.PI;
               return (double)Math.Pow(r,2)*pi;

            }

            #endregion
            #region Question/ 17  Give the text and full return the full small caharcter and big charcter


            BigSmall();

           void BigSmall()
            {
                string BigSmall = "Zaman bir GeRi SayIm";
                Console.WriteLine(BigSmall.ToLower());
                Console.WriteLine(BigSmall.ToUpper());

            }

            #endregion  
            
            #region Question/ 18  Give the text and delete the space charcter

            Delete();

           void Delete()
            {
                string TrimWord = "   Selamlar   ";
                Console.WriteLine(TrimWord.Trim());

            }

            #endregion

        }
    }
}