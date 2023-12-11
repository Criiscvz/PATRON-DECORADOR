internal class Program
{
    private static void Main(string[] args)
    {
        // Componente base
        IComponente componente = new ComponenteConcreto();
        Console.WriteLine("Componente base: " + componente.Operacion());

        // Aplicando Decorador A
        IComponente decoradorA = new DecoradorA(componente);
        Console.WriteLine("Componente con Decorador A: " + decoradorA.Operacion());

        // Aplicando Decorador B
        IComponente decoradorB = new DecoradorB(decoradorA);
        Console.WriteLine("Componente con Decorador B: " + decoradorB.Operacion());
    }
}