namespace Model.entity
{
    public class StatusProduct
    {
        private int id_status;
        private string name_status;

        public StatusProduct(int id_status, string name_status)
        {
            this.Id_status = id_status;
            this.Name_status = name_status;
        }

        public int Id_status { get => id_status; set => id_status = value; }
        public string Name_status { get => name_status; set => name_status = value; }

        public override string ToString()
        {
            return "Id= " + Id_status + ",Name= " + Name_status;
        }
    }
}
