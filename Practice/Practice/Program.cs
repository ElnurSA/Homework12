﻿
#region homework
//using Practice;

//Generics<Product> products = new Generics<Product>();

//products.Add(new Product { Id = 1, Name = "Iphone", Price = 3000 });
//products.Add(new Product { Id = 2, Name = "Samsung", Price = 1000 });
//products.Add(new Product { Id = 3, Name = "Sony", Price = 500 });



//var rets = products.GetById(2);

//Console.WriteLine(rets.Name);

//var result = products.Delete(2);

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);

//}

//var res = products.ShowAll();

//foreach (var item in res)
//{
//    Console.WriteLine($"Name: {item.Name}");
//}

//using Practice.Exceptions;

//try
//{
//    int num = 0;
//    int factorial = 1;

//    if(num < 0)
//    {
//        throw new LessThanZero();
//    }

//    for(int i = 0; i < num; i++)
//    {
//        factorial *= i;
//    }
//    Console.WriteLine(factorial);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
#endregion 

//using Practice.Models;

//Animal animal = new Animal();

//Fish fish = new Fish();

//fish.Sound();

//Bird bird = new Bird();


//Animal animal2 = fish;

//Animal animal3 = bird;

//Bird bird2 = (Bird)animal;

//Bird bird3 = (Bird)fish;



//Animal[] datas = { animal, fish, bird, animal2, animal3, bird2 };

//foreach (var item in datas)
//{
//    item.Name = "XXX";
//    Console.WriteLine(item.Name);
//}


//int num1 = 5;

//object obj = num1;

//int num2 = (int)obj;

//bool isMarried = false;

//object data = isMarried;

//bool test = (bool)data;

//string name = "Test";

//object data2 = name;

//string name2 = data2.ToString();

using Practice;
using Practice.Controllers;
using Practice.Models;

//int num1 = 5;

//double num2 = num1;

//int a1 = 200;

//byte a2 = (byte)a1;

//Console.WriteLine(a2);


//Bird bird = new Bird();

//Fish fish = new Fish();

//Animal animal1 = new Bird();

//Animal animal2 = new Fish();

//object[] datas = { 1, 2, bird, "Salam", fish, animal1, 100, animal2 };

//foreach (var data in datas)
//{
//    if (data is Animal t)
//    {
//        t.Name = "XXX";
//        Console.WriteLine(t.Name);
//    }
//    else
//    {
//        Console.WriteLine($"{data} cannot covert");
//    }
//}


//foreach (var data in datas)
//{
//    Animal animal = data as Animal;
//    if(animal != null)
//    {
//        animal.Name = "test";
//        Console.WriteLine(animal.Name);
//    }
//}

//List<int> nums = new List<int>();

//List<int> nums2 = new();

//nums2.Add(100);
//nums2.Add(200);

//nums.Add(5);
//nums.Add(2);
//nums.Add(3);

//nums.AddRange(nums2);

//Console.WriteLine(nums.Count);

//foreach(var item in nums)
//{
//    Console.WriteLine(item);
//}


//List<string> names = new() { "Tunzale", "Arzu", "Semed", "Ilham" };

//for(int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//List<string> emails = new() { "t@gmail.com", "m@code.edu.az", "c@gmail.com" };

//static void CheckEmail(string email, List<string> emails)
//{
//    if (emails.Contains(email))
//    {
//        Console.WriteLine("yes");
//    }
//    else
//    {
//        Console.WriteLine("no");
//    }
//}

//CheckEmail("c@gmail.com", emails);

//List<Product> products = new List<Product>();

//products.Add(new Product { Id = 1, Name = "iPhone", Price = 3000 });
//products.Add(new Product { Id = 2, Name = "Samsung", Price = 2000 });
//products.Add(new Product { Id = 3, Name = "Nokia", Price = 300 });

//foreach (var item in products)
//{
//    Console.WriteLine(item.Name);
//}

//static List<Product> Search(string str, List<Product> products)
//{
//    //var datas = products.FindAll(m => m.Name.Contains(str));
//    return products.Where(m => m.Name.Contains(str)).ToList(); 

//}

List<int> nums = new() { 1, 2, 3, 4, 5, 6, 9, 100 };

//for (int i = 0; i < nums.Count; i++)
//{
//    if (i <= 4)
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine(nums[i]);
//    }
//}

//for (int i = 0; i < nums.Count; i++)
//{
//    int index = nums.IndexOf(5);

//    if(i <= index)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}


//ProductController productController = new();

////productController.GetById();

//productController.GetAll();

//Console.WriteLine("-------------");

//productController.Sorting();