namespace Clase4 // Note: actual namespace depends on the project name.
{
    public abstract class Persona //Clase abstracta, la mas general de todas las clases
    // No se puede instanciar, solo se puede heredar
{
    private string nombre;
    private string apellido;
    private int numero_documento;
    private string? numero_documento_aux;
    private string tipo_documento;
    //private string nacionalidad;
    private DateTime fecha_nacimiento;

    public Persona(string nombre, string apellido, int numero_documento, string tipo_documento, DateTime fecha_nacimiento)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.numero_documento = numero_documento;
        this.tipo_documento = tipo_documento;        
        this.fecha_nacimiento = fecha_nacimiento;
    }
//sobrecarga de constructor -> Distinta cant. de argumentos
    public Persona (string apellido, int numero_documento, string tipo_documento, DateTime fecha_nacimiento)
    {
        this.nombre =  "Sin nombre";
        this.apellido = apellido;
        this.numero_documento = numero_documento;
        this.tipo_documento = tipo_documento;        
        this.fecha_nacimiento = fecha_nacimiento;
        
    }
    public Persona (string apellido, string numero_documento, string tipo_documento, DateTime fecha_nacimiento)
    {
        this.nombre =  "Sin nombre";
        this.apellido = apellido;
        this.numero_documento_aux = numero_documento;
        this.tipo_documento = tipo_documento;        
        this.fecha_nacimiento = fecha_nacimiento;
        
    }
    public void setfecha_nacimiento(DateTime fecha_nacimiento)
    {
        this.fecha_nacimiento = fecha_nacimiento;
    }
    public string getNombreCompleto()
    {
        return this.nombre + " " + this.apellido;
    }

    public int getedad()
    {
        DateTime fecha_actual = DateTime.Now;
        int edad = fecha_actual.Year - this.fecha_nacimiento.Year;
        // Si la fecha de nacimiento aún no ha ocurrido en el año actual, restamos 1 a la edad
        if (fecha_actual.Month < this.fecha_nacimiento.Month || (fecha_actual.Month == this.fecha_nacimiento.Month && fecha_actual.Day < this.fecha_nacimiento.Day))
        {
            edad--;
        }
        return edad;
    }
}
    
}
