using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFormApp
{
    class Persona
    {
        private int id;
        private String nombre;
        private String apellidos;
        private String direccion;
        private int edad;
        private String email;

        public Persona(int id)
        {
            this.id = id;
        }
        
        public Persona(int id, String nombre, String apellidos, String direccion, int edad, String email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.edad = edad;
            this.email = email;

        }

        public Persona(String nombre, String apellidos, String direccion, int edad, String email)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.edad = edad;
            this.email = email;

        }
        
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }


        override public String ToString() {
            String objString = "id: " + id + 
                " nombre: " + nombre + 
                " apellidos: " + apellidos + 
                " direccion: " + direccion + 
                " edad: " + edad + 
                " email: " + email;
            return objString;
        }
    }
}
