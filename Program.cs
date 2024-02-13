namespace ejercicio1DeRepaso
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un nuemero de minutos");
            int numeroUsu=Convert.ToInt32(Console.ReadLine());
            int numeroSegundos;
            int numeroMinutos;
            int numeroHoras;
            int numeroDias;

            numeroSegundos=numeroUsu*60;
            numeroMinutos = numeroUsu;
            numeroHoras = numeroMinutos / 60;
            numeroDias = numeroMinutos /24;

            Console.WriteLine(numeroUsu + "con: " +numeroDias+" "+"dias"+" "+ numeroHoras+" "+"horas"+"  "+numeroMinutos+" "+"minutos" );
        }
    }
}
