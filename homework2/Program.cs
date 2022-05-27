using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5 };
            AddValue(ref numbers, 12);
            Console.WriteLine("numbers");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            char[] name = { 'H', 'i', 'k', 'm', 'e', 't', ' ', 'A', 'b', 'b', 'a', 's', 'o', 'v' };
            string str = "";
            foreach (  var item in name)
            {
                str += item;
            }
            Console.WriteLine(str);
            int[] nums = { -9, -3, -8, -5 };
            int[] NewList = {}




        }//Parameter olaraq integer array variable-i ve bir integer value
         //qebul eden ve hemin integer value-nu integer array-e yeni element
         //kimi elave eden metod.
         static void AddValue( ref int[] numbers,int value)
        {
            int[] newArray = new int[numbers.Length + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i];
            }
            newArray[newArray.Length - 1] = value;

           numbers = newArray;


        }// Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri əvvəlində və sonunda boşluqlar qalmayacaq hala gətirən metod.Misal olaraq, name =
         // " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda
         // göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.
         static void BuildWord( ref string str ,char[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                str += name[i];
            }
        }//Qəbul etdiyi ədədi musbətə ceviren metod
        static void ChangeNumber(ref int m, int n)
        {

            if (m < 0 && n < 0)
                m *= n;

            else if (m > 0)
            {
                Console.WriteLine("eded musbetdir");
            }

            else
            {
                Console.WriteLine("eded 0-a beraberdir ve musbete cevirmek mumkun deyil");

            }
           

        }
        //Qəbul etdiyi ədədlər siyahısının içərisindəki bütün ədədləri müsbət hala gətirən metod
        static int[] ChangeNumbers(ref int[] nums, int d)
        {
           
            for (int i = 0; i < nums.Length; i++)
            {
                while (d < 0)
                {
                    nums[i] *= d;
                }
            }

            
            
            
        }


    }
}
