
using System;
using System.Collections;
namespace Practica3
{
	class MainClass
	{
		public static void AgregarAlumno(string nombre, string codigo, Hashtable tabla){
			
									

					
					Alumno a = new Alumno(nombre, codigo);
					tabla.Add(codigo,a);
				
			
		}
		public static void VerAlumno(Hashtable tabla){
					
			        Console.Write("\nLos Campos guardados son : \n");
					ICollection key = tabla.Keys;
					foreach (string k in key)
        				 {
						Object obj = tabla[k];
						Alumno alum = (Alumno) obj;
						Console.WriteLine(alum.getDatos());
         					}
			
			
		}
		public static void EliminarAlumno(string codigo, Hashtable tabla){
			

					if(tabla.ContainsKey(codigo)){
						tabla.Remove(codigo);
						Console.WriteLine("Alumno removido con el codigo: "+codigo);
					}
					else
						Console.WriteLine("No existe"+codigo);			
		}
		
		public static void Main (string[] args)
		{
		
			string nombre, codigo;
			int menu;
			Hashtable tabla = new Hashtable();
			Console.WriteLine("\t\tAlejandro Israel Castro Gutierrez\n\n");
			do {
				Console.WriteLine ("\n1.-Registrar Alumno\n2.-Mostrar Alumnos\n3.-Eliminar\n4.-Salir\n ");
				menu=int.Parse(Console.ReadLine());
				switch (menu) {
				case 1 : 
					Console.Write("\nIngresar Nombre de Alumno : \n");
					nombre = Console.ReadLine();
					Console.Write("\nIngresar Codigo de Alumno : \n");
					codigo = Console.ReadLine();
					AgregarAlumno(nombre,codigo,tabla);

					
					break;
				case 2 :
					VerAlumno(tabla);

         					
					break;
				case 3 : 
					Console.WriteLine("Codigo del alumo: ");
					codigo = Console.ReadLine();
					EliminarAlumno(codigo,tabla);

					break;
				
				}
				}	while (menu!=4);
			Console.ReadLine();
		}
	}
}