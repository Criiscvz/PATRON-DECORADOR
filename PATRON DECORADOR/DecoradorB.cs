// Decorador Concreto B
public class DecoradorB : DecoradorBase
{
    public DecoradorB(IComponente componente) : base(componente) { }

    public override string Operacion()
    {
        return $"Decorator B - {base.Operacion()}";
    }
}