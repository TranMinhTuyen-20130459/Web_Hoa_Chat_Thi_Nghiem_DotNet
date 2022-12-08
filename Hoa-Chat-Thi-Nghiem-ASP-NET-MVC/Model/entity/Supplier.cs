namespace Model.entity
{
    public class Supplier
    {
        private int id_supplier;
        private string name_supplier;

        public Supplier(int id_supplier, string name_supplier)
        {
            this.Id_supplier = id_supplier;
            this.Name_supplier = name_supplier;
        }

        public int Id_supplier { get => id_supplier; set => id_supplier = value; }
        public string Name_supplier { get => name_supplier; set => name_supplier = value; }

        public override string ToString()
        {
            return "Id= " + Id_supplier + ",Name= " + Name_supplier;
        }
    }
}
