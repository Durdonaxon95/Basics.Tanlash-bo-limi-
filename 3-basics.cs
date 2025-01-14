using System;
 class Program
 {
        static void Main()
        {
            //Palidrome so'zni aniqlovchi dastur.
            Console.WriteLine("So'zni kiriting: ");
            string? input = Console.ReadLine();
            string kiritilgansoz = input ?? string.Empty;

            string teskari = "";
            for (int i = kiritilgansoz.Length - 1; i >= 0; i--)
            {
                teskari += kiritilgansoz[i];
            }
            if (kiritilgansoz == teskari)
            {
                Console.WriteLine("Palindrom ");
            }
            else
            {
                Console.WriteLine("Palindrom emas");
            }

            //Tempraturani o'giruvchi dastur.
            Console.WriteLine("Selsiyus gradusni kiriting: ");
            double selsiyus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sizga kerak bo'lgan gradusni kiriting(Farengeyt yoki Kelvin): ");
            string gradusnomi = Console.ReadLine() ?? string.Empty;
            switch (gradusnomi)
            {
                case "Farengeyt":
                    double farengeyt = (selsiyus * 9 / 5) + 32;
                    Console.WriteLine("Farengeyt gradus: " + farengeyt);
                    break;
                case "Kelvin":
                    double kelvin = selsiyus + 273.15;
                    Console.WriteLine("Kelvin gradus: " + kelvin);
                    break;
                default:
                    Console.WriteLine("Noto'g'ri gradus nomi kiritildi.");
                    break;
            }


            //Sonlarni tartiblovchi dastur.
            Console.WriteLine("Sonlarni vergul bilan ajratib kiriting: ");
            string sonlarInput = Console.ReadLine() ?? string.Empty;
            int[] sonlar;
            if (!string.IsNullOrEmpty(sonlarInput))
            {
                sonlar = sonlarInput.Split(',').Select(int.Parse).ToArray();
            }
            else
            {
                Console.WriteLine("Hech qanday son kiritilmadi.");
                return;
            }
            Console.WriteLine("Tartiblash turini tanlang:");
            Console.WriteLine("1-O'sish tartibida");
            Console.WriteLine("2-Kamayish tartibida");
             
             int tanlash = Convert.ToInt32(Console.ReadLine());

             switch(tanlash)
             {
                case 1:
                    Array.Sort(sonlar);
                    Console.WriteLine("Sonlar o'sish tartibida:");

                    break;

                case 2: 
                    Array.Sort(sonlar);
                    Array.Reverse(sonlar);
                    Console.WriteLine("Sonlar kamayish tartibida:");

                    break;  
                default:
                    Console.WriteLine("Noto'g'ri tanlov kiritilgan!");
                    return;                
            
             }
             Console.WriteLine(string.Join(",", sonlar));

           //Matndagi belgilar sonini hisoblovchi dastur.

               Console.WriteLine("Matn kiriting: ");
                string matn = Console.ReadLine() ?? string.Empty;
                Dictionary<char, int> belgilar = new Dictionary<char, int>();
                foreach (char belgi in matn)
                {
                    if (belgilar.ContainsKey(belgi))
                    {
                        belgilar[belgi]++;
                    }
                    else
                    {
                        belgilar[belgi] = 1;
                    }
                }
                foreach (KeyValuePair<char, int> belgi in belgilar)
                {
                    Console.WriteLine($"\"{belgi.Key}\": {belgi.Value} marta");
                }    
           

            

            


        }
 }