using System 
namespace CS4
{
    class Program
    {
        static void Main(string[]args)
        {
            // Sesión 7: Estructuras selectivas
            // a. Simple: Instrucción if
            int a = 0;
            int b = 1;
            if (a == 0) // Si el valor de "a" es igual a 1, entinces...
            {
               // Bloque de instrucciones 
               Console.WriteLine($"El valor de 'a' es igual a 0.");
               a += 1;
               Console.WriteLine($"a: {a}");
            }
            // b. Doble: Instrucciones if-else

             bool foco = false; 

           if (foco == true) {
               Console.WriteLine("El foco está encendido."); 
           }
           else {
               Console.WriteLine("El foco está apagado."); 
           }

           // c. Estructura selectiva múltiple 

           int salón = 333; 
           if (salón == 331) {
               Console.WriteLine("Exactas");
           }
           else if (salón == 332 || salón == 333) {
               Console.WriteLine("Administrativas");
           }
           else if (salón == 334) {
               Console.WriteLine("Humanidades");
           }
           else if (salón == 335) {
               Console.WriteLine("Biológicas"); 
           }
           else 
               Console.WriteLine("¡Salón no registrado!"); 

            
        }
    }
}
