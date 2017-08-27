using System;
using SpyStore_HOL.DAL.EF.Initialization;
using SpyStore_HOL.DAL.Repos;

namespace SpyStore.ConsoleDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new ShoppingCartRepo(new ProductRepo());
            //StoreDataInitializer.ClearData(_repo.Context);
            StoreDataInitializer.InitializeData(_repo.Context);
            Console.ReadLine();
        }
    }
}
