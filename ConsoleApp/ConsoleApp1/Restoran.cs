using finalproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Restoran
    {
        private string _restoranName;
        public List<Menu> yemekler;


        

        public Restoran(string RestoranName)
        {
            this._restoranName = RestoranName;
            yemekler = new List<Menu>();
        }
        public string restoranNam
        {
            get { return _restoranName; }
        }


        public void Addfood(string foodName,int quantity)
        {
            Menu m = new Menu();
            m.Foodname = foodName;
            m.Quantity = quantity;
            yemekler.Add(m);
        }
        public void AddOrder()
        {

            Console.WriteLine("Yemeyin adini daxil edin:");
            string a = Console.ReadLine();
            Menu c = this.yemekler.Find(d => d.Foodname.ToLower() == a.ToLower());
            if (c != null)
            {
                Console.WriteLine("Elave etmek istediyiniz porsiyani daxil edin:");
                try
                {
                    int b = Int32.Parse(Console.ReadLine());
                    c.Quantity += b;
                    Console.WriteLine("Ugurla elave olundu");

                }
                catch (Exception)
                {
                    Console.WriteLine("Siz yalniz reqem daxil etmelisiniz");
                   
                }
             
            }
            else
            {
                Console.WriteLine("Porsiyani daxil edin:");
                try
                {
                    int b = Int32.Parse(Console.ReadLine());
                    this.Addfood(a, b);
                    Console.WriteLine("Ugurla elave olundu");

                }
                catch (Exception)
                { 
                    Console.WriteLine("Siz yalniz reqem daxil ede bilersiniz ");
                }
             
            }
        }
       
        public void OrderFood()
        {
            Console.WriteLine("Sifaris etmek istediyiniz yemeyin adini daxil edin:");
            string d = Console.ReadLine();

            Menu c = this.yemekler.Find(m => m.Foodname.ToLower() == d);
            if (c != null)
            {
                if (c.Quantity != 0)
                {
                    Console.WriteLine("Yoxlanilir...");
                    if (d != null)
                    {
                        Console.WriteLine("Yemek porsiyonunu daxil edin");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (c.Quantity >= n)
                        {
                            c.Quantity -= n;
                            Console.WriteLine("Sifarisiniz qebul edildi");
                            Console.WriteLine($"Qalan yemek sayi { c.Quantity}");
                        }
                        else
                        {
                            Console.WriteLine("Sifaris etdiyiniz yemekden kifayet qeder yoxdur");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sifaris etmek isdediyiniz yemek artiq bitib"); 
                    }
                }
                else
                {
                    Console.WriteLine("Sifariz etmek isdediyiniz yemek artiq  bitib");
                }
            }
            else
            {
                Console.WriteLine("Bu yemek bizim menyumuzda yoxdur");
            }
        }
        public void ShowMenu()
        {
            if (yemekler.Count == 0)
            {
                Console.WriteLine("Menyuya yemek elave olunmayib ");
            }
            else
            {
                foreach (var item in yemekler)
                {
                    Console.WriteLine($"Yemeyin adi: {item.Foodname},Yemeyin porsiyonu: {item.Quantity}");
                }
            }
        }

    }
}
