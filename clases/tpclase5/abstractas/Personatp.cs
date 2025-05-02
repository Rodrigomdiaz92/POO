namespace Clase4
{
    class Personatp
    {
        private string nombre;
        private string apellido;
        private int edad;

        //Constructor
        public Personatp(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public string getnombre()
        {
            return this.nombre;
        }
        public string getapellido()
        {
            return this.apellido;
        }   
        public int getedad()
        {
            return this.edad;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setedad(int edad)
        {
            this.edad = edad;
        }
        public string mostrardatos()
        {
            return this.nombre + " " + this.apellido + " " + this.edad;
        }
    }
}