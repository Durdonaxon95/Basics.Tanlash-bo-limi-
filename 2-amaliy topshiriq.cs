// Vaqt kalkulyatori. Daqiqani soatga o'zgartirish.
using System;
 namespace KichikDasturlar
  { 
   class Program

     { 
     static void Main(string[] args)
     {
         Console.WriteLine("Daqiqani kiriting: ");
         int daqiqa = Convert.ToInt32(Console.ReadLine());
         int soat = daqiqa/60;
         int qoldiqdaqiqa = daqiqa%60;
          
         Console.WriteLine($"{daqiqa} daqiqa = {soat}:{qoldiqdaqiqa}") ; 



         Console.Write("Yoshingizni kiriting: ");
            int yosh = Convert.ToInt32(Console.ReadLine());
             
            if( yosh<0) 
             {
                Console.WriteLine("Yoshingizni noto'g'ri kiritdingiz!");

             }
            else if(yosh<=12) 
            {
                Console.WriteLine("Siz bola toifasidasiz!");

            }
            else if(yosh<=18) 
            {
                Console.WriteLine("Siz o'smir toifasidasiz!");

            }
            else if(yosh<=59) 
            {
                Console.WriteLine("Siz kattalar toifasidasiz!");

            }
            else 
            { 
                Console.WriteLine("Siz katta yoshlisiz!");

            }
            Console.WriteLine("Dastur tugadi!");

           //O'rtacha ballni hisoblash.
              int ball1 = ortacha("1-fan");
                int ball2 = ortacha("2-fan");
                 int ball3 = ortacha("3-fan");

                double ortachaball = (ball1+ball2+ball3)/3;
                
                static int ortacha(string fan)
                {
                    int ball;
                    while(true)
                    {
                        Console.Write($"{fan} uchun ballingizni kiriting (0-100): ");
                        ball = Convert.ToInt32(Console.ReadLine());
                        if(ball>=0 && ball<=100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Noto'g'ri qiymat kiritdingiz!|\nQaytadan kiriting: ");
                        }
                    }
                    return ball;
                }
                 string natija = (ortachaball<=40) 
                 ? "Qoniqarsiz" 
                 : (ortachaball<=60)
                    ? "Qoniqarli"
                    : (ortachaball<=80)
                        ? "Yaxshi"
                        : "A'lo";
                Console.WriteLine($"Sizning o'rtacha ballingiz: {ortachaball} \nNatija: {natija}");
                Console.WriteLine("Dastur tugadi!");

           //"Raqamni toping" o'yini.
               Random random = new Random();
                int son = random.Next(1, 100);
                int taxmin = 0;
                int urinish = 0;
                Console.WriteLine("1 dan 100 gacha bo'lgan sonni toping!");
                while(taxmin!=son)
                {
                    Console.Write("Sonni kiriting: ");
                    taxmin = Convert.ToInt32(Console.ReadLine());
                    urinish++;
                    string oyin = (taxmin>son)
                        ? "Kichikroq son kiriting!"
                        : (taxmin<son)
                            ? "Kattaroq son kiriting!"
                            : $"Tabriklaymiz! {urinish} ta urinishda topdingiz!";
                    Console.WriteLine(oyin);

                }

                Console.WriteLine($"O'yin soni: {son} edi!");
                
                Console.WriteLine("Dastur tugadi!");                  
            
      
           }


    }
 }

