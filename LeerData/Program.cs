using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaCursosContext())
            {  
                var cursos =db.Curso.Include(c=> c.InstructorLink).ThenInclude(ci=> ci.Instructor);
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach (var cursoInstructor in curso.InstructorLink)
                    {
                        Console.WriteLine("**********" +cursoInstructor.Instructor.Nombre);
                    }
                }        
               
            }
        }
    }
}
