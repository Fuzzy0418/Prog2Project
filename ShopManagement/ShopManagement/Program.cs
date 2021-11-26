using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace ShopManagement
{
    static class Program
    {
        // CONST variables
        public static readonly NameValueCollection CONFIG = ConfigurationManager.AppSettings;
        public static dbConnect CONNECTION = new dbConnect(CONFIG.Get("cString"));
        public static List<users> USERS = new List<users>();
        public static List<products> PRODUCTS = new List<products>();
        public static List<categories> CATEGORIES = new List<categories>();

        [STAThread]
        static void Main()
        {
            // LOAD CATEGORIES
            List<Dictionary<String, Object>> resultCategories = CONNECTION.Select($"SELECT * FROM {CONFIG.Get("categoryDB")}");
            categories c_field = new categories();
            for (int i = 0; i < resultCategories.Count; i++)
            {
                c_field.id = int.Parse(resultCategories[i]["id"].ToString());
                c_field.name = resultCategories[i]["name"].ToString();
                c_field.isModify = false;

                CATEGORIES.Add(c_field);

                c_field = new categories();
            }

            // LOAD PRODUCTS
            List<Dictionary<String, Object>> resultProducts = CONNECTION.Select($"SELECT * FROM {CONFIG.Get("productDB")}");
            products p_field = new products();
            for (int i = 0; i < resultProducts.Count; i++)
            {
                p_field.id = int.Parse(resultProducts[i]["id"].ToString());
                p_field.name = resultProducts[i]["name"].ToString();
                p_field.cID = " - ";
                p_field.price = int.Parse(resultProducts[i]["price"].ToString());
                p_field.discount = int.Parse(resultProducts[i]["discount"].ToString());
                p_field.count = int.Parse(resultProducts[i]["count"].ToString());


                foreach (var category in CATEGORIES)
                {
                    if (category.id == int.Parse(resultProducts[i]["cID"].ToString()))
                    {
                        p_field.cID = category.name;
                        break;
                    }
                }

                PRODUCTS.Add(p_field);
                p_field = new products();
            }

            //LOAD users
            List<Dictionary<String, Object>> resultUsers = CONNECTION.Select($"SELECT * FROM {CONFIG.Get("usersDB")}");
            users u_field = new users();

            for (int i = 0; i < resultUsers.Count; i++)
            {
                u_field.id = int.Parse(resultUsers[i]["id"].ToString());
                u_field.name = resultUsers[i]["name"].ToString();
                u_field.role = resultUsers[i]["role"].ToString();
                u_field.username = resultUsers[i]["username"].ToString();

                USERS.Add(u_field);

                u_field = new users();
            }

            // MAIN
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginBG());
        }
    }
}
