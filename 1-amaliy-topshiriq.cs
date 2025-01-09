using System;
//String ustida amallar.So'zning uzunligini aniqlash
namespace StringLength
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("So'zni kiriting: ");
            string str = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("So'z uzunligini kiriting: ");
            int uzunligi = Convert.ToInt32(Console.ReadLine());
            if (str.Length < uzunligi)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.ToLower());  
            }      

           //Ternary oparatoridan if-elsega o'tkazish.
           int x = 15;
           int y = 10;

            string result = (x > y) 
              ? "x katta y dan" 
              : (x < y)
                  ? "x kichkina y dan"
                  : (x == y) 
                     ? "x va y teng"  
                     : "x va y ni taqqoslab bo'lmaydi";
            Console.WriteLine(result);  

            //Consoleda o'zbek tilida kiritilgan hafta kunini ingliz tiliga o'girib, natijani 
            //chop etuvchi dastur tuzish.

            Console.WriteLine("Hafta kunini kiriting: "); 
            string haftakun = Console.ReadLine() ?? string.Empty;
            string kun = haftakun.ToLower();
            string natija = kun switch
            {
                "dushanba" => "Monday",
                "seshanba" => "Tuesday",
                "chorshanba" => "Wednesday",
                "payshanba" => "Thursday",
                "juma" => "Friday",
                "shanba" => "Saturday",
                "yakshanba" => "Sunday",
                _ => "Bunday hafta kuni mavjud emas"
            };
            
            Console.WriteLine(natija);

        }
    }
}