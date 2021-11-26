using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement
{
    struct products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cID { get; set; }
        public int price { get; set; }
        public int discount { get; set; }
        public int count { get; set; }
        public bool isModify { get; set; }
    }

    struct categories
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isModify { get; set; }
    }

    struct users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string username { get; set; }
    }

    struct billing
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public int total { get; set; }
        public bool isModify { get; set; }
    }

    struct transaction
    {
        public int id { get; set; }
        public string employee { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    /*class products
    {
        private int Id;
        private string Name;
        private string CID;
        private int Price;
        private double Discount;
        private int Count;

        public products() { }

        public products(int id, string name, string cID, int price, double discount, int count)
        {
            this.Id = id;
            this.Name = name;
            this.CID = cID;
            this.Price = price;
            this.Discount = discount;
            this.Count = count;
        }

        public int id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public string cID
        {
            get { return this.CID; }
            set { this.CID = value; }
        }

        public int price
        {
            get { return this.Price; }
            set { this.Price = value; }
        }

        public double discount
        {
            get { return this.Discount; }
            set { this.Discount = value; }
        }

        public int count
        {
            get { return this.Count; }
            set { this.Count = value; }
        }
    }*/

    /*class categories
    {
        private int Id;
        private string Name;

        public categories() { }
        public categories(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
    }*/

    /*class users
    {
        private int Id;
        private string Name;
        private string Role;
        private string Username;

        public users() { }
        public users(int id, string name, string role, string username)
        {
            this.Id = id;
            this.Name = name;
            this.Role = role;
            this.Username = username;
        }

        public int id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public string role
        {
            get { return this.Role; }
            set { this.Role = value; }
        }

        public string username
        {
            get { return this.Username; }
            set { this.Username = value; }
        }
    }*/
}
