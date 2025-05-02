namespace Clase4 // Note: actual namespace depends on the project name.
{
    public class Cliente: Persona //Herencia
{
    private int nro_cuit;
    private string tipo_iva;


    public Cliente(string nombre, string apellido, int numero_documento, string tipo_documento, DateTime fecha_nacimiento, int nro_cuit, string tipo_iva) : base(nombre, apellido, numero_documento, tipo_documento, fecha_nacimiento)
    {
        this.nro_cuit = nro_cuit;
        this.tipo_iva = tipo_iva;
    }

    public Cliente(string apellido, int numero_documento, string tipo_documento, DateTime fecha_nacimiento, int nro_cuit, string tipo_iva) : base(apellido, numero_documento, tipo_documento, fecha_nacimiento)
    {
        this.nro_cuit = nro_cuit;
        this.tipo_iva = tipo_iva;
    }

    public void settipo_iva(string tipo_iva)
    {
        this.tipo_iva = tipo_iva;
    }
    public string gettipo_iva()
    {
        return this.tipo_iva;
    }

    
}
    
}
