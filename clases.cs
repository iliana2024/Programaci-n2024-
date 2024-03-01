
    using System;

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
        }
    }

    public class Alumno : Persona
    {
        public string Carnet { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion,
                      string carnet, DateTime fechaIngreso)
            : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            Carnet = carnet;
            FechaIngreso = fechaIngreso;
        }
    }

    public class Profesor : Persona
    {
        public string Especialidad { get; set; }

        public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion,
                        string especialidad)
            : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            Especialidad = especialidad;
        }
    }

    class Program
    {
        static void Main()
        {
            var alumno1 = new Alumno("Juan", "Pérez", new DateTime(2000, 5, 15), "123456789", "Av. Principal 123",
                                     "A12345", new DateTime(2021, 9, 1));

            var profesor1 = new Profesor("María", "González", new DateTime(1985, 3, 10), "987654321", "Calle Secundaria 456",
                                         "Matemáticas");

            // Puedes crear más instancias aquí y probar los métodos
            Console.WriteLine($"Alumno: {alumno1.Nombre} {alumno1.Apellido}, Carnet: {alumno1.Carnet}");
            Console.WriteLine($"Profesor: {profesor1.Nombre} {profesor1.Apellido}, Especialidad: {profesor1.Especialidad}");
        }
    }