class Circulo: FiguraGeometrica
{
    // public: da acceso desde cualquier nivel, clase, namespace, ensamblado
    // e incluso otros proyectos donde este se agregue.
    public const double PI = 3.1416;
    public double radio, area;

    public override void calcularArea()
    {
        area = PI * (radio * radio);
        System.Console.WriteLine($"El área del circulo es: {area}");
    }
}