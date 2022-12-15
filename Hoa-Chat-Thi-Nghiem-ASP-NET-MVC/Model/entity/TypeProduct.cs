namespace Model.entity
{
    public class TypeProduct
    {
        private int id_type;
        private string name_type;

        public TypeProduct()
        {
        }

        public TypeProduct(int id_type, string name_type)
        {
            this.Id_type = id_type;
            this.Name_type = name_type;
        }

        public int Id_type { get => id_type; set => id_type = value; }
        public string Name_type { get => name_type; set => name_type = value; }

        public override string ToString()
        {
            return "Id= " + Id_type + ",Name= " + Name_type;
        }
    }
}
