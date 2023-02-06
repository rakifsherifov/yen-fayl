using System;

namespace ref_char_strıng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3};

            ArrOlcusu(ref numbers, 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(numbers.Length);

            Add(ref numbers, 25);
            Add(ref numbers, 5);
            Add(ref numbers, 2004);


            Console.WriteLine(numbers[numbers.Length - 1]);

            string text = "hello usaqlar";

            Console.WriteLine(HasDigit(text));

            string sentence = "salam usaqlar necesiniz?";

            var newSentence = MakeSentence(sentence);
           
            Console.WriteLine(newSentence);
            Console.WriteLine(SozunSayi(sentence));

            int[] arr = { 25, 5, 2004 };           

            Array.Sort(arr);
            Array.Reverse(arr);


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine(Array.IndexOf(arr, 20));
        }

        //Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod

        static void Add(ref int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            arr = newArr;
        }

        //Verilmis arrayin olcusunu deyisen metod.      
        static void ArrOlcusu(ref int[] arr, int size)
        {
            int[] newArr = new int[size];

            int count = size > arr.Length ? arr.Length : size;
           
            for (int i = 0; i < count; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }

        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }

            return false;
        }

        static int SozunSayi(string str)
        {
            string[] arr = str.Split(' ');

            return arr.Length;
        }

        static string MakeSentence(string str)
        {
            var arr = str.Split(' ');

            string newStr = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                    newStr += arr[i] + " ";
            }

            return newStr.TrimEnd();
        }
    
    }
}
