using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wikeplus_App.Models
{

    public class Products
    {
        public Product[] products { get; set; }
    }

    public class Product
    {
        public string title { get; set; }
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public bool downloadable { get; set; }
        public bool _virtual { get; set; }
        public string permalink { get; set; }
        public string sku { get; set; }
        public string price { get; set; }
        public string regular_price { get; set; }
        public string sale_price { get; set; }
        public string price_html { get; set; }
        public bool taxable { get; set; }
        public string tax_status { get; set; }
        public string tax_class { get; set; }
        public bool managing_stock { get; set; }
        public object stock_quantity { get; set; }
        public bool in_stock { get; set; }
        public bool backorders_allowed { get; set; }
        public bool backordered { get; set; }
        public bool sold_individually { get; set; }
        public bool purchaseable { get; set; }
        public bool featured { get; set; }
        public bool visible { get; set; }
        public string catalog_visibility { get; set; }
        public bool on_sale { get; set; }
        public string product_url { get; set; }
        public string button_text { get; set; }
        public object weight { get; set; }
        public Dimensions dimensions { get; set; }
        public bool shipping_required { get; set; }
        public bool shipping_taxable { get; set; }
        public string shipping_class { get; set; }
        public object shipping_class_id { get; set; }
        public string description { get; set; }
        public string short_description { get; set; }
        public bool reviews_allowed { get; set; }
        public string average_rating { get; set; }
        public int rating_count { get; set; }
        public int?[] related_ids { get; set; }
        public object[] upsell_ids { get; set; }
        public object[] cross_sell_ids { get; set; }
        public int parent_id { get; set; }
        public string[] categories { get; set; }
        public string[] tags { get; set; }
        public Image[] images { get; set; }
        public string featured_src { get; set; }
        public Attribute[] attributes { get; set; }
        public object[] downloads { get; set; }
        public int download_limit { get; set; }
        public int download_expiry { get; set; }
        public string download_type { get; set; }
        public string purchase_note { get; set; }
        public int total_sales { get; set; }
        public Variation[] variations { get; set; }
        public object[] parent { get; set; }
        public object[] grouped_products { get; set; }
        public int menu_order { get; set; }
    }

    public class Dimensions
    {
        public string length { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string unit { get; set; }
    }

    public class Image
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string src { get; set; }
        public string title { get; set; }
        public string alt { get; set; }
        public int position { get; set; }
    }

    public class Attribute
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }
        public bool variation { get; set; }
        public string[] options { get; set; }
    }

    public class Variation
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool downloadable { get; set; }
        public bool _virtual { get; set; }
        public string permalink { get; set; }
        public string sku { get; set; }
        public string price { get; set; }
        public string regular_price { get; set; }
        public string sale_price { get; set; }
        public bool taxable { get; set; }
        public string tax_status { get; set; }
        public string tax_class { get; set; }
        public bool managing_stock { get; set; }
        public int? stock_quantity { get; set; }
        public bool in_stock { get; set; }
        public bool backorders_allowed { get; set; }
        public bool backordered { get; set; }
        public bool purchaseable { get; set; }
        public bool visible { get; set; }
        public bool on_sale { get; set; }
        public object weight { get; set; }
        public Dimensions1 dimensions { get; set; }
        public string shipping_class { get; set; }
        public object shipping_class_id { get; set; }
        public Image1[] image { get; set; }
        public Attribute1[] attributes { get; set; }
        public object[] downloads { get; set; }
        public int download_limit { get; set; }
        public int download_expiry { get; set; }
    }

    public class Dimensions1
    {
        public string length { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string unit { get; set; }
    }

    public class Image1
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string src { get; set; }
        public string title { get; set; }
        public string alt { get; set; }
        public int position { get; set; }
    }

    public class Attribute1
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string option { get; set; }
    }

}
