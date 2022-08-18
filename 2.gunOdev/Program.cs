using System;

namespace _2.gunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            phone phone1 = new phone();
            phone1.model = "Apple";
            phone1.seriNumber = "16515";
            phone1.seller = "Amazon";
            phone1.score = "85";
            phone1.price = "30000";

            phone phone2 = new phone();
            phone2.model = "Huawei";
            phone2.seriNumber = "527782";
            phone2.seller = "Hepsiburada";
            phone2.score = "100";
            phone2.price = "15000";

            phone phone3 = new phone();
            phone3.model = "Samsung";
            phone3.seriNumber = "7989";
            phone3.seller = "Trendyol";
            phone3.score = "50";
            phone3.price = "10000";

            phone[] phones = new phone[] { phone1, phone2, phone3 };

            foreach (var phone in phones)
            {
                Console.WriteLine("Phone model: "+phone.model);
                Console.WriteLine("Phone seri number: " + phone.seriNumber);
                Console.WriteLine("Phone seller: " + phone.seller);
                Console.WriteLine("Phone score: " + phone.score);
                Console.WriteLine("Phone price: " + phone.price);
            }

            Console.WriteLine("For each bitti");

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine("Phone model: " + phones[i].model);
                Console.WriteLine("Phone seri number: " + phones[i].seriNumber);
                Console.WriteLine("Phone seller: " + phones[i].seller);
                Console.WriteLine("Phone score: " + phones[i].score);
                Console.WriteLine("Phone price: " + phones[i].price);
            }

            Console.WriteLine("for bitti");

            int j = 0;
            while (j < phones.Length)
            {
                Console.WriteLine("Phone model: " + phones[j].model);
                Console.WriteLine("Phone seri number: " + phones[j].seriNumber);
                Console.WriteLine("Phone seller: " + phones[j].seller);
                Console.WriteLine("Phone score: " + phones[j].score);
                Console.WriteLine("Phone price: " + phones[j].price);
                j++;
            }

            Console.WriteLine("While bitti");
        }
    }
    class phone
    {
        public String model { get; set; }
        public String seriNumber { get; set; }
        public String seller { get; set; }
        public String score { get; set; }
        public String price { get; set; }
    }
}
