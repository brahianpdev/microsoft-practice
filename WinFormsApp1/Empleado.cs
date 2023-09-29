namespace WinFormsApp1
{
    public class Empleado
    {
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float SueldoNeto { get; set; }
        private static int contadorIdentificadores = 0; 
        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public Empleado(string nombre, string apellido, float sueldoNeto)
        {
            Identificador = ++contadorIdentificadores;
            Nombre = nombre;
            Apellido = apellido;
            SueldoNeto = sueldoNeto;
        }

        public static void MostrarEmpleados()
        {
            string empleados = "";
            foreach (Empleado empleado in listaEmpleados)
            {
                empleados += $"Identificador: {empleado.Identificador}, Nombre: {empleado.Nombre}, Apellido: {empleado.Apellido}, Sueldo Neto: {empleado.SueldoNeto}\n";
            }
        }

        public static void AgregarEmpleado(string nombre, string apellido, float sueldoNeto)
        {
            listaEmpleados.Add(new Empleado(nombre, apellido, sueldoNeto));
        }

        public static bool EliminarEmpleado(int identificador)
        {
           // Buscar empleado por identificador
           Empleado empleado = listaEmpleados.Find(e => e.Identificador == identificador);

            // Si el empleado existe, eliminarlo de la lista
            if (empleado != null)
            {
                listaEmpleados.Remove(empleado);
                // Imprimir un mensaje que se ha eliminado de la lista
                Console.WriteLine($"Se ha eliminado el empleado con identificador: {identificador}");
                return true;
            }
            else
            {
                Console.WriteLine($"No se ha encontrado un empleado con identificador: {identificador}");
                return false;
            }
        }


        public static void OrdenarSalarios(string orden)
        {
            if (orden == "ASC")
            {
                listaEmpleados.Sort((e1, e2) => e1.SueldoNeto.CompareTo(e2.SueldoNeto));
            } else if (orden == "DESC")
            {
                listaEmpleados.Sort((e1, e2) => e2.SueldoNeto.CompareTo(e1.SueldoNeto));
            }
        }

    }
}
