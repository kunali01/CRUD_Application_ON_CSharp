using FirstDemo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ApplicationInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ProductCRUD crud = new ProductCRUD();
                try
                {
                    int a = 1;
                    do
                    {

                        Console.WriteLine("1.Product List");
                        Console.WriteLine("2.Add Product");
                        Console.WriteLine("3.Modify Product");
                        Console.WriteLine("4.Delete Product");
                        Console.WriteLine("5.Get Product By Id");
                        Console.WriteLine("Select option from above");
                        int op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                List<Product> products = crud.ProductList();
                                Console.WriteLine("Id    Name    Price");
                                foreach (var item in products)
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            case 2:
                                Product p1 = new Product();
                                Console.WriteLine("Enter Id");
                                p1.Id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Name");
                                p1.Name = Console.ReadLine();
                                Console.WriteLine("Enter Price");
                                p1.Price = Convert.ToInt32(Console.ReadLine());
                                crud.AddProduct(p1);
                                Console.WriteLine("Added the product");
                                break;
                            case 3:
                                Product p2 = new Product();
                                Console.WriteLine("Enter existing Id");
                                p2.Id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter new Name");
                                p2.Name = Console.ReadLine();
                                Console.WriteLine("Enter new Price");
                                p2.Price = Convert.ToInt32(Console.ReadLine());
                                crud.ModifyProduct(p2);
                                Console.WriteLine("updated the product");
                                break;
                            case 4:
                                Console.WriteLine("Enter existing Id to delete");
                                int id = Convert.ToInt32(Console.ReadLine());
                                crud.DeleteProduct(id);
                                Console.WriteLine("Deleted the product");
                                break;
                            case 5:
                                Console.WriteLine("Enter existing Id");
                                int id2 = Convert.ToInt32(Console.ReadLine());
                                Product p = crud.GetProductById(id2);
                                Console.WriteLine(p);
                                break;
                        }
                        Console.WriteLine("Press 1 for continue or 0 to exit");
                        a = Convert.ToInt32(Console.ReadLine());
                    }

                    while (a == 1);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}

