namespace Clase4 // Note: actual namespace depends on the project name.
{
    class Automovil
    {
        private string marca;
        private string moodelo;
        private int velocidad_max;
        private int velocidad;
        
// Constructor
        public Automovil(string marca, string modelo, int velocidad_max)
        {
            this.marca = marca;
            this.moodelo = modelo;
            this.velocidad = 0;
            this.velocidad_max = velocidad_max;

        }

        public void Acelerar(int kms)
        {
            int velocidad_aux = this.velocidad + kms;
            if(velocidad_aux <= this.velocidad_max)
            {
                this.velocidad = velocidad_aux;
            } else
            {
                this.velocidad = this.velocidad_max;
            }

        }
        public string getautomovil()
        {
            return  this.marca + " " + this.moodelo + " " + this.velocidad_max + " " + this.velocidad;
        }
    }

    
}
