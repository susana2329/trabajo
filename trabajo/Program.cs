namespace trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           persona pr1 = new persona();
            pr1.nombre = "sofia";
            pr1.edad = 20;
            pr1.peso=55.4;
            pr1.profesion = "tecnica en laboratorio";
            pr1.correr();
            pr1.ejercer();



            gato gat = new gato();
            gat.raza = "siames";
            gat.nombre1 = "dulce de leche";
            gat.edad = 3;
            gat.peso = 5.3;
            gat.pedircomida();
            gat.comer();
            Console.ReadKey();
        }
    }
    public class persona
    {
       public string nombre;
        public int edad;
        public double peso;
        public string profesion;


        public void  correr ()  {
            Console.WriteLine($"{nombre} corre para mantenerse en forma");
            }
        public void ejercer  ()
        {
            Console.WriteLine($"{nombre} esta ejerciendo como {profesion}");
        }
    }
    public class gato
    {
        public string raza;
        public string nombre1;
        public int  edad;
        public double peso;
        
        public void pedircomida()
        {
            Console.WriteLine($"{nombre1} de raza {raza} esta maullando");
        }
        public void comer()
        {
            Console.WriteLine($"{nombre1} esta comiendo apesar que pesa {peso} esta gordo");
        }
    }

}
