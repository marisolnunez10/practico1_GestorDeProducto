namespace practico1_GestorDeProducto
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string Category { get; set; } = "";
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, {Name}, $ {Price}, Cat: {Category}, Activo: { IsActive }";
        }
    }
}
