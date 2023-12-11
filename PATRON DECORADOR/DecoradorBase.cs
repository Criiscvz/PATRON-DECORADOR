// Clase Decoradora Base
public abstract class DecoradorBase : IComponente
{
    protected IComponente componente;

    public DecoradorBase(IComponente componente)
    {
        this.componente = componente;
    }

    public virtual string Operacion()
    {
        return componente.Operacion();
    }
}