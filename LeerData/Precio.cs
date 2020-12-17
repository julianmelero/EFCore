namespace LeerData
{
    public class Precio
    {
        public int PrecioId { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set; }
        public int CursoId { get; set; }

        // Creamos anclas para la FK
        public Curso Curso {get;set;}
    }
}