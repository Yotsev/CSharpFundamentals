using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] goods = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();
            AddingPeopleToList(people, persons);

            List<Product> products = new List<Product>();
            AddingItemsToList(goods, products);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string person = commandArgs[0];
                string product = commandArgs[1];

                Person existingPerson = GetPerson(persons, person);
                Product existingProduct = GetProduct(products, product);

                if (existingPerson != null && existingProduct != null)
                {
                    existingPerson.CanAffordProduct(existingProduct);
                }

                command = Console.ReadLine();
            }

            foreach (Person person in persons)
            {
                if (person.Products.Count>0)
                {
                    List<string> boughtProducts = new List<string>();
                    
                    foreach (Product product in person.Products)
                    {
                        boughtProducts.Add(product.Name);
                    }

                    Console.WriteLine($"{person.Name} - {string.Join(", ", boughtProducts)} ");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
            // Втори варинат с override string ToString() - лоша практика ?
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}
        }

        private static Product GetProduct(List<Product> products, string product)
        {
            foreach (Product item in products)
            {
                if (item.Name == product)
                {
                    return item;
                }
            }

            return null;
        }

        static Person GetPerson(List<Person> persons, string person)
        {
            foreach (Person customer in persons)
            {
                if (customer.Name == person)
                {
                    return customer;
                }
            }

            return null;
        }

        static void AddingItemsToList(string[] goods, List<Product> products)
        {
            foreach (string item in goods)
            {
                string[] goodsInfo = item
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = goodsInfo[0];
                decimal price = decimal.Parse(goodsInfo[1]);

                Product product = new Product
                {
                    Name = name,
                    Cost = price
                };

                products.Add(product);
            }
        }

        static void AddingPeopleToList(string[] people, List<Person> persons)
        {
            foreach (string customer in people)
            {

                string[] customerInfo = customer
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = customerInfo[0];
                decimal money = decimal.Parse(customerInfo[1]);

                Person person = new Person
                {
                    Name = name,
                    Money = money
                };

                persons.Add(person);
            }
        }
    }
}


class Person
{
    public Person()
    {
        Products = new List<Product>();
    }

    public string Name { get; set; }

    public decimal Money { get; set; }

    public List<Product> Products { get; set; }

    public void CanAffordProduct(Product product)
    {
        if (product.Cost <= Money)
        {
            Products.Add(product);
            Money -= product.Cost;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }

    //public override string ToString()
    //{
    //    List<string> items = new List<string>();
        
    //    foreach (Product product in Products)
    //    {
    //        items.Add(product.Name);
    //    }
    //    if (items.Count>0)
    //    {
    //        return $"{Name} - {string.Join(", ", items)}";
    //    }
    //    return $"{Name} - Nothing bought";
    //}
}

class Product
{
    public string Name { get; set; }

    public decimal Cost { get; set; }
}
