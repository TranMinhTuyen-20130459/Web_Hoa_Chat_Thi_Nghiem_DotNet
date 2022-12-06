namespace Model.entity
{
    public class Product
    {
        private string name_product;
        private string desc_product;
        private string url_img_product;
        private int quantity_product;
        private int id_type;
        private int id_status;
        private int id_supplier;
        private int id_product;
        private int listed_price;
        private int current_price;

        public Product(string name_product, string desc_product, string url_img_product, int quantity_product, int id_type, int id_status, int id_supplier)
        {
            this.Name_product = name_product;
            this.Desc_product = desc_product;
            this.Url_img_product = url_img_product;
            this.Quantity_product = quantity_product;
            this.Id_type = id_type;
            this.Id_status = id_status;
            this.Id_supplier = id_supplier;
        }

        public Product(int id_product, int listed_price, int current_price)
        {
            this.id_product = id_product;
            this.listed_price = listed_price;
            this.current_price = current_price;
        }

        public string Name_product { get => name_product; set => name_product = value; }
        public string Desc_product { get => desc_product; set => desc_product = value; }
        public string Url_img_product { get => url_img_product; set => url_img_product = value; }
        public int Quantity_product { get => quantity_product; set => quantity_product = value; }
        public int Id_type { get => id_type; set => id_type = value; }
        public int Id_status { get => id_status; set => id_status = value; }
        public int Id_supplier { get => id_supplier; set => id_supplier = value; }
        public int Id_product { get => id_product; set => id_product = value; }
        public int Listed_price { get => listed_price; set => listed_price = value; }
        public int Current_price { get => current_price; set => current_price = value; }

        public override string ToString()
        {
            return "name= " + Name_product + " ,desc= " + Desc_product + " ,url_img= " + Url_img_product 
                + " ,quantity= " + Quantity_product + " ,id_type= " + Id_type + " ,id_status= " + Id_status + " ,id_supplier=" + Id_supplier;
        }
    }
}
