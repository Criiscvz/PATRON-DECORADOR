// Decorador Concreto A
public class DecoradorA : DecoradorBase
{
    public DecoradorA(IComponente componente) : base(componente) { }

    public override string Operacion()
    {
        return $"Decorator A - {base.Operacion()}";
    }
}