using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Resolvers;

namespace Problem

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prob_01
            // Write a program and ask the user to enter a number.The number should
            //be between 1 to 10.If the user enters
            /// a valid number, display "Valid" on the console. Otherwise, display 
            //"Invalid". (This logic is used a lot in

            //Console.WriteLine("Enter your number ");
            //var num= int.Parse(Console.ReadLine());
            //if (num >= 1 && num <= 10) Console.WriteLine("Valid");
            //else Console.WriteLine("Invalid");
            //....................................................................
            // Problem 02
            //Write a program which takes two numbers from the console and displays 
            // the maximum of the two.

            //Console.WriteLine("Enter the first number ");
            // var num1= int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            // var num2= int.Parse(Console.ReadLine());
            //Console.WriteLine("The maximum number is " + Math.Max(num1,num2));
            //............................................................................
            //prob03
            //Console.WriteLine("Enter the value of width");
            //var w=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value of height");
            //var h = int.Parse(Console.ReadLine());
            //var resuult = w>h ? ImageOrientation.Landecape : ImageOrientation.portairt;
            //Console.WriteLine(resuult);....................................
            // problen04
            //Console.WriteLine("Enter the speed limit" );
            //var speedlimit=int.Parse(Console.ReadLine());
            //Console.WriteLine("What is your speed of car ");
            //var carspeed= int.Parse(Console.ReadLine());
            //var result = (carspeed - speedlimit)/5;
            //if (speedlimit > carspeed) Console.WriteLine("Ok");
            //else
            //{
            //    if (result > 12) Console.WriteLine("Lincences Spspended");
            //    else
            //    Console.WriteLine(" Right now you have" +"  "+ result+ " demerit");



            //}................Set 1 Completed 
            // problem based on loop 
            //Problem01
            //var count = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if(i%3==0) count++;
            //}
            //Console.WriteLine(count);
            // problem02
            //Console.WriteLine("Enter the number ");
            //var count = 0;
            //while (true)
            //{
            //    var enter = Console.ReadLine();
            //    if(enter =="ok")
            //        break;
            //    else
            //    {
            //    var a= int.Parse(enter);
            //        count += a;
            //                        }
            //}



            //Console.WriteLine(" the sum of total number is " +"  " +count);
            // Problem 03
            //Console.WriteLine("Enter the number ");
            //var fact = int.Parse(Console.ReadLine());
            //var Count = 1;
            //for (int i = 1; i <= 8; i++)
            //{
            //    Count *= i;
            //}
            //Console.WriteLine(Count);
            //// Problem 03
            //Console.WriteLine("Enter your uss number");
            //var randomnumber= new Random();
            //for (int i = 0; i <= 4; i++)
            //{
            //var gussnumber=int.Parse(Console.ReadLine());
            //   var finalnumber=randomnumber.Next(1,10);
            //    Console.WriteLine(finalnumber);
            //    if (gussnumber == finalnumber)
            //    {
            //        Console.WriteLine("you won ");
            //    }
            //    else
            //    {

            //        Console.WriteLine("you loss");
            //    }


            //}.................................................................
            // Problem 05
            //Console.WriteLine("Enter the string sepratdby comma ");
            //var list = new List<int>();
            //string[]  str = Console.ReadLine().Trim().Split(',');
            //foreach (string i in str)
            //{
            //    list.Add(int.Parse(i));
            //}
            //Console.WriteLine("THE MAX NUMBER IS "+"  "+ list.Max());
            // Set 3 Data structure .................................................
            // Console.WriteLine("Enter your name :");
            // var name = Console.ReadLine();
            // var  arr = new char [name.Length] ;
            // var reversestring = arr.ToString();
            //     reversestring.Reverse();
            // Console.WriteLine(reversestring);
            //foreach (char c in reversestring)
            // {
            //     Console.WriteLine(c);
            // }
            // problem 02
            //var list = new List<string>();
            // while (true)
            // {
            //     Console.WriteLine("Enter the name ");
            //     var str= Console.ReadLine();
            //     if(string.IsNullOrEmpty(str)) 
            //         break;
            //     else
            //     {
            //         list.Add(str);
            //     }
            //     continue;
            // }
            // if (list.Count == 1)
            // {
            //     Console.WriteLine(list[0] + "  " + " Likes your Post ");
            //     if (list.Count == 2) Console.WriteLine(list[0], list[1] + " likes your piost");
            //     else
            //     {

            //         Console.WriteLine(list[0], list[1], list.Count - 2 + " likes your post");
            //     }
            // }......................................................................................
            //prob03
            //var list = new List<int>();
            // while (list.Count <= 5)
            // {
            //     Console.WriteLine("Enter the number");
            //     var num = int.Parse(Console.ReadLine());
            //     if (list.Contains(num))
            //     {
            //         Console.WriteLine("retray");

            //         continue;
            //     }
            //     else
            //     {
            //         list.Add(num);
            //     }
            // }
            //   list.Sort();
            //   foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }...............................................................................
            // prob04
            //var list1=new List<int>();
            // var list2=new List<int>();
            // while (true)
            // {
            //     Console.WriteLine("enter your number");
            //     var num = Console.ReadLine();
            //     if (num == "ok") break;
            //      list1.Add(int.Parse(num));
            // }
            // list1.Sort();
            // for (int i = 0; i < list1.Count; i++)
            // {



            //     list2.Add(i);
            //     if (list2.Contains(i))
            //     {
            //         list1.Remove(i);

            //     }
            // }
            // foreach (var i in list2)
            // {
            //     Console.WriteLine(i);
            // }

            //Console.WriteLine("enter the number in the list ");


            //var lst2=new List<int>();
            //var lst = new List<int>();
            //var str = Console.ReadLine().Trim().Split(',');
            //foreach (string i in str)
            //{
            //    lst.Add(int.Parse(i));
            //}
            //if (str.Count() <= 5) Console.WriteLine("invalid list");

            //while (lst2.Count < 3)
            //{
            //    // Assume the first number is the smallest
            //    var min = lst2[0];
            //    foreach (var number in lst)
            //    {
            //        if (number < min)
            //            min = number;
            //    }
            //    lst2.Add(min);
            //    lst.Remove(min);
            //}
            //Console.WriteLine("The 3 smallest numbers are: ");
            //foreach (var number in lst2)
            //           foreach (var item in lst2)
            //{
            //    Console.WriteLine(item);

            //}
            //var datetime = new DateTime(2015, 1, 1);
            //  var currenttimr=DateTime.Now;
            ////Console.WriteLine(datetime);
            //Console.WriteLine(currenttimr);
            //Console.WriteLine("hour" + currenttimr.Hour);
            //var tomarrow= currenttimr.AddDays(1);
            //var yestarday= currenttimr.AddDays(-1);
            //Console.WriteLine(tomarrow);
            //Console.WriteLine(yestarday);
            //var timespan = new TimeSpan(1, 5, 8);
            //    Console.WriteLine(timespan);
            //.......................................................................
            //problem based on data structure(String) 
            //problem 01
            //Console.WriteLine("enter the few number seprated by a hyphen ");
            //var str = Console.ReadLine().Trim().Split('-');
            //var lst= new List<int>();
            //foreach (string s in str)
            //{
            //    lst.Add(int.Parse(s));
            //    Console.WriteLine(s);
            //}

            //for (int i = 1; i < lst.Count; i++)
            //{
            //    if (lst[0] == lst[i+1]) Console.WriteLine("Consecutive");
            //    else Console.WriteLine(lst[i]);

            //}..............................................................................
            // problem 02
            // var lst = new List<int>();
            // while (true)
            // {
            //     Console.WriteLine("Enter the few number seprated by a hyphen");
            //     var input = Console.ReadLine();
            //     if (string.IsNullOrWhiteSpace(input))
            //     {
            //         break;

            //     }
            //     var input2 = input.Trim().Split('-');
            //     foreach (var i in input2)
            //     {
            //         if (lst.Contains(int.Parse(i)))
            //         {
            //             Console.WriteLine("Duplicate");
            //             continue;
            //         }
            //         lst.Add(int.Parse(i));
            //         Console.WriteLine(i);
            //     }

            // }
            //// ..................................................................................Problem 03
            // Console.WriteLine("Enter a time ");
           // .....................................
            // //problem 04
            //Console.WriteLine("Enter the few words");
            //var input = Console.ReadLine();
            //if (string.IsNullOrWhiteSpace(input)) Console.WriteLine("Error");
            //var variablename = " ";
            //foreach (var word in input.Split(' '))
            //{
            //    var wordwithpascalcase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    Console.WriteLine(wordwithpascalcase);
            //    variablename += wordwithpascalcase;
            //}
            //Console.WriteLine(variablename); //.............................................
            //Problem 05
            Console.WriteLine("Enter an English word ");
            var inp = Console.ReadLine().Trim();
            var count = 0;
            var list = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach (var chr in inp)
            {
                if (list.Contains(chr))
                    count++;
            }
            Console.WriteLine(count); //.......................................................................................



            //  Advance Topic
            // hello 

            Console.WriteLine(DateTime.Now);



















            Console.ReadLine();





        }
    }
}
