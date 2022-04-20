using ConsoleApp21.Data.DAL;
using ConsoleApp21.Data.Entities;
using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Stadion elave et");
            Console.WriteLine("2.Stadionlari goster");
            Console.WriteLine("3.Istifadeci elave et");
            Console.WriteLine("4.Istifadeci goster");
            Console.WriteLine("5.Rezervasiyalari goster");
            Console.WriteLine("6.Rezervasiya yarat");
            Console.WriteLine("7.Verilmis Id-li rezervasiyalari goster");
            Console.WriteLine("8.Verilmis Id-li Userin rezervasiyalarini goster");
            Console.WriteLine("9.Verilmis Id-li rezervasiyani sil");

            bool exit = false;
            do
            {
                Console.WriteLine("1.AddStadion\n3.AddUser\n0.Exit");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Name elave et");
                        string name = Console.ReadLine();
                        Console.WriteLine("HourPrice daxil edin");
                        decimal hourPrice = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Capacity daxil edin");
                        double capacity = double.Parse(Console.ReadLine());
                        AddStadion();
                        break;

                    case "3":
                        Console.WriteLine("Surname elave et");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Email elave et");
                        string email = Console.ReadLine();
                        AddUser();
                        break;

                    case "0":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }

        static void AddStadion()
        {
            using (var contex=new AppDbContext())
            {
                var cmd = new Stadions()
                {
                    Name = "Olimpia",
                    HourPrice=50,
                    Capacity=100
                };
                contex.Stadions.Add(cmd);
                contex.SaveChanges();
            }
        }

        static void AddUser()
        {
            using (var contex = new AppDbContext())
            {
                var cmd = new Users()
                {
                    Surname = "Zeynalli",
                    Email= "zeynalli023@gmail.ru"                   
                };
                contex.Users.Add(cmd);
                contex.SaveChanges();
            }
        }
    }
}
