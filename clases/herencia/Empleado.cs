namespace Clase4 // Note: actual namespace depends on the project name.
{
    public class Empleado : Persona //Herencia
    {
        private int nro_legajo;
        private string puesto;
        private double sueldo;
        private DateTime fecha_ingreso;
        private string? fecha_ingreso_aux;


        public Empleado(string nombre, string apellido, int numero_documento, string tipo_documento, DateTime fecha_nacimiento, int nro_legajo, string puesto, double sueldo, DateTime fecha_ingreso) : base(nombre, apellido, numero_documento, tipo_documento, fecha_nacimiento)
        {
            this.nro_legajo = nro_legajo;
            this.puesto = puesto;
            this.sueldo = sueldo;
            this.fecha_ingreso = fecha_ingreso;
        }

        public Empleado(string apellido, int numero_documento, string tipo_documento, DateTime fecha_nacimiento, int nro_legajo, string puesto, double sueldo, DateTime fecha_ingreso) : base(apellido, numero_documento, tipo_documento, fecha_nacimiento)
        {
            this.nro_legajo = nro_legajo;
            this.puesto = puesto;
            this.sueldo = sueldo;
            this.fecha_ingreso = fecha_ingreso;
        }
    }
}
