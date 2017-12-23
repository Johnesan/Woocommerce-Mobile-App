using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wikeplus_App.Models
{

    public class Orders
    {
        public Order[] orders { get; set; }
    }

    public class Order
    {
        public int id { get; set; }
        public string order_number { get; set; }
        public string order_key { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime completed_at { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public string total { get; set; }
        public string subtotal { get; set; }
        public int total_line_items_quantity { get; set; }
        public string total_tax { get; set; }
        public string total_shipping { get; set; }
        public string cart_tax { get; set; }
        public string shipping_tax { get; set; }
        public string total_discount { get; set; }
        public string shipping_methods { get; set; }
        public Payment_Details payment_details { get; set; }
        public Billing_Address billing_address { get; set; }
        public Shipping_Address shipping_address { get; set; }
        public string note { get; set; }
        public string customer_ip { get; set; }
        public string customer_user_agent { get; set; }
        public int customer_id { get; set; }
        public string view_order_url { get; set; }
        public Line_Items[] line_items { get; set; }
        public object[] shipping_lines { get; set; }
        public object[] tax_lines { get; set; }
        public object[] fee_lines { get; set; }
        public object[] coupon_lines { get; set; }
        public Customer customer { get; set; }
    }

    public class Payment_Details
    {
        public string method_id { get; set; }
        public string method_title { get; set; }
        public bool paid { get; set; }
    }

    public class Billing_Address
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }

    public class Shipping_Address
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }

    public class Customer
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_update { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public int last_order_id { get; set; }
        public DateTime last_order_date { get; set; }
        public int orders_count { get; set; }
        public string total_spent { get; set; }
        public string avatar_url { get; set; }
        public Billing_Address1 billing_address { get; set; }
        public Shipping_Address1 shipping_address { get; set; }
    }

    public class Billing_Address1
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }

    public class Shipping_Address1
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }

    public class Line_Items
    {
        public int id { get; set; }
        public string subtotal { get; set; }
        public string subtotal_tax { get; set; }
        public string total { get; set; }
        public string total_tax { get; set; }
        public string price { get; set; }
        public int quantity { get; set; }
        public string tax_class { get; set; }
        public string name { get; set; }
        public int product_id { get; set; }
        public string sku { get; set; }
        public object[] meta { get; set; }
    }

}
