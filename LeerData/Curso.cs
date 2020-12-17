using System.Collections.Generic;

namespace LeerData
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        
        // Enlace con Precio
        public Precio PrecioPromocion{get;set;}

        // Enlace con Comentario        
        public ICollection<Comentario> ComentarioLista {get;set;}

    }
}