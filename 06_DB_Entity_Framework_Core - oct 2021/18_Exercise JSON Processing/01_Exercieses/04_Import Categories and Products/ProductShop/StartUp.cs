using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DataTransferObjects;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        static IMapper mapper;

        public static void Main(string[] args)
        {
            var productShopContex = new ProductShopContext();
            productShopContex.Database.EnsureDeleted();
            productShopContex.Database.EnsureCreated();

            string usersJson = File.ReadAllText("../../../Datasets/users.json");
            string productsJson = File.ReadAllText("../../../Datasets/products.json");
            string categoriesJson = File.ReadAllText("../../../Datasets/categories.json");
            string categoriesProductsJson = File.ReadAllText("../../../Datasets/categories-products.json");

            ImportUsers(productShopContex, usersJson);
            ImportProducts(productShopContex, productsJson);
            ImportCategories(productShopContex, categoriesJson);
            var result = ImportCategoryProducts(productShopContex, categoriesProductsJson);

            Console.WriteLine(result);
        }


        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            //users.json
            InitializeAutomapper();

            var dtoUsers =
                JsonConvert.DeserializeObject<IEnumerable<UserInputModel>>(inputJson);

            var users = mapper.Map<IEnumerable<User>>(dtoUsers);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            //products.json
            InitializeAutomapper();

            var dtoProducts = JsonConvert.DeserializeObject<IEnumerable<ProductInputModel>>(inputJson);
            var products = mapper.Map<IEnumerable<Product>>(dtoProducts);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count()}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            //categories.json

            InitializeAutomapper();

            var dtoCategories = JsonConvert
                    .DeserializeObject<IEnumerable<CategoryInputModel>>(inputJson)
                    .Where(c => c.Name != null)
                    .ToList();

            var categories = mapper.Map<IEnumerable<Category>>(dtoCategories);

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count()}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            //categories-products.json
            InitializeAutomapper();

            var dtoCatProducts = JsonConvert
                .DeserializeObject<IEnumerable<CategoryProductInputModel>>(inputJson);

            var catProducts = mapper.Map<IEnumerable<CategoryProduct>>(dtoCatProducts);

            context.CategoryProducts.AddRange(catProducts);
            context.SaveChanges();

            return $"Successfully imported {dtoCatProducts.Count()}";
        }

        private static void InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            mapper = config.CreateMapper();
        }
    }
}