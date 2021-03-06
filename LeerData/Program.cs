﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using(var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.AsNoTracking(); // Devuelve un IQueryable. Sirve para que no esté en caché y devuelva el dato de la BD
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + " | " + curso.Descripcion);                    
                }

                // Cursos con sus precios ( UNO a UNO)
                
                var CursoPrecio = db.Curso.Include( p => p.PrecioPromocion).AsNoTracking();
                foreach (var curso in CursoPrecio)
                {
                    Console.WriteLine(curso.PrecioPromocion.PrecioActual);
                }

                // Curso con sus comentarios (UNO A MUCHOS)
                
                var CursoComentario = db.Curso.Include( c => c.ComentarioLista).AsNoTracking();
                foreach(var curso in CursoComentario)
                {
                    Console.WriteLine(curso.Titulo) ;
                    foreach(var comentario in curso.ComentarioLista) {
                        Console.WriteLine("*******" + comentario.ComentarioTexto);
                    }
                }

                //var CursoInstructor = db.Curso.Include( i => i.InstructorId).AsNoTracking();


                
            }

        }
    }
}
