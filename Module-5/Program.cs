using System;
using System.Data;

namespace Module_5
{
    class Program
    {

        static void Main(string[] args)
        {
            (string Name, string Lastname, int Age, string[] PetName, int NumbersPets, int NColor, string[] Favcolor) = EnterUser();
            UserScreen(datauser);
            Console.ReadKey();
        }

        static (string Name, string Lastname, int Age, string[] PetName, int NumbersPets, int NColor, string[] Favcolor) EnterUser()
        {
            (string Name, string Lastname, int Age, string[] PetName, int NumbersPets, int NColor, string[] Favcolor) User;

            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            User.Lastname = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами: ");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));
            User.Age = intage;

            Console.WriteLine("Есть ли у вас питомцы (Да/Нет)");
            var result = Console.ReadLine();
            if (result == "Да")

            {
                string pet;
                int intpet;
                do
                {
                    Console.WriteLine("Введите количество питомцев ");
                    pet = Console.ReadLine();
                }
                while (CheckNum(pet, out intpet));
                User.NumbersPets = intpet;
                if (User.NumbersPets >= 0)
                {
                    User.PetName = CreateArrayPets(User.NumbersPets);
                }
                else
                    User.PetName = null;
            }

            //  User.PetName = CreateArrayPets(intpet);
            else
                User.PetName = null;
            User.NumbersPets = 0;



            string color;
            int intcolor;
            do
            {
                Console.WriteLine("Введите количество любимых цветов: ");
                color = Console.ReadLine();
            }
            while (CheckNum(color, out intcolor));

            User.NColor = intcolor;
            if (User.NColor >= 0)
            {
                User.Favcolor = ArrayColor(User.NColor);
            }
            else
                User.Favcolor = null;

            return User;
        }


        static string[] CreateArrayPets(int NumberPets)
        {
            string[] NamesPets = new string[NumberPets];
            for (int i = 0; i < NamesPets.Length; i++)
            {
                Console.WriteLine("Введите имя питомца");
                NamesPets[i] = Console.ReadLine();
            }
            return NamesPets;
        }


        static string[] ArrayColor(int NumberColor)

        {
            string[] MasFavCol = new string[NumberColor];
            for (int i = 0; i < MasFavCol.Length; i++)
            {
                Console.WriteLine("Введите любимые цвета");
                MasFavCol[i] = Console.ReadLine();
            }
            return MasFavCol;
        }


        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }

            {
                corrnumber = 0;
                return true;
            }
        }

        static void UserScreen((string Name, string Lastname, int Age, string[] PetName, int NumbersPets, int NColor, string[] Favcolor) datauser)
        {
            Console.WriteLine($"Ваше имя: \n {datauser.Item1}");
            Console.WriteLine($"Ваша фамилия: \n {datauser.Item2}");
            Console.WriteLine($"Ваш возраст \n {datauser.Item3}");
            Console.WriteLine($"Ваши имена питомцев \n {datauser.Item4}");
            Console.WriteLine($"Ваши любимые цвета \n {datauser.Item7}");
           

        }

        
    }


}
